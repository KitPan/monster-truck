/*
# define A_LED_PIN        37
# define B_LED_PIN        36
# define C_LED_PIN        35
# define LED_ON           HIGH
# define LED_OFF          LOW
*/
class LEDs {
public:
  static void flashLEDs(bool on) {
    digitalWrite(37, on?LOW:HIGH);
    digitalWrite(36, on?HIGH:LOW);
    digitalWrite(35, on?LOW:HIGH);
  }
 static void offLEDs() {
   LEDs::offLEDA();
   LEDs::offLEDB();
   LEDs::offLEDC();
 }
 static void offLEDA() {
   digitalWrite(37, LOW);
 }
 static void offLEDB() {
   digitalWrite(36, LOW);
 }
 static void offLEDC() {
   digitalWrite(35, LOW);
 }
 static void onLEDs() {
   LEDs::onLEDA();
   LEDs::onLEDB();
   LEDs::onLEDC();
 }
  static void onLEDA() {
   digitalWrite(37, HIGH);
 }
 static void onLEDB() {
   digitalWrite(36, HIGH);
 }
 static void onLEDC() {
   digitalWrite(35, HIGH);
 }
};
