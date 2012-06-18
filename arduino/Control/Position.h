class Position {
public:
  //===========
  //Constructor
  //===========
  Position(GPS *g_gps, Arduino_Mega_ISR_Registry *isr_registry, int zeroGFrequencyIn) {
    //Sets up Clock
    scheduler.init(isr_registry);
    SPI.begin();
    SPI.setClockDivider(SPI_CLOCK_DIV16);
    
    //Sets up Sensors
    ins = new AP_InertialSensor_Oilpan(&adc);
    imu = new AP_IMU_INS(ins);
    dcm = new AP_DCM(imu, g_gps);
    
    //Initializes Sensors
    imu->init(IMU::COLD_START, delay, LEDs::flashLEDs, &scheduler);
    imu->init_accel(delay, LEDs::flashLEDs);
    Serial.println("");
    
    LEDs::onLEDs();
    
    //Sets Gravity Values
    float gravityTemp = 0.0;
    for(int i = 0; i < 10; i ++) {
      delay(10);
      dcm->update_DCM();
      gravityTemp += fixXY(imu->get_accel()).z;
    }
    gravity = -gravityTemp/10;
    zeroGSet = gravity/2;
    
    Serial.printf("Gravity = %4.4f\n", gravity);
    Serial.printf("Zero Gravity = %4.4f\n", zeroGSet);
    
    LEDs::offLEDs();
    
    zeroGCount = 0;
    zeroGFrequency = zeroGFrequencyIn;
  }
  //======
  //Update
  //======
  void updatePos() {
    //Updates DCM
    dcm->update_DCM();
    
    //Updates Time
    time = (imu->get_delta_time());
    
    //Updates Raw Sensor Data
    gyro = fixXY(imu->get_gyro());
    accel = fixXY(imu->get_accel());
    
    //Updates Gravity State
    accelMod = sqrt(sq(accel.x)+sq(accel.y)+sq(accel.z));
    if(accelMod < zeroGSet){
      zeroGCount ++;
      zeroG = (zeroGCount >= zeroGFrequency);
    }
    else {
      zeroGCount = 0;
      zeroG = false;
    }
    
    //Updates Position
    pitch = (int)(dcm->roll_sensor)*-1;
    roll = (int)(dcm->pitch_sensor);
    yaw = (int)(dcm->yaw_sensor)*-1;
    if(yaw < -180)
      yaw = yaw + 360;
  }
  //==========
  //Accsessors
  //==========
  Vector3f getGyro() {return gyro;}
  Vector3f getAccel() {return accel;}
  float getAccelMod() {return accelMod;}
  boolean getZeroG() {return zeroG;}
  float getTime() {return time;}
  int getPitch() {return pitch;}  //100*deg
  int getRoll() {return roll;}    //100*deg
  int getYaw() {return yaw;}      //100*deg
  
  void setZeroG(boolean zeroGIn) {zeroG = zeroGIn;}
private:
  //Gravity Set Points
  float gravity;
  float zeroGSet;
  
  //Time
  float time;
  
  //Raw Sensor Data
  Vector3f accel;
  Vector3f gyro;
  
  //Gravity State
  float accelMod;
  boolean zeroG;
  int zeroGCount;
  int zeroGFrequency;

  //Position Data
  int roll;
  int pitch;
  int yaw;

  //Scheduler
  AP_TimerProcess scheduler;
  //Sensors
  AP_ADC_ADS7844 adc;
  AP_InertialSensor_Oilpan *ins;
  AP_IMU_INS *imu;
  AP_DCM *dcm;
  
  static Vector3f fixXY(Vector3f vec) {
    Vector3f vecNew;
    
    vecNew.x = -1*vec.y;
    vecNew.y = vec.x;
    vecNew.z = vec.z;
    
    return vecNew;
  }
};
