class PID {
public:
  //===========
  //Constructor
  //===========
  PID(int goalIn, float kPIn) {
    
    setGoal(goalIn);
    setKP(kPIn);
    
    clearPID();
    
    removeD();
    removeI();
    removeBrakeCheck();
  }
  //======
  //Update
  //======
  void updatePID(int value, float timeIn) {
    if(enableI||enableD)
      for(int i = 1; (i <= derivativeFreq)||(i <= 1); i ++) {
        error[i] = error[i - 1];
        time[i] = time[i - 1];
      }
    error[0] = value - goal;
    time[0] = timeIn;
    
    if(enableD) {
      float deltaTime = 0.0;
      for(int i = 0; i <= derivativeFreq; i ++)
        deltaTime += time[i];
      derivative = ((float) (error[derivativeFreq] - error[0]))/deltaTime;
    }
    if(enableI)
      intergral += ((float) (error[0] + error[1])/2)*time[0];
    proportion = (float) error[0];
    
    pid = (int) (proportion*kP);
    if(enableD)
      pid += (int) (derivative*kD);
    if(enableI)
      pid += (int) (intergral*kI);
  }
  //==========
  //Accsessors
  //==========
  int getPID() {
    if(!enableBrakeCheck)
      return pid;
    
    if(brakeCheckCount >= brakeCheckFreq) {
      brakeCheckCount = 0;
      return 0;
    }
    
    brakeCheckCount ++;
    return pid;
  }
  float getkI() {return kI;}
  float getKP() {return kP;}  //0 Means Disabled
  float getKD() {return kD;}  //0 Means Disabled
  int getGoal() {return goal;}
  int getBrakeCheckFreq() {return brakeCheckFreq;}  //0 Means Disabled
  
  void setKP(float kPIn) {kP = kPIn;}
  void setGoal(int goalIn) {goal = goalIn;}
  
  //=====
  //Misc.
  //=====
  void clearPID() {
    proportion = 0.0;
    derivative = 0.0;
    intergral = 0.0;
    
    for(int i = 0; i < 10; i ++) {
      error[i] = 0.0;
      time[i] = 0;
    }
  }
  
  void addI(float kIIn) {
    enableI = true;
    kI = kIIn;
  }
  void addD(float kDIn, int derivativeFreqIn) {
    enableD = true;
    kD = kDIn;
    derivativeFreq = derivativeFreqIn;
    if(derivativeFreq > 9)
      derivativeFreq = 9;
    if(derivativeFreq < 1)
      derivativeFreq = 1;
  }
  void addBrakeCheck(int brakeCheckFreqIn) {
    enableBrakeCheck = true;
    brakeCheckFreq = brakeCheckFreqIn;
  }
  void removeI() {
    enableI = false;
    kI = 0.0;
    intergral = 0.0;
  }
  void removeD() {
    enableD = false;
    kD = 0.0;
    derivative = 0.0;
    derivativeFreq = 0;
  }
  void removeBrakeCheck() {
    enableBrakeCheck = false;
    brakeCheckFreq = 0;
    brakeCheckCount = 0;
  }
private:
  int goal;
  
  int error[10];
  float time[10];
  
  int pid;
  
  float kP;
  float proportion;
  
  boolean enableD;
  float kD;
  float derivative;
  int derivativeFreq;
  
  boolean enableI;
  float kI;
  float intergral;
  
  boolean enableBrakeCheck;
  int brakeCheckCount;
  int brakeCheckFreq;
  
};
