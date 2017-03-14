I spent the day working on the first steps of a program managing a strip of neopixels.  I Learned a lot and wanted to share.  

The goal:  To build a mobile app that can manage patterns on a strip of neopixels.

Parts used:
Arduino Uno
16 foot strip of 300 WS2812B LEDs
Hobby power supply at 60 Amps
HC-06 Bluetooth Slave Device

Softwares:
Xamarin.Forms code only with Android
Arduino IDE

Repository:
https://github.com/robertcmolidor/GlowManager
Folder contains the project
Sketch contains the arduino code

My main challenge was getting android to talk to bluetooth.  With these devices we have to go the bluetooth classic route and skip any nuget packages that make this easy.  I kept being pulled back to an example that I leaned on heavily to build the bluetooth manager in the Android project.  
https://github.com/acaliaro/TestBth
Going with platform specific for the service and using dependency service to access it from the pcl worked out better than I thought.  It still ended up quite a mess since it’s my first time dealing with bluetooth but the only problem I have left is that my code does not cleanly destroy the connection to the bluetooth device rendering the app unable to reconnect until the app is restarted.  Suggestions on that would be cool. At this point there is no decoding on the arduino side, but it does work so there’s that.

This is really is a proof of concept so it’s rough and dirty.  Where I hope it helps you is in sending data over the air to the bluetooth device.  I had a lot of fun figuring that out.
