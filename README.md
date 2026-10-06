# in-class-activities
## Devlogs
### W1
1. The camera no longer moves with the cat, as the positions of the two are no longer linked.
2. Link to itch.io page: https://quintbastianuci.itch.io/gdim-31-first-in-class-activity

### W2
1. I imagine the r, g, and b values are floats in order to allow more precision when choosing colors. When I first went to change the color values of the ball, Unity had them set to using integers, and while three integers does allow for a great variety of colors, I feel like using floats allows for slightly more precise results.
2. The _bounce variable makes sense as an int because the amount of bounces is always a whole number, a ball cannot logically bounce more or less than once at a time, and using a string would make this particular situation needlessly complicated.
3. The error I got during step 4 told me that the program couldn't implicitly convert a double to a float, which tells me that "0.0" without an "f" is recognized by the code as a double variable, and this double variable cannot be treated as though it is a float. The "f" seems to be responsible for converting a number to a float.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 