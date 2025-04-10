# get parameters
param ( 
    [string]$targetPath
)

# create the shortcut
$shortcutName = Read-Host 'Shortcut Name'


& $env:START_MENU_SHORTCUT_CREATOR\smsc.ps1 $targetPath $shortcutName
