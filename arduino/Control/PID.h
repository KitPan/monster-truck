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
  void updatePID(int value, float time) {
    int errorNew = value - goal;
    
    if(enableD)
      derivative = ((float) (errorNew - error))/time;
    if(enableI)
      intergral += ((float) error)*time;
    error = errorNew;
    
    pid = (int) (error*kP);
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
    
    if(brakeCheckCount >= brakeCheckFrequency) {
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
  int getBrakeCheckFrequency() {return brakeCheckFrequency;}  //0 Means Disabled
  
  void setKP(float kPIn) {kP = kPIn;}
  void setGoal(int goalIn) {goal = goalIn;}
  
  //=====
  //Misc.
  //=====
  void clearPID() {
    error = 0;
    derivative = 0.0;
    intergral = 0.0;
  }
  
  void addI(float kIIn) {
    enableI = true;
    kI = kIIn;
  }
  void addD(float kDIn) {
    enableD = true;
    kD = kDIn;
  }
  void addBrakeCheck(int brakeCheckFrequencyIn) {
    enableBrakeCheck = true;
    brakeCheckFrequency = brakeCheckFrequencyIn;
  }
  void removeI() {
    enableI = false;
    kI = 0.0;
  }
  void removeD() {
    enableD = false;
    kD = 0.0;
  }
  void removeBrakeCheck() {
    enableBrakeCheck = false;
    brakeCheckFrequency = 0;
    brakeCheckCount = 0;
  }
private:
  int goal;
  
  int error;
  float derivative;
  float intergral;
  
  int pid;
  
  float kP;
  float kI;
  float kD;
  
  boolean enableD;
  boolean enableI;
  
  int brakeCheckCount;
  int brakeCheckFrequency;
  
  boolean enableBrakeCheck;
};
