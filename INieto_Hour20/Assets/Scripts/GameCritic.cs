/*
1.) Is the game too easy or hard?
    Currently the difficulty of the game is easy. It is not too difficult, but not incredibly easy. I would say it is around the middle that anyone can play this game and understand it.

2.) What changes would you do to make it easier or harder?
    The changes I would add to make it easier would be to have a way to "sprint" or increase the speed to have a chance to reach the collectable instead of just the one speed setting when holding a direction. To make it difficult I would modify the speed of the game and increase the length of the obstacles to block the player's path and have them debate if the risk is worth it

3.) What would make the game more appealing?
    More art (Mostly sound would bring a better vibe like pick up sound effects and music. I can imagine this with a sci-fi technologically advanced city, Cyberpunk, or tron like music). Also, more animations (specifically for turning) to make it feel more alive and immersive. That way it is not just a character that is forever running and is moved around in space always facing the same direction.

4.) What parts of the game are fun? 
    The steady pace and collecting the items right before they slip by you make this game fun.

5.) What parts of the game are tedious?
    There is nothing too different. Not much variety in the gameplay. That is not always bad, but in this case if someone was looking for a challenge this would not be too difficult. Another tedious aspect would be the camera angles. Sometimes you could miss some points because of the perspective not lining up exactly as you would think.
 

GAME CHANGES:

- Changed the sphere mesh to a Chest and editted the particle system 
- Decreased Duration, 
- Start lifetime Increased, 
- Decreased Start Speed to create a unique effect
- Start size was changed to have 2 random constants to have different sizes on each particle
- Color over life time was made to blend between two colors (Yellow and Orange)
- Shape of the emitter was changed into a cone and the Arc loops. Angle and radius have been adjusted, Location of the shape was adjusted
- Size over lifetime curve was changed to have a starting value of 2 and the end value to be at half of the curve graph
- Changed the Obstacle to a plus sign which holds a holographic golden ball and this new object slightly extend the obstacle
- Empty GameObjects were added in these prefabs so each new object added has transforms that can be editted and will not distort
- Added HazardLines Texture for the obstacle Prefab (Link: https://static.vecteezy.com/system/resources/previews/010/948/846/non_2x/warning-seamless-pattern-with-yellow-and-black-diagonal-stripes-warn-caution-background-yellow-and-black-lines-tape-hazard-caution-sign-seamless-texture-illustration-vector.jpg)
 */