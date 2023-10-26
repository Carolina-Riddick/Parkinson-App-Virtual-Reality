# VR-app-Parkinson

### Full Documentation ➡️ Notion page https://www.notion.so/carolina-riddick/Parkinson-App-GDD-caeeda0e133149d9865d8e214b744744

# 💻 Technology Stack

1. Unity Engine
    1. Pro Builder Tool
    2. Unity Asset Store
    3. Kenney audio
2. C# language
3. XR plugin Management
4. XR Interaction Toolkit 

---

# Unity Engine

### ➡️ Unity Version: 2021.3.1

---

### ➡️ Platform: Windows, Mac, Linux

---

### Device:

1. XR Interaction Toolkit
    1. XR Device simulator

### **Controls for XR Rig movement**

- Pressing down and holding the key `W` will move the rig forward along the local z-axis
- Pressing down and holding the key `S` will move the rig backward along the local z-axis
- Pressing down and holding the key `A` will move the rig to the left side along the local x-axis
- Pressing down and holding the key `D` will move the rig to the right side along the local x-axis
- Pressing down and holding the key `Q` will rotate the Rig towards the left about the local y-axis
- Pressing down and holding the key `E` will rotate the Rig towards the right about the local y-axis

For the grab, trigger, primary, and secondary buttons to work in the simulator either of the hands has to be selected first.

### **Interaction controls and other buttons**

- **Grab:** Pressing down and holding the key `G` performs the grab action.
- **Trigger:** `Left mouse click` simulates trigger button action.
- **Primary button:** Press the key `B`once to simulate the action linked to the primary button.
- **Secondary button:** Press the key `N` once to simulate the action linked to the secondary button.
- **Reset:** Pressing the key `V` once resets the position and rotation of the component.

---

### Configuration Steps

### 1. Scene and configuration

1. *File* → *Project Setting* → *XR Plugin Management* **→** Download the **XR Plugin Management**
    1. Select the *device you will use according to the platform you selected before*
        1. In this case, I selected Mock HMD Loader to get the XR device Simulator
              
    
2. Download the *XR Toolkit Manager* from *Windows* → ***Packager Manager***
    1. Documentation
    2. As we are using version **2021.3.1** we need to install the **XR Toolkit Manager *manually***
    3. Click in **`Add`**
    4. Click in **`Yes`**
    5. XR Toolkit installed

1. Install the XR Device Simulator    

1. Now we have many XR assets to use, but we need to add an important configuration.
    - This is important to have all the input configuration
- We should search for:
    1. **`XRI Default Left Controller`**
    2. **`XRI Default Rigth Controller`**
          
    3. Click in `**Add**`        

1. Go to *File* → *Project Settings* → **Preset Manager** and Add each configuration to each controller

1. To use the **XR Device Simulator** we need to enable the Use *XR Device Simulator in scenes*    

1. The mock HMD supports the following stereo rendering modes:
- **MultiPass** - Submit separate draw calls for each eye.
- **SinglePassInstanced** - Submit one draw call for both eyes.

You can set the render mode at build time in the **Project Settings** window (from Unity's main menu, go to. **Edit > Project Settings**, then select the **XR Plugin Management > MockHMD** category from the menu on the left. The setting will take effect in play mode.

1. Configuration Done ✅
2. Play the Scene

### 2. Step 2: Player ****XR Rig**** Movement

- 1. Add an **`empty Object`**
        
    - Add **`LocomotionSystem`** component
            
- 2. We will add the **Rotation** movement to the player by adding the component **`Continuous Turn Provider`**
        
    1. We will need to add a reference to our *rotation*. In this case, we will use ***the right hand to rotate***
                
- 3. We should do the same with the **movement**
    1. Adding a new component called **`Continuous Move Provider`** 
    2. Adding the **`Locomotion System`**
    3. Adding a *reference* to our **Left Hand**
 
  ----
  ## # GDD or Game Design Document

### ❔What is Parkinson's disease?

- Parkinson's disease is **a brain disorder that causes unintended or uncontrollable movements, such as shaking, stiffness, and difficulty with balance and coordination**. Symptoms usually begin gradually and worsen over time.
- As the disease progresses, people may have difficulty walking and talking.

### ℹ️ What are the five 5 signs of Parkinson's disease?

- *10 Early Signs*
- [ ]  Bradykinesia (Slowness of Movement)
- [ ]  Dizziness or Fainting.
- [ ]  Drooling.
- [ ]  Dyskinesia.
- [ ]  Dystonia.
- [ ]  Facial Masking.
- [ ]  Postural Instability (Trouble with Balance and falls)
- [ ]  Rigidity.

### 🎯 What is the main idea of the project?

"My primary objective is to develop a Virtual Reality environment aimed at enhancing and training motor skills in individuals with Parkinson's disease. This initiative seeks to empower them to engage in self-directed exercises that focus on improving upper limb mobility and coordination.”

### 💪🏼 **Regular exercise has been shown to:**

- [ ]  Reduce muscle stiffness
- [ ]  Improve mobility with better posture, balance, and gait
- [ ]  Decrease depression and anxiety
- [ ]  Enhance memory
- [ ]  Reduce fatigue
- [ ]  Improve constipation
- [ ]  Assist with slowed movement (bradykinesia)
- [ ]  Improve speech, and reduce swallowing and drooling
- [ ]  Improve writing and fine motor skills

---
## 🏞️ Environment

> **Characters**
> > - Main Player

> **Story Project**
> > - Enhance and Expand Physical movement for Individuals with Parkinson's Disease.

> **World & areas**
> > - Scene 1 and Scene 2

> **Graphics & visuals**
> > - Created with ProBuilder and Unity Asset Store

> **Audio & music**
> > - Sounds and clips
---
### Scene 1

- Presentation. A simple environment where the player appears.
- UI to show the project and buttons to choose
    
    **`Start Level 1`**
    This button will send us to Scene 2 where is the playground
    
    **`About…`**
    Which is this project about
    
    **`Quit`**
    Quit the application

  ### Scene 2
- When the player presses on the **`Start Level 1`** Button, the scene 2 appears

## Task description
### Level 1:

- In Scene 2, we encounter two distinct environments, with one being contingent upon the other.
- The player is required to secure victory in the initial game in order to progress to the subsequent level

### Environment and Description of Task 1

1. **UI Presentation Level**
    - In this section, we will detail the user interface, its visual elements, and how the player will interact with it.
  
2. **Environment and Description of Task 1**
    - In this segment, we will provide a description of the game environment relevant to the first task at hand. This will include the setting, geography, and key elements that will surround the player as they tackle this specific task.
3. **Grabbing an Object**
    - This section will outline the process and mechanics involved in the action of picking up and manipulating objects within the game. It will encompass player interaction, how objects are selected, and what actions can be taken once they have been grabbed.
    
    - - The player is tasked with correctly placing each object into the designated box.
- As the player inserts each element, the next level will be revealed, unveiling a new user interface and opening the door on the right side of the player.

- The transition to the next level is visually represented by an open door. As the player interacts with task 1, the door swings wide open, revealing the passage to the next level

### Level 2:
➡️ The player can use the  teleport option with the right joystick which allows to use teleportation inside both scenes 

### Environment and Description of Task 2

- In Level 2, the player is tasked with strategically positioning all the gems onto the moving platform to accumulate the required 50 points, enabling progression to the subsequent stage.
- This game is designed to enhance the player's coordination and precision in their movements, requiring them to carefully time the gem throws.
- The game can be customised and dosage across various difficulty levels:
    1. *Increasing the speed of the platform's movement.*
    2. *Reducing the point value of the gems, necessitates the player to throw more of them.*
    3. *Adding weight to the gems, demanding more precise movements from the player.*

1. **Environment**

2. **Description Task**

3. **Movement Platform and Gems**

4. The image illustrates a scene within the game where a player-controlled character, represented by a joystick icon, stands on a platform. The platform is suspended in mid-air, creating a sense of elevation and challenge. Scattered around the platform are colorful gemstones of various shapes and sizes. The image conveys a sense of adventure and the central gameplay mechanic, which involves controlling the character via the joystick to navigate the platform and collect the gems

5. **UI Image with 50 points**
6. Upon accumulating the requisite 50 points, the player should press the button located atop the table.
7. The button allows to the player continue to the next future steps increasing coordination and physical movements
