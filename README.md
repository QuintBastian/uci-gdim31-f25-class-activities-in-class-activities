# in-class-activities
## Devlogs
### W1
1. The camera no longer moves with the cat, as the positions of the two are no longer linked.
2. Link to itch.io page: https://quintbastianuci.itch.io/gdim-31-first-in-class-activity

### W2
1. I imagine the r, g, and b values are floats in order to allow more precision when choosing colors. When I first went to change the color values of the ball, Unity had them set to using integers, and while three integers does allow for a great variety of colors, I feel like using floats allows for slightly more precise results.
2. The _bounce variable makes sense as an int because the amount of bounces is always a whole number, a ball cannot logically bounce more or less than once at a time, and using a string would make this particular situation needlessly complicated.
3. The error I got during step 4 told me that the program couldn't implicitly convert a double to a float, which tells me that "0.0" without an "f" is recognized by the code as a double variable, and this double variable cannot be treated as though it is a float. The "f" seems to be responsible for converting a number to a float.

### W3
Table Number: 4

Activity 1. For GetResponse, we felt that a string made sense as a return type to represent the character's dialogue, and that the parameters of friendship level and whether or not the player knows the character's secret would be best represented as an int and bool respectively. We felt that SetLightDimness would make sense with a float or int parameter, depending on the programmer's desired preciseness. For DidPlayerHitBeat, we felt that the function should return a bool to indicate whether or not the player hit on the beat, and take two float parameters to represent when the beat should be pressed and when the player pressed the button.

Activity 2. Our group compared the relationship between classes and components to that of recipes and tacos. In our analogy, a recipe (class) contains ingredients (GameObjects), quantities (member variables), and instructions (methods), that all work together to ultimately form a taco (component).

Activity 3. I believe the balls get extremely bright when they bounce too many times due to the fact that the method that affects its color is multiplicative, resulting in greater and greater brightness every time the method is called.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 