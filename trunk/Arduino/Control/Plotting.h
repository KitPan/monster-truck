class Plotting {
public:
  //Plots a Vector of Floats
  static void plot(Vector3f data, int scale) {
    Plotting::plot(data.x, data.y, data.z, scale);
  }
  //Plots a Number of Floats
  static void plot(float dataF1, int scale) {
    int dataI1 = (int) (scale*dataF1);
    Plotting::plot(dataI1);
  }
  static void plot(float dataF1, float dataF2, int scale) {
    int dataI1 = (int) (scale*dataF1);
    int dataI2 = (int) (scale*dataF2);
    Plotting::plot(dataI1, dataI2);
  }
  static void plot(float dataF1, float dataF2, float dataF3, int scale) {
    int dataI1 = (int) (scale*dataF1);
    int dataI2 = (int) (scale*dataF2);
    int dataI3 = (int) (scale*dataF3);
    Plotting::plot(dataI1, dataI2, dataI3);
  }
  static void plot(float dataF1, float dataF2, float dataF3, float dataF4, int scale) {
    int dataI1 = (int) (scale*dataF1);
    int dataI2 = (int) (scale*dataF2);
    int dataI3 = (int) (scale*dataF3);
    int dataI4 = (int) (scale,dataF4);
    Plotting::plot(dataI1, dataI2, dataI3, dataI4);
  }
  //Plots a number of Ints
  static void plot(int data1, int data2, int data3, int data4) {
    int buffer[20];
    int pktSize;
    buffer[0] = 0xCDAB;
    buffer[1] = 4*sizeof(int);
    buffer[2] = data1;
    buffer[3] = data2;
    buffer[4] = data3;
    buffer[5] = data4;
    pktSize = 2 + 2 + (4*sizeof(int));
    Serial.write((uint8_t * )buffer, pktSize);
  }
  static void plot(int data1, int data2, int data3) {
    int buffer[20];
    int pktSize;
    buffer[0] = 0xCDAB;
    buffer[1] = 3*sizeof(int);
    buffer[2] = data1;
    buffer[3] = data2;
    buffer[4] = data3;
    pktSize = 2 + 2 + (3*sizeof(int));
    Serial.write((uint8_t * )buffer, pktSize);
  }
  static void plot(int data1, int data2) {
    int buffer[20];
    int pktSize;
    buffer[0] = 0xCDAB;
    buffer[1] = 2*sizeof(int);
    buffer[2] = data1;
    buffer[3] = data2;
    pktSize = 2 + 2 + (2*sizeof(int));
    Serial.write((uint8_t * )buffer, pktSize);
  }
  static void plot(int data1) {
    int buffer[20];
    int pktSize;
    buffer[0] = 0xCDAB;
    buffer[1] = 1*sizeof(int);
    buffer[2] = data1;
    pktSize = 2 + 2 + (1*sizeof(int));
    Serial.write((uint8_t * )buffer, pktSize);
  }
  
  static void interface() {
    Serial.printf("0,");
  }
  static void interface(boolean value) {
    if(value)
      Serial.printf("1,");
    else
      Serial.printf("0,");
  }
  static void interface(int value) {
    Serial.printf("%i,", value);
  }
  static void interface(float value) {
    Serial.printf("%i,", (int) (value*100));
  }
  static void interface(Vector3f value) {
    Serial.printf("%i,%i,%i", (int) (value.x*100), (int) (value.y*100), (int) (value.z*100));
  }
};


