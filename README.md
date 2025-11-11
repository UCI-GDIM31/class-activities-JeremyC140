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

### W4
Describing Codes (Table #12):
Line 17: _isGrounded is a member boolean variable that is initialized to "true". The "private" modifier makes this variable only accessible to the class. If other classes want to access or modify this variable, they might have to do so through getter / setter methods written in the class. 
Line 28: an if statement checking for two conditions: spacebar is pressed AND the status of _isGrounded. The condition is evaluated True when spacebar is pressed and _isGrounded is true (then the actions inside the if statement makes the cat jumps). 
Line 32: At the same time the cat jumps, _isGrounded is setted false, marking that the cat is currently in air and disallowing the condition to be evaluated True temporary (which avoids double-jumps). 

Collision Discussion (Table #12):
What solution did you come up with for the collider activity, and why? 
Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
- Final result:
Cat: Collider + Rigidbody (also with Freeze Rotation in x, y, z checked XD, or else the world would be rotating once the cat kicks)
Soccerball: Collider + Rigidbody
Goal: Collider + isTrigger
- I've came to these solutions through several trial-and-error. At first, I'm confirmed with adding rigidbody to both the cat and the soccerball because they are the objects that are supposed to collide and move correspondingly during the play. Also, the goal should has isTrigger on because it collides to do action behind the scene (adding score and effects). 

IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
- The problem that has obstructed me is how the whole world start spinning after the cat kicks the ball. I tested with eliminating the mass of the cat (as I thought the gravity cause the platform to rotate over XD) or checking / unchecking the settings in the rigidbody, but eventually found that freezing the rotation is the key. I should read instructions thoroughly from the start, but I felt proud of discovering the solution on my own. 
### W5
How do we know which gameObject's update() is called first?
The order is sort of randomized, but basically they will run in the same frame without really noticeable difference in sequence or timing. 
I'm still curious about the application of the vector shorthand NegativeInfinity and PositiveInfinity :3

Your notes should answer the following questions:
What member variable(s) does this class need?
A NavMeshAgent variable (for declaration), and also a transform variable accessible in the inspector that mark the location for the NavMeshAgent to follow with. 

What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
To achieve the function that the example showed, we just need the Start method that initialize the NavMeshAgent and set destination for gameObject to move toward.

What should the method(s) do?
At first, we thought we have to use the SetPath method and design a path for the gameObject. But after receiving the hints, we found that we just have to assign a destination (which would be a Transform variable) to the NavMeshAgent to get the gameObject moving. 
### W6
What member variables does this class need?
A serializeField variable recording the speed, a serializeField array so the bat gameObjects could be inserted in the inspector, and a boolean variable stating whether the bats are allowed to attack.


What methods does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write? What should the method(s) do?
The Start() method could be used to initialize the variables, such as the boolean.
The Update() method would traverse all elements in the array if the boolean says true, and probably induce the bats toward the player's position using NavMeshAgent methods. 
A terminated method that the BatManager could call, which set the GameObject inactive (to stop the movement of the bats).
Another starting method that set the GameObject active to begin the movements of the bats. 
A check collision trigger method to detect whether the players collide with the bats (?)

Our table's resource guide: https://docs.google.com/document/d/1JjeQbCCUjY07LrZi49c0iomh2LtX_U5325lBy6n0Y44/edit?usp=sharing 

### W7
What was wrong with the code in Step 2?
When we test the original code, we found that if we want the muskrat to move forward / backward after it spins around, it actually goes forward / backward following the global z-axis, rather than the muskrat's own z-axis. We change the vector3.forward to transform.TransformDirection(Vector3.forward) in order for the muskrat to follow its local axis.

Game engineering plan table #12 - I did most of the UI system part
https://docs.google.com/document/d/10R14qZZetU1eLqxvVqzBbsszbVETJhnGCUluOARTfZg/edit?usp=sharing

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 