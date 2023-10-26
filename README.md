# ParkinsonApp

# 💻 Technology Stack

1. Unity Engine
    1. Pro builder Tool
    2. Unity Asset Store
    3. Kenney audio
2. C# language
3. XR plugin Management
4. XR Interaction Toolkit 

---

# Unity Engine

### ➡️ Unity Version: **2021.3.1**

---

### ➡️ Platform**: Windows, Mac, Linux**

---

### Device:

1. XR Interaction Toolkit
    1. XR Device simulator

![IMG_1433.jpeg](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/2eeca532-b187-4f3d-9c4a-0c166cdccd8f/IMG_1433.jpeg)

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
        
        ![Captura de pantalla 2023-10-15 a las 12.25.16 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/96ed16a4-5766-44a5-9ade-5ec7285e5f7a/Captura_de_pantalla_2023-10-15_a_las_12.25.16_p._m..png)
        
    
2. Download the *XR Toolkit Manager* from *Windows* → ***Packager Manager***
    1. Documentation
        
        [Installation | XR Interaction Toolkit | 2.4.3](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.4/manual/installation.html)
        
    2. As we are using version **2021.3.1** we need to install the **XR Toolkit Manager *manually***
        
        ![Captura de pantalla 2023-10-15 a las 12.35.16 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/03796836-f0bc-4d5f-94f5-0c87cc59250c/Captura_de_pantalla_2023-10-15_a_las_12.35.16_p._m..png)
        
    3. Click in **`Add`**
    4. Click in **`Yes`**
        
        ![Captura de pantalla 2023-10-15 a las 12.39.40 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/cb52c6fc-62f0-4857-bfaa-270b5a87245c/Captura_de_pantalla_2023-10-15_a_las_12.39.40_p._m..png)
        
    5. XR Toolkit installed
        
        ![Captura de pantalla 2023-10-15 a las 12.40.56 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/ee44fb05-d428-47a9-b32d-a23180d18408/Captura_de_pantalla_2023-10-15_a_las_12.40.56_p._m..png)
        

1. Install the XR Device Simulator
    
    ![Captura de pantalla 2023-10-15 a las 12.41.42 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/937000df-faf8-49d4-b306-fe94ba181d0a/Captura_de_pantalla_2023-10-15_a_las_12.41.42_p._m..png)
    

1. Now we have many XR assets to use, but we need to add an important configuration.
    - This is important to have all the input configuration
- We should search for:
    1. **`XRI Default Left Controller`**
    2. **`XRI Default Rigth Controller`**
        
        ![Captura de pantalla 2023-10-15 a las 12.48.42 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/9e35b7ab-4433-4c94-b861-8043ebaddb72/Captura_de_pantalla_2023-10-15_a_las_12.48.42_p._m..png)
        
    3. Click in `**Add**`
        
        ![Captura de pantalla 2023-10-15 a las 12.48.09 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/38736c6f-2c1c-499f-8e84-b15d743e5fcd/Captura_de_pantalla_2023-10-15_a_las_12.48.09_p._m..png)
        

1. Go to *File* → *Project Settings* → **Preset Manager** and Add each configuration to each controller
    
    ![Captura de pantalla 2023-10-15 a las 12.51.23 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/cdb30951-8ee0-4443-87c5-e9a3fc2d5b34/Captura_de_pantalla_2023-10-15_a_las_12.51.23_p._m..png)
    

1. To use the **XR Device Simulator** we need to enable the Use *XR Device Simulator in scenes*
    
    ![Captura de pantalla 2023-10-15 a las 1.03.56 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/b203862e-b44a-4800-9f6c-668708824a70/Captura_de_pantalla_2023-10-15_a_las_1.03.56_p._m..png)
    

1. The mock HMD supports the following stereo rendering modes:
- **MultiPass** - Submit separate draw calls for each eye.
- **SinglePassInstanced** - Submit one draw call for both eyes.

You can set the render mode at build time in the **Project Settings** window (from Unity's main menu, go to. **Edit > Project Settings**, then select the **XR Plugin Management > MockHMD** category from the menu on the left. The setting will take effect in play mode.

![Captura de pantalla 2023-10-15 a las 1.05.55 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/f02f0fa0-9e79-49ff-9b99-a9ff787c3b7b/Captura_de_pantalla_2023-10-15_a_las_1.05.55_p._m..png)

1. Configuration Done ✅
2. Play the Scene

### 2. Step 2: Player ****XR Rig**** Movement

- 1. Add an **`empty Object`**
    
    ![Captura de pantalla 2023-10-15 a las 2.01.04 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/d96524f4-9729-404e-952c-d8b243cc8b6e/Captura_de_pantalla_2023-10-15_a_las_2.01.04_p._m..png)
    
    - Add **`LocomotionSystem`** component
    
    ![Captura de pantalla 2023-10-15 a las 1.58.23 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/693c70d3-2e23-4b96-9c3c-0f24f540a6f8/Captura_de_pantalla_2023-10-15_a_las_1.58.23_p._m..png)
    
    ![Captura de pantalla 2023-10-15 a las 2.00.38 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/654bde96-aa41-4cec-8c9b-8f8401dc8601/Captura_de_pantalla_2023-10-15_a_las_2.00.38_p._m..png)
    
- 2. We will add the **Rotation** movement to the player by adding the component **`Continuous Turn Provider`**
    
    ![Captura de pantalla 2023-10-15 a las 2.03.33 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/c156ea97-2c34-4769-a804-0b5443190abf/Captura_de_pantalla_2023-10-15_a_las_2.03.33_p._m..png)
    
    1. We will need to add a reference to our *rotation*. In this case, we will use ***the right hand to rotate***
        
        ![Captura de pantalla 2023-10-15 a las 2.05.04 p. m..png](https://prod-files-secure.s3.us-west-2.amazonaws.com/2c268748-4c62-4e45-8306-7483989cfcd7/165ba11e-020a-41da-9495-9185113668ad/Captura_de_pantalla_2023-10-15_a_las_2.05.04_p._m..png)
        
- 3. We should do the same with the **movement**
    1. Adding a new component called **`Continuous Move Provider`** 
    2. Adding the **`Locomotion System`**
    3. Adding a *reference* to our **Left Hand**
