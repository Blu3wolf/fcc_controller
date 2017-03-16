### FCC3 controller board
This Arduino Based project, is meant to allow FCC3 force sensing mod for Cougar, to be used with Thrustmaster warthog without the need to use the old TM Cougar Electronics

##### Features:
  * 11 bit output on Pitch and Roll
  * Support for both Cougar and Warthog grips
  * Multiple force presets (9Kg/f, 6Kg/f & 3Kg/f), in addition you can manually set input limits.
  * User toggleable realistic force ratios. IRL full pitch up command is about 18KG/f, while full pitch down and full roll are about 8Kg/f. It is possible to maintain that ratio in the controller. i.e in 9Kg/f mode, full pitch up will be 9kg/f for full deflection, but on the other axis, only 4kg/f will be required.
  * User toggleable FLCS sensor rotation. In later blocks, the stick sensor is rotated clockwise to reduce accidental roll on pitch commands. Activating this option will simulate that.
  * on the fly re-centering (just in case)

##### BOM:
* [Arduino pro-micro](http://www.ebay.com/sch/i.html?_from=R40&_trksid=p2050601.m570.l1313.TR0.TRC0.H0.Xarduino+pro-micro.TRS0&_nkw=arduino+pro-micro&_sacat=0)
* [MCP3202 ADC](http://www.ebay.com/sch/i.html?_odkw=arduino+pro-micro&_osacat=0&_from=R40&_trksid=p2045573.m570.l1313.TR0.TRC0.H0.XMCP3202.TRS0&_nkw=MCP3202&_sacat=0)
* A small protoboard (cheap dual sided 4*6 will be good enough)
* A momentary push button and 10+ Kohm resistor - for reset switch
* Header pins, two 3 pin headers and one 5 pins header, for grip and analog sensors. Generic 0.1" headers will do the trick. But correct header will be the [ JST EH series connectors](http://www.jst-belgium.be/productSeries.php?pid=46).
* Female Headers for the Arduino (optional)
* DIP8 socket for the MCP (optional)

 <u>note:</u> you can use an Arduino Micro (instead of Pro-micro). it will not require the external button.