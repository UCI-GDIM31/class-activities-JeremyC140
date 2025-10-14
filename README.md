# in-class-activities
## Devlogs
### W1
Hello World!!!

### W2
1. Why are the r, g, and b variables floats instead of ints, bools, or strings?

The rgb values are declared as floats because they are numeric values and they are variated in the continuous range of 0 - 1, which involves decimals. 

2. Why is the _bounce variable an int instead of a float, bool, or string?

The _bounce variable counts the number of time the ball bounces, which only makes sense when it's recorded in positive integer. 

3. The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?

Syntax error, because a semicolon is missed at the end of a line of code. 

### W3
Table 12:
String GetResponse (int friendShipLv, boolean doesKnowSecret) {}

Monobehavior Questions:
1. Classes are the general prototype or blueprint that structure the behavior or outline the methods for an object, while components are the specific product that details all of the custom properties and methods. For me, classes are like the "default" of an iphone, for example, which includes the very basic outline like "turning on/off the phone", or "the machinary inside the phones". On the other hand, the components would be the iphones that are customized by each individual users, by which the phone still inherits the basic outlines from its "default" mode. The written action / command coded in the iphone, such as "on/off" (which could be represents by a button controling a boolean), "opening apps", or "swiping to a certain direction". The member variables track all sort of datas in the phone. The memories, storage, the type number of this phone might be stored in the static variables, while the passwords, usernames, or the customization details might be stored in the more dynamic variables (which are altered by their corresponding method). 

2. The balls are speeding up by a scale factor of the speedMultiplier (which I setted to be greater than 1)during collisions in the scene. The getColorMultiplier method is essentially tracking the average speed of the balls are increase the scaling of their rgb colors by 1.5 for each time the speed exceeds the speed threshold. Eventually, the balls are getting brighter and brighter as they collide in the scene. 


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 