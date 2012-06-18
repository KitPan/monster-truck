class Control {
public:
  //===========
  //Constructor
  //===========
  Control(int steeringCh, int throttleCh, Arduino_Mega_ISR_Registry *isr_registry) {
    //Sets Channels
    stCh = steeringCh;
    thCh = throttleCh;
    
    //Initializes RC Interface
    APM_RC.Init(isr_registry);
    thValZero = 1360;
    stValZero = 1470;
    //Sets Zero Values
    for(int i = 0; i < 100; i++) {
      if(APM_RC.GetState() == 1) {
        thValZero = APM_RC.InputCh(thCh);
        stValZero = APM_RC.InputCh(stCh);
        break;
      }
      delay(10);
    }
    Serial.printf("Steering (CH %i) Zero Value = %i\n", stCh, stValZero);
    Serial.printf("Throttle (CH %i) Zero Value = %i\n", thCh, thValZero);

    APM_RC.OutputCh(stCh, stValZero);
    APM_RC.OutputCh(thCh, thValZero);
    
    APM_RC.enable_out(stCh);
    APM_RC.enable_out(thCh);
  }
  //======
  //Update
  //======
  //Reads Inputs
  boolean updateStart() {
    ready = (APM_RC.GetState() == 1);
    if(ready) {
      thVal = APM_RC.InputCh(thCh);
      stVal = APM_RC.InputCh(stCh);
      
      thFor = (thVal > (thValZero+10));
      thRev = (thVal < (thValZero-10));
      thZero = ((!thFor)&&(!thRev));
    }
    
    return ready;
  }
  //Write Outputs
  void updateFinish() {
    if(ready) {
      APM_RC.OutputCh(stCh, stVal);
      APM_RC.OutputCh(thCh, thVal);
    }
  }
  //==========
  //Accsessors
  //==========
  int getStVal() {return stVal;}
  int getThVal() {return thVal;}
  void setStVal(int val) {stVal = val;}
  void setThVal(int val) {thVal = val;}
  int getThValZero() {return thValZero;}
  int getStValZero() {    return stValZero;}
  boolean getThZero() {return thZero;}
  boolean getThFor() {return thFor;}
  boolean getThRev() {return thRev;}
  boolean getReady() {return ready;}
private:
  //Channel Information
  int stCh;
  int thCh;
  
  //RC Interface Status
  boolean ready;
  
  //Throttle Status
  boolean thFor;
  boolean thZero;
  boolean thRev;
  
  //Zero Values
  int stValZero;
  int thValZero;
  
  //Values
  int stVal;
  int thVal;
  
  //RC Interface
  APM_RC_APM1 APM_RC;
};
