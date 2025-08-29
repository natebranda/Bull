# Bull

## Overview

<!-- TODO: Write a few bullet points about what inspired you to create this project, and how you went about it. -->
* I knew I wanted to create a small but distinct Unity project that limited the need to produce visual art so I could instead focus on C# programming and audio design. Thus, I came up with the concept of a newly blinded man trying to take care of himself.
* I decided to make a game focused more on navigation and exploration rather than combat because I wanted to differentiate it from other projects and avoid having to balance a combat or enemy evasion system. Especially given that this is my first game project.
* I wanted the game to be simple but to feel open ended and rewarding to explore. This is why I added descriptions and audio clips each object, wall, and floor throughout the house and made Audio clips for each chore object.
* Growing up in Maine, the oppressive silence of the woods is a feeling I wanted to capture, and so I wanted to create a fairly large space for the player to get lost in. I wanted to give a player the sense that there could be another person with you in that silent darkness who is as of yet hidden from your perception. Unfortunately I was unable to progress far enough to bring Jane, the intruder, into the fold. 
* I wanted to make the world feel more real than it could with visuals, which is what encouraged me to focus on descriptive writing and sound design along with the step based movement system. Ideally, the player starts to picture their surroundings as they struggle to gradually identify them.

## Demo

### Gameplay

<!-- TODO: Change shorter video to .gif? -->
#### Gameplay (30 seconds)

![30s Gameplay Demo](Bull%20Screenshots/Basic%20Demo.mp4)

#### Gameplay (90 seconds)

![90s Gameplay Demo](Bull%20Screenshots/Longer%20Demo.mp4)

### Screenshots

<!-- TODO: Add relevant screenshots. Show off the world/UX you build -->

#### View of House in Editor

![The House](Bull%20Screenshots/AltViewHouseEditor.png)

#### Basement in Editor

![Basement](Bull%20Screenshots/BasementEditor.png)

#### Ground Floor in Editor

![Ground Floor](Bull%20Screenshots/GroundFloorEditor.png)

#### 2nd Floor in Editor

![2nd Floor](Bull%20Screenshots/Floor2Editor.png)

#### In Game UI Example 1

![UIExample1](Bull%20Screenshots/UIText1.png)

#### In Game UI Example 2

![UIExample2](Bull%20Screenshots/UIText2.png)

#### In Game UI Example 3

![UIExample3](Bull%20Screenshots/UIText3.png)

#### In Game Title Screen UI

![Title Screen](Bull%20Screenshots/TitleScreenUI.png)


## Installation & Setup

### Requirements

* Unity 6 (Editor Version 6000.0.42f1)
* Windows 10 version 21H1 (build 19043) or newer or Windows 11 21H2 (build 22000) or newer (Arm64)
* X64 architecture with SSE2 instruction set support, Arm64
* DX10, DX11, DX12 or Vulkan capable GPUs

(See also at https://docs.unity3d.com/6000.2/Documentation/Manual/system-requirements.html)

NOTE: I am as of yet unsure how to export the game as a playable application outside of the Unity Editor. Thus the above requirements refer to what is needed to run the Unity Editor.

### Steps

1. Using Git/Github Desktop: Clone this repository to your machine.
1. In Unity Hub, click the “Add” button and then “Add project from disk”
1. Find and select your cloned project file and press “Open” to add it to your Unity Hub
1. Click on the “Bull” project in Unity Hub to open it in the Unity Editor. 
1. In the Unity Editor, find the “Scenes” folder in the larger “Assets” folder and click to open it. Said files should appear in the “Projects” tab at the bottom of the screen.
1. Within that folder, select the “Main Menu” scene and double click it to open it in the editor.
1. Press the play button at the top of the screen to start the game
1. Finally, maximize the game screen by double clicking the “Game” tab just below the play button to maximize the view of the game. 


### Controls

+ W is used to step forward.
+ A and D are used to rotate 90 degress left and right respectively.
+ SPACE is used to interact with the object or wall directly in front of you. This produces a text box with a description of said objecgt or wall. 
+ E is used to initiate a chore after you have interacted with a chore object using SPACE.
+ ESCAPE is used to open up the pause menu which allows you to go back to the main menu or to resume the game. Pressing ESCAPE while in the pause menu also resumes the game.

## Features & Systems

### Technologies Utilized

<!-- TODO: List tools, libraries, Unity features, or frameworks you used. -->
* Visual Studio
* Unity Animator
* UnityEngine
* TMPro
* System.Collections.Generic
* Unity3D
* Unity Inspector (Unity Inspector 3D sound options)

### Systems Implemented

<!-- TODO: List the systems you implemented (e.g., movement, UI system, environment interactions). -->
* Player movement system (stepping, turning)
* Player interaction system (looking/targeting objects, interacting with objects)
* Step system (creating floor objects that make their corresponding step sound when walked on)
* To Do List system (Accounting for both the chores that have been completed and the in game time passed from completing said chores and sequentially activating more chores as needed)
* Dynamic UI System (Screen Text, changing shade of Black Screen when looking at object vs. not)
* Pause Menu
* Main Menu

## Code Highlights

<!-- TOOD: Point reviewers directly to the parts of your code you’re most proud of. -->

- ['InteractionController.cs'](Assets/Scripts/InteractionController.cs)
  - Purpose: This file allows the player to target objects in the world using a ray cast, which prompt's that surface's Touch sound, and interact with them to bring up that surface's Feel text.
  - Challenge: The key issue with the Interaction Controller was removing the text UI when you looked away from an interactable. Before I fixed the issue, this meant that once you interacted with one object, the UI would never go away. Moreover, this made the UI instantly change its text when you looked at a new interactable rather than more pleasantly fading in the text after being prompted by the player. I solved the problem by saving the last interactable you looked at before updating the currently targeted interactable each frame and then organizing an effective series of if statements to reset the UI when looking away from an object and handle the Player interaction system's other UI related functions. 

<!-- Repeat for other important files. Example: -->

- [`Chore.cs`](Assets/Scripts/Chore.cs)
  - Purpose: Handles player movement and input.
  - Challenge: .


- [`PlayerMovement.cs`](Assets/Scripts/PlayerMovement.cs)
  - Purpose: Handles player movement and input.
  - Challenge: Worked out smooth acceleration/deceleration physics that feel natural.


 - [`PlayerMovement.cs`](Assets/Scripts/PlayerMovement.cs)
  - Purpose: Handles player movement and input.
  - Challenge: Worked out smooth acceleration/deceleration physics that feel natural.


## Roadmap / Future Action Items

<!-- TODO: Add a short list of improvements you’d make if you had more time. -->
* Create the originally intended seven full days of gameplay wherein the game could genuinely develop into the horror game it is supposed to be. The narrative is written, but unfortunately I did not have the time to build it out.
* Make a tutorial sequence for the first day where Angus's sister, Sarah, walks you through the basic layout of the house and your objectives for each day.
* Make a visible todo list in the pause menu that erases chores when they have been completed.
* Create system for dialogue lines and subtitles for dialogue between Angus and Sarah in the tutorial and for their daily telephone conversations.
* Implement a movement system for use with Sarah as an NPC in the tutorial and for Jane, the homeless woman who has been living in Angus's home without him knowing. This system would allow for these characters to trigger footstep sounds while moving accross surfaces.

## License

<!-- TODO: Pick a license (MIT is usually fine for portfolio projects). -->
MIT License

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
