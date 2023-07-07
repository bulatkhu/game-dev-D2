# Open World (12 Points)

In this exercise you will create a big open world. The assets can be found on the Assets tab, but you can also use your own. The PlayerController is provided as a prefab for either the Input Manager or the Input System.

**Important**: Since your game might be more demanding than previously, you should also provide a Windows build in addition to WebGL. If your WebGL build doesn't run properly, it can't be graded.

## 1) Worldbuilding (5 Points)

While not part of the tasks, please consider adding post-processing effects with Global and Local volumes to make the different areas stand out more.
There might be lighting issues where some objects aren't illuminated properly, which is especially apparent at nighttime. Remember to generate the lighting, but beyond that you don't need to fix this.

- Create one world per group member using the terrain tools. The world should be reasonably large, fully textured and contain a mountain range and a forest.
- Add various trees and a Wind Zone to your terrain. Then create two skyboxes (one for day and one for night) and add the daytime skybox to your Scene.
- Create a village by adding various models and particle systems from the package to a fitting location. There should be at least ten different objects.
- The music should change when the player enters different areas. Add a few different music tracks and make sure that one of them is playing when you enter the village and a different one when you leave.
- Create a main menu. The world can be selected by clicking on a screenshot of your landscape. If the player presses R while in a world, they are brought back to the menu. There will be an issue where the cursor will be gone after returning to the menu. You need to set Cursor.visible and Cursor.lockState to the proper values to fix this issue.

## 2) Mechanics (7 Points)

For the following tasks, you are allowed to create the necessary scripts together as a group. However, the mechanics must work inside of your own world to get your points.
Before you start, take a look at the PlayerController and find out how the parent object and the Camera on the child are working together. You may need to use the child transform for some of the tasks.

- Write a script that rotates the sun so that it becomes nighttime on pressing Q and daytime on pressing E. Whenever the time of day changes, activate the corresponding skybox from 1b.
- Add a flashlight to the PlayerController. Pressing the F key toggles the light on and off and plays SFXFlashlight.
- The player can throw a ball by clicking the Right Mouse Button. The ball should fly straight ahead and have enough mass and force to knock over the objects from the next few tasks.
- Pressing the Left Mouse Button spawns a textured box in front of the player. The box moves with the player until the mouse button is released, which makes it fall down to the ground.
- If the player is looking at a previously placed box and presses the Left Mouse Button, instead of creating a new box, the old one is picked up. This box is then carried around until the mouse button is released again.
- [Hard] The player can choose between different boxes to spawn for the previous tasks. The options are shown in the UI and can be selected by using the number keys. The currently selected box is highlighted.
- [Hard] One of the possible boxes is a Companion Cube. This is a cube with a different color on each side. There can always only be one Companion Cube. If the player tries to create a second one, the current Companion Cube is teleported in front of the player instead.

## Submission

Share your game in the Moodle forum **Open World (D2)** as a group. Your submission has to include:

- A link to a working WebGL build and the names of everyone in your group.
- In case your WebGL build isn't running well in the browser: a link to a working Windows build (to be absolutely sure, you might want to provide both).
- Which world was made by which group member.

**The deadline for this exercise is July 16th.** Since this is the last week of the semester, there will be no additional points for feedback. Of course, you are still encouraged to play other students' games and post some comments.