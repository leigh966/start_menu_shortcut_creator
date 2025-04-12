# Start Menu Shortcut Creator (SMSC)

## Install Instructions

- Download the [latest release](https://github.com/octo-org/octo-repo/releases/latest)
- Extract your the downloaded zip
- Run SSMC_Installer.exe
- Choose the location you'd like to install to and click the Install button
- Open powershell and run the following commands:
  - `Set-ExecutionPolicy unrestricted` to allow the running of unsigned .ps1 scripts on your machine 
> [!WARNING] 
> This will make you vulnerable to certain kinds of malware attacks! In future, these ps1 scripts will be signed to allow this step to be removed
  - `Unblock-File $env:START_MENU_SHORTCUT_CREATOR\smsc.ps1` to allow this script to run without a security warning 
> [!NOTE] 
> This is optional but, if you do not run this step, you will need manually allow the script to run each time the command is used
  - `Unblock-File $env:START_MENU_SHORTCUT_CREATOR\smscas.ps1` to allow this script to run without a security warning 
> [!NOTE] 
> This is optional but, if you do not run this step, you will need manually allow the script to run each time the command is used

# Use

- Left click then shift+right click the file you want to add to the start menu
- Click "Create Start Menu Shortcut As..."
- Type the name that you would like to use for the shortcut
- Press Enter
- The file will now appear in the start menu with the given name
