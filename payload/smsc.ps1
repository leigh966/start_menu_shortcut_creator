# get parameters
param ( 
    [string]$targetPath,
    [string]$shortcutName
)

# get the start menu folder
$shell = New-Object -ComObject WScript.Shell
$startMenuPath = $shell.SpecialFolders.Item('StartMenu')
$programsPath = Join-Path -Path $startMenuPath -ChildPath 'Programs'


# create the shortcut
$shortcut = "$programsPath\$shortcutName.lnk"
$WshShell = New-Object -ComObject WScript.Shell
$shortcutObject = $WshShell.CreateShortcut($shortcut)
$shortcutObject.TargetPath = $targetPath
$shortcutObject.Save()
