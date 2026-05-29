public class Modifications
{/*
    ░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ */

    /*  ================================================================
        GAUNTLET RUNNER
        ================================================================
        1 - directional light (colour, intensity, etc)
        modifications: 
        - Rotated directional light
        - Changed color to blue
        - Decreased intensity
        - Reduced Shadow Strenght

        2 - fog
        modifications: 
        - Enabled Fog
        - Changed the color to dark red
        - Changed the Density to 0.038

        3 - create & apply skybox and customise it (atmosphere thickness, sky tint, exposure, etc)
        modifications: 
        - Removed Sun
        - Set exposure to 1.38
        - Increased the Atmosphere Thickness
        
        OBSTACLE PREFAB
        4 - add or modify light component (colour, range, intensity, etc)
        modifications: 
        - Added an "OrbLight" that has an animation which loops the intensity increasing and lowering to make it seem it is fading in/out
        - OrbLight was given a Blue color to match the outer orb
        - Intensity was animated to increase and decrease
        - Hard shadows are enabled
        - Changed light to a spot light to (point light was not very visible)
        - The transform of the light was adjusted to face the direction of the player to be able to see the light and its animation
        
        POWERUP PREFAB
        5 - replace with a new complex object comprised of 3 or more shapes (different from previously made object)
        modifications: 
        - Created a custom leverless fight stick with a custom material
        - Added a spot light pointing at the object to be able to see the design
        -

        6 - use gameobject hierarchy to keep the powerup prefab organised
        [no record necessary]

        7 - apply at least 2 new textures
        (add source url or package name)
        texture source 1: (Sakurai) https://gonintendo.com/attachments/image/66773/file/medium-802020b8a20cd68908cf61ec36c92305.png (Website URL: https://gonintendo.com/contents/50021-sakurai-says-creating-large-scale-games-has-become-too-time-consuming-and) 
        texture source 2: https://t3.ftcdn.net/jpg/01/95/88/62/360_F_195886218_P45NQjKjHELqlClexKDYkOz4pk1QLuNb.jpg (Website URL: https://stock.adobe.com/search?k=seamless+tie+dye+pattern)

        8 - add particle system component and customise at least 3 parameters
        parameter 1: Changed the Color over life time to display blue at the start and green at the end of the lifetime
        parameter 2: Increased duration
        parameter 3: Increase Emission
        parameter 4: Increased the Size overlife time using a curve

        WALL
        9 - convert a wall to prefab, create a variant, and use the variant to replace the other wall in the scene
        [no record necessary]

        10 - modify wall prefab material tint so that the 2 walls are different in appearance or colour
        [no record necessary]
     


        Extra personal change:
        - Created a prefab of the TriggerZone and increased the size to make sure every object that passes through it gets destroyed properly
     */


}