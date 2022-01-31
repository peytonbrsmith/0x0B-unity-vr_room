0x0B. Unity - VR Room
=====================

[Demo Video](https://www.youtube.com/h6N_nfO-6gE)

***Built with Unity 2020, XR Interaction Toolkit, and C#***

Learning Objectives
---------------------

-   What are the different types of locomotion / movement in VR
-   What causes VR motion sickness
-   What are the different methods of minimizing VR motion sickness in
    locomotion implementations
-   How to implement a teleportation method of movement in VR
-   How to implement interactive objects in VR

Tasks
-----

### 0. You ever wonder why we're here

In this project, you will be creating a sitting / standing VR experience
in the form of a simple exploration (mandatory tasks) or **“escape
room”** -style **game** (advanced tasks).

Unlike previous Unity projects, there is a lot of freedom in how you can
approach this project and many design choices will be left up to you.
This project will be manually reviewed, therefore your main priority in
this project is to ensure a smooth, comfortable user experience while
meeting each task’s requirements. Take this opportunity to build a
portfolio piece and showcase your creativity and skill!

Download and unzip **this Unity scene and assets** . Import the VR SDK
of the target headset you’re developing for and place the Camera /
Player object and at least one controller into the scene. Play your
scene in your headset and ensure that the head / camera and controller
tracking is working correctly.

If you’re unfamiliar with escape room games and want to tackle the
advanced tasks, here are a couple lists of games to try to give you an
idea of the kinds of puzzles these games can have:

-   Non-VR: **JayIsGames Escape Game Reviews**
-   VR: **VR Escape Room Games**

### 1. Instant transmission

Implement the “teleportation” method of movement so that the user can
use the controller to indicate where they want to move and move there on
button press.

-   The user should not be able to teleport outside the boundaries of
    the room or into other objects, i.e. they cannot pass through
    colliders
-   The user should not be able to teleport through the closed door
-   Give the user visual feedback that indicates where they are
    teleporting to
-   Make sure to reduce chances of motion sickness in your
    implementation of the teleportation
-   Even if you are developing for a 6DOF headset, you should still
    implement a method of teleportation to account for different play
    area sizes

Test the scene in your headset and make sure the teleportation movement
works correctly.

### 2. Object oriented

Create interaction that allows an object to be picked up and/or
interacted with by the controller(s). How you implement the interaction
may be determined by the VR headset / controller you are targeting, but
always keep the user in mind and make their experience as smooth and
intuitive as possible.

-   Objects should not be able to move outside the boundaries of the
    room or into other objects, i.e. they cannot pass through colliders
-   Give the user visual feedback to indicate that an object can be
    interacted with (e.g. highlight, label, or otherwise change the
    object’s appearance)
-   Objects should react accordingly to actions such as being dropped or
    thrown, i.e. they should be affected by physics
-   *Tip* : If you are targeting a VR headset that is limited to 3DOF,
    the user must be able to pick up an object by clicking on it with a
    pointer from their controller. Otherwise, if your VR headset is
    6DOF, you have more freedom in interaction methods such as collision
    detection between interactable objects and your controller.

### 3. Let the right one in

Script interaction in the scene so that the door opens with an animation
when the user interacts with it.

-   The door should animate when it opens (the animation is included in
    the files you downloaded) and the player can then pass through the
    doorway
-   The boundaries of the room (walls, floors, ceilings, windows) cannot
    be moved, edited, or changed in any way
-   You may add new GameObjects to the room (more props / 3D models, UI,
    animation, etc.) but you cannot remove any existing GameObjects
-   You may add and edit materials and textures


### 4. An "on" button would have sufficed

Script interaction in the scene so that the projector in the center of
the second room turns on when the user interacts with it.


-   The particle system for the projector is included in the projector
    prefab – you are not required to create the animation yourself
-   The boundaries of the room (walls, floors, ceilings, windows) cannot
    be moved, edited, or changed in any way
-   You may add new GameObjects to the room (more props / 3D models, UI,
    animation, etc.) but you cannot remove any existing GameObjects
-   You may add and edit materials and textures

### 5. We didn't really escape though

**Scenes in Build:**

1.  `          <Scene Name>         `

Create a build of the tour in a `         Builds        ` directory and
name it based on your targeted device (ex.
`         VR_Room_<TargetHeadsetName>        ` -&gt;
`         VR_Room_OculusGo        ` ).

**Build Folder Hierarchy:**

-   Builds
    -   \[Target Device\]
        -   \[Associated Build Files\]

Make sure to run your build on your device and ensure it runs smoothly.

Create a `         .zip        ` of your build and upload it to Google
Drive or Dropbox. Add the link to the file below.

### 6. Doors should not be this hard to open

Script interaction in the scene so that the user must interact with at
least two objects before the glass door opens, allowing them to move
into the next room.

-   The user must be able to deduce the correct interactions in order to
    progress. In other words, the interactions should be logical and not
    so random that the desired outcome can only achieved by guessing.
    -   *Bad example* : The user picks up two of the boxes and moves
        them from their original spot and the door opens.
    -   *Good example* : The user interacts with the door. Nothing
        happens. The user then interacts with the console by the door.
        The console requests a passcode. The user explores the first
        room and finds an object with a number on it. The user enters
        the number on the console and the door opens.
-   The door should animate when it opens (the animation is included in
    the files you downloaded) and the player can then pass through the
    doorway
-   The boundaries of the room (walls, floors, ceilings, windows) cannot
    be moved, edited, or changed in any way
-   You may add new GameObjects to the room (more props / 3D models, UI,
    animation, etc.) but you cannot remove any existing GameObjects
-   You may add and edit materials and textures
