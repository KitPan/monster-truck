//Libraries
#include <FastSerial.h>
#include <SPI.h>
#include <I2C.h>
#include <Arduino_Mega_ISR_Registry.h>
#include <AP_PeriodicProcess.h>
#include <AP_InertialSensor.h>
#include <AP_ADC.h>
#include <AP_IMU.h>
#include <AP_DCM.h>
#include <AP_Math.h>
#include <AP_Common.h>
#include <AP_Compass.h>
#include <DataFlash.h>
#include <APM_RC.h>
#include <AP_GPS.h>
#include <AP_PID.h>

//Personal Libraries
#include "LEDs.h"
#include "Plotting.h"
#include "Position.h"
#include "Control.h"
#include "PID.h"

//Definitions
#define CH_ST CH_1
#define CH_TH CH_3

//Degugging Definitions
//#define DEBUG_PLOT
//#define DEBUG_PRINT
//#define DEBUG_INTERFACE

//#define DEBUG_ZEROG
//#define DEBUG_FULLG

//#define DEBUG_NO_CONTROL
//#define DEBUG_NO_ZEROG_CONTROL
#define DEBUG_NO_FULLG_CONTROL

//Global Objects
FastSerialPort(Serial, 3);
Arduino_Mega_ISR_Registry isr_registry;
static GPS *g_gps;

Position *pos;
Control *con;

PID *zeroGTh;
PID *fullGThFwd;
PID *fullGThRev;
PID *fullGSt;


void setup(void) {
  Serial.begin(9600);
  isr_registry.init();
  
  Serial.println("\nDCM RC Feedback Test");
  
  Serial.println("\nRC Setup");
  con = new Control(CH_ST, CH_TH, &isr_registry);
  
  Serial.println("\nSensor Setup");
  pos = new Position(g_gps, &isr_registry, 2);
  
  Serial.println("\nPID Setup");
  Serial.println("Zero Gravity Throttle");
  zeroGTh = new PID(0, -.060, 0.0, 0.0);
  zeroGTh->addBrakeCheck(10);
  Serial.println("Full Gravity Throttle");
  fullGThFwd = new PID(10*100, -0.2, 0.0, 0.0);
  fullGThRev = new PID(-10*100, 0.2, 0.0, 0.0);
  Serial.println("Full Gravity Steering");
  fullGSt = new PID(0, 0.1, 0.0, 0.0);
  
  Serial.println("\nStart!");
}

void loop(void) {
  delay(2);
  //===============
  //Updates Control
  //===============
  if(con->updateStart()) {
    int thOut;
    int stOut;

    //================
    //Updates Position
    //================
    pos->updatePos();
    #ifdef DEBUG_ZEROG
    pos->setZeroG(true);
    #endif
    #ifdef DEBUG_FULLG
    pos->setZeroG(false);
    #endif 
    
    //==========
    //Processing
    //==========
    zeroGTh->updatePID(pos->getPitch(), pos->getTime());
    fullGThFwd->updatePID(pos->getPitch(), pos->getTime());
    fullGThRev->updatePID(pos->getPitch(), pos->getTime());
    fullGSt->updatePID(pos->getRoll(), pos->getTime());
    
    //Mid Air Stabilization
    if(pos->getZeroG()) {
      thOut = con->getThValZero() + (int) zeroGTh->getPID();
      stOut = con->getStVal();
      
      #ifdef DEBUG_NO_ZEROG_CONTROL
      thOut = con->getThVal(); 
      #endif
    }
    //On Ground Stabilization
    else {
      if(!con->getThZero()) {
        int throttle = con->getThVal() - con->getThValZero();
        
        int throttleMax = 600 + (int) fullGThFwd->getPID();
        int throttleMin = -600 - (int) fullGThRev->getPID();
        
        if(throttleMax < 0)
          throttleMax = 0;
        if(throttleMin > 0)
          throttleMin = 0;
        
        if(throttle > throttleMax)
          throttle = throttleMax;
        if(throttle < throttleMin)
          throttle = throttleMin;
        
        Serial.println((int) fullGSt->getPID());
        
        thOut = con->getThValZero() + throttle;
        stOut = con->getStVal();
        
        #ifdef DEBUG_NO_FULLG_CONTROL
        thOut = con->getThVal();
        stOut = con->getStVal();
        #endif  
      }
      else {
        thOut = con->getThVal();
        stOut = con->getStVal();
      }
    }
  
  //===================
  //Serial Print Output
  //===================
    #ifdef DEBUG_PRINT
    Serial.printf("%i, %f", (int) (pos->getTime()*1000), pos->getTime());
    Serial.println("");
    #endif
    
    //==================
    //Serial Plot Output
    //==================
    #ifdef DEBUG_PLOT
    #endif
    
    //=======================
    //Serial Interface Output
    //=======================
    #ifdef DEBUG_INTERFACE
    Plotting::interface((int) (pos->getTime()*1000));
    
    Plotting::interface(pos->getRoll()/100);
    Plotting::interface(pos->getPitch()/100);
    Plotting::interface(pos->getYaw()/100);
    Plotting::interface(pos->getZeroG());
    
    Plotting::interface(thOut);
    Plotting::interface(stOut);
    /*
    Plotting::interface(); //Series 1
    Plotting::interface(); //Series 2
    Plotting::interface(); //Series 3
    Plotting::interface(); //Series 4
    Plotting::interface(); //Series 5
    */
    /*
    Plotting::interface(); //Series 6
    Plotting::interface(); //Series 7
    Plotting::interface(); //Series 8
    Plotting::interface(); //Series 9
    Plotting::interface(); //Series 10
    */
    Serial.println();
    #endif
    
    //==============
    //Control Output
    //==============
    #ifndef DEBUG_NO_CONTROL
    con->setThVal(thOut);
    con->setStVal(stOut);
    #endif
    con->updateFinish();
  }
}

