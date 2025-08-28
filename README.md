# Bull

## Overview

<!-- TODO: Write a few bullet points about what inspired you to create this project, and how you went about it. -->
* I knew I wanted to create a small but distinct Unity project that limited the need to produce visual art so I could instead focus on C# programming and audio design. Thus, I came up with the concept of a newly blinded man trying to take care of himself.
* I decided to make a game focused more on navigation and exploration rather than combat because I wanted to differentiate it from other projects and avoid having to balance a combat or enemy evasion system. Especially given that this is my first game project.
* I wanted the game to be simple but to feel open ended and rewarding to explore. This is why I went to the trouble of making audio tracks for each of the chore objects and built out the areas like the basement and office.
* Growing up in Maine, the oppressive silence of the woods is a feeling I wanted to capture, and so I wanted to create a fairly large space for the player to get lost in. I wanted to give a player the sense that there could be another person with you in that silent darkness who is as of yet hidden from your perception. Unfortunately I was unable to progress far enough to bring Jane, the intruder, into the fold. 
* I wanted to make the world feel more real than it could with visuals, which is what encouraged me to focus on descriptive writing and sound design along with the step based movement system. Ideally, the player starts to picture their surroundings as they struggle to gradually identify them.

## Demo

### Gameplay

<!-- TODO: Record a short gameplay video, and embed here. -->

![Gameplay Demo](demo.gif)

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

<!-- TODO: List required software (Unity version, OS requirements, other tools). -->

### Steps

<!-- TODO: Give step-by-step setup instructions (clone repo, open Unity, press Play, etc.). -->

### Controls

<!-- TODO: How do to move around the environment? -->
+ W is used to step forward.
+ A and D are used to rotate 90 degress left and right respectively.
+ SPACE is used to interact with the object or wall directly in front of you. This produces a text box with a description of said objecgt or wall. 
+ E is used to initiate a chore after you have interacted with a chore object using SPACE.
+ ESCAPE is used to open up the pause menu which allows you to go back to the main menu or to resume the game. Pressing ESCAPE while in the pause menu also resumes the game.

## Features & Systems

### Technologies Utilized

<!-- TODO: List tools, libraries, Unity features, or frameworks you used. -->

### Systems Implemented

<!-- TODO: List the systems you implemented (e.g., movement, UI system, environment interactions). -->

## Code Highlights

<!-- TOOD: Point reviewers directly to the parts of your code you’re most proud of. -->

- **[File Name](with link)**
  - Purpose: <!-- TODO: Describe what this file does. -->
  - Challenge: <!-- TODO: Explain a tricky problem you solved here. -->

<!-- Repeat for other important files. Example: -->

- [`PlayerController.cs`](Assets/Scripts/PlayerController.cs)
  - Purpose: Handles player movement and input.
  - Challenge: Worked out smooth acceleration/deceleration physics that feel natural.

## Roadmap / Future Action Items

<!-- TODO: Add a short list of improvements you’d make if you had more time. -->
* Create the originally intended seven full days of gameplay wherein the project could genuinely develop into the horror game it is supposed to be. The narrative is written, but unfortunately I did not have the time to build it out.
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
