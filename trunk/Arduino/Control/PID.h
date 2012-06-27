class PID {
public:
  PID(int goalIn, float kPIn, float kIIn, float kDIn) {
    goal = goalIn;
    
    kP = kPIn;
    kI = kIIn;
    kD = kDIn;
    
    Serial.printf("Goal = %i (kP = %4.4f, kI = %4.4f, kD = %4.4f)\n", goal, kP, kI, kD);
    
    proportional = 0.0;
    intergral = 0.0;
    derivative = 0.0;
    
    filterD = 1;
    
    brakeCheck = false;
  }
  void updatePID(int value, float time) {
    for(int i = 1; i <= filterD; i ++) {
      errors[i] = errors[i - 1];
      times[i] = times[i - 1];
    }
    errors[0] = (float) (value - goal);
    times[0] = time;
    
    proportional = errors[0];
    intergral += (errors[0] + errors[1])/2*times[0];
    float deltaT = 0.0;
    for(int i = 0; i < filterD; i ++)
      deltaT += times[i];
    derivative = (errors[0] - errors[filterD])/deltaT;
  }
  
  float getPID() {
    if(brakeCheck) {
      if(brakeCheckCount >= brakeCheckFreq) {
        brakeCheckCount = 0;
        return 0.0;
      }
      brakeCheckCount ++;
    }
    return proportional*kP + intergral*kI + derivative*kD;
  }
  
  void addBrakeCheck(int brakeCheckFreqIn) {
    brakeCheck = true;
    brakeCheckCount = 0;
    brakeCheckFreq = brakeCheckFreqIn;
  }
  void addFilterD(int filterDIn) {
    filterD = filterDIn;
    if(filterD < 1)
      filterD = 1;
    if(filterD > 9)
      filterD = 9;
  }
private:
  int goal;
  
  int errors[10];
  float times[10];
  
  int filterD;
  
  float proportional;
  float intergral;
  float derivative;
  
  float kP;
  float kI;
  float kD;
  
  boolean brakeCheck;
  int brakeCheckFreq;
  int brakeCheckCount;
};
