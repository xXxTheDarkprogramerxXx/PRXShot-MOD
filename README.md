**PRXShot MOD**

![image](https://github.com/user-attachments/assets/e24d872c-74fd-4938-a9cd-01eb25beb918)


**prxshot mod and prxshot mod config by LMAN**

---

### Installation:
Copy the `prxshot` directory to the `seplugins` directory (or any preferred location) and add the plugin to the appropriate configuration files: (`game.txt`, `vsh.txt`, `pops.txt`).

---

### NOTE:
To modify any settings in the configuration file `prxshot_mod.ini`, you can use the provided configuration tool `prxshot_mod_config.exe`, located in the same folder.

---

## **Changelog**

### **prxshot mod**
- **[+]** Added a new option to enable/disable using GameID in the screenshot name:
  - `ScreenshotNameUseGameID = 1`
- **[+]** Added a new `ScreenshotKey` option (replacing the old one) in the `.ini` file, allowing users to select specific keys for capturing screenshots in different modes:
  - `ScreenshotKey_XMB  = 0x000008`  → START
  - `ScreenshotKey_GAME = 0x800200`  → Right trigger + NOTE
  - `ScreenshotKey_POPS = 0x800000`  → NOTE

### **prxshot mod fixed**
- **[!]** Fixed an issue when taking screenshots from UMD while `ScreenshotNameUseGameID` is enabled.

### **prxshot mod v0.2**
- **[+]** Added a new option `SaveToPICTURE` to enable/disable saving the captured image to `xx0:/PICTURE` without creating a `PSCM.DAT` info file. This allows easy folder deletion from the PSP without issues.

---

### **prxshot mod config v0.1**
- **[+]** Initial release!

### **prxshot mod config v0.2**
- **[+]** Added `SaveToPICTURE` option for saving screenshots to `xx0:/PICTURE` without creating `PSCM.DAT`.

---

## **How to Use**

1. Run `prxshot_mod_config.exe`.
2. Select the PSP control key for capturing screenshots (Combination keys are also available).
3. Choose the mode where the keys apply (`XMB`, `GAME`, `POPS`, or `ALL`).
4. Click **Save** to store the settings in the configuration file.

### **Misc GroupBox Features:**
- Automatically loads configuration from `prxshot_mod.ini`.
- Allows editing of screenshot naming conventions without requiring `%s/` before and `%04d.bmp` after the name.
- Click **Save** to store Misc GroupBox settings.

**NOTE:**
- `prxshot_mod_config.exe` can generate and copy PSP control keys for use in other plugins.

---

## **Acknowledgments**
Special thanks to **Codestation** for the original `prxshot` source code.

---

## **Final Note**
Use this software at your own risk.
