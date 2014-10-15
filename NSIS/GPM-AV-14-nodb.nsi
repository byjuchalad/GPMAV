
CRCCheck on

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"
InstallDirRegKey HKLM "Software\GPMAV" "Install_Dir"



;--------------------------------
;General

  ;Name and file
  Name "GPM Antivirus"
  OutFile "GPM_Antivirus_setup_v14_6_beta_db.exe"

  ;Default installation folder
  InstallDir "$%homedrive%\GPMAV"

BrandingText "GPM Antivirus 14.6b"

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin
  
Icon "H:\I\SYS\SRC\NEW\PRJ\GPMClamAV\v14\5\GPM_NEW_ALL.ico"
UninstallIcon "H:\I\SYS\SRC\NEW\PRJ\GPMClamAV\v14\5\GPM_NEW_ALL.ico"

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "GPL.txt"
  !insertmacro MUI_PAGE_COMPONENTS
 ; !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages

  !insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

  

Section "GPM Antivirus Files (required)"

  SectionIn RO
  
  SetOutPath $INSTDIR
  
  File /r "H:\GPMAV\*"
  
  WriteRegStr HKLM SOFTWARE\GPMAV "Install_Dir" "$INSTDIR"


  
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GPMAV" "DisplayName" "GPM Antivirus v14.6b"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GPMAV" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GPMAV" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GPMAV" "NoRepair" 1
  WriteRegStr HKLM "Software\GPMAV" "Scanner" "--tempdir=$INSTDIR\temp --log=$INSTDIR\Logs\GPMCNScan.log --recursive  --database=$INSTDIR\database --bell --move=$INSTDIR\quarantine"
  WriteRegStr HKEY_CLASSES_ROOT "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}" "" ""
  WriteRegStr HKEY_CLASSES_ROOT "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}\InProcServer32" "" ""
  WriteRegStr HKEY_CLASSES_ROOT "*\shellex\ContextMenuHandlers\GPMAV" "" ""
   
  WriteRegStr HKEY_CLASSES_ROOT "Folder\shellex\ContextMenuHandlers\GPMAV" "" ""
  WriteRegStr HKEY_CLASSES_ROOT "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}" "GPMAV Shell Extension" ""
  WriteRegStr HKEY_CLASSES_ROOT "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}\InProcServer32"  "ThreadingModel" "Apartment"
  WriteRegStr HKEY_CLASSES_ROOT "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}\InProcServer32" "" "$INSTDIR\ExpShell.dll"
  WriteRegStr HKEY_CLASSES_ROOT "*\shellex\ContextMenuHandlers\GPMAV" "" "{e76d8ce0-8944-4fed-b363-c2df08724673}"
  WriteRegStr HKEY_CLASSES_ROOT "Folder\shellex\ContextMenuHandlers\GPMAV" "" "{e76d8ce0-8944-4fed-b363-c2df08724673}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Run" "GPMAVTray" "$INSTDIR\GPMAV-Tray.exe"
   
  WriteUninstaller "uninstall.exe"
  
  Exec "$INSTDIR\CACertInstall.exe"
  Exec "$INSTDIR\GPMAV-Tray.exe"
  
SectionEnd

Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\GPM Antivirus"
  CreateShortCut "$SMPROGRAMS\GPM Antivirus\GPM Antivirus (GUI).lnk" "$INSTDIR\GPMAVGUI.exe" "" "$INSTDIR\GPMAVGUI.exe" 0
  CreateShortCut "$SMPROGRAMS\GPM Antivirus\GPM Antivirus (Scan GUI).lnk" "$INSTDIR\GPMAV-SCANGUI.exe" "" "$INSTDIR\GPMAV-SCANGUI.exe" 0
  CreateShortCut "$SMPROGRAMS\GPM Antivirus\GPM Antivirus (Tray).lnk" "$INSTDIR\GPMAV-Tray.exe" "" "$INSTDIR\GPMAV-Tray.exe" 0
  CreateShortCut "$SMPROGRAMS\GPM Antivirus\GPM Antivirus (Update).lnk" "$INSTDIR\GPMAV-UPDATE-GUI.exe" "" "$INSTDIR\GPMAV-UPDATE-GUI.exe" 0

  CreateShortCut "$SMPROGRAMS\GPM Antivirus\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  
SectionEnd

Section "Uninstall"
  
  ExecWait "$INSTDIR\GPMAVSvcDel.exe"
  
  
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GPMAV"
  DeleteRegKey HKLM SOFTWARE\GPMAV
  DeleteRegKey HKEY_CLASSES_ROOT "*\shell\Scan with GPM Antivirus"
  DeleteRegKey HKEY_CLASSES_ROOT "Folder\shell\Scan with GPM Antivirus"
  DeleteRegKey HKEY_CLASSES_ROOT  "CLSID\{e76d8ce0-8944-4fed-b363-c2df08724673}"
  DeleteRegKey HKEY_CLASSES_ROOT  "*\shellex\ContextMenuHandlers\GPMAV"
  DeleteRegKey HKEY_CLASSES_ROOT  "Folder\shellex\ContextMenuHandlers\GPMAV"
  
  DeleteRegValue HKEY_LOCAL_MACHINE "Software\Microsoft\Windows\CurrentVersion\Run" "GPMAVGUI"

  CreateDirectory $%homedrive%\gpmavbackup
  CopyFiles $INSTDIR\quarantine\*.* $%homedrive%\gpmavbackup


  Delete /REBOOTOK $INSTDIR\*.*
  Delete  /REBOOTOK $INSTDIR\uninstall.exe
  RMDir /r  "$SMPROGRAMS\GPM Antivirus"
  RMDir /r /rebootok "$INSTDIR"
  Delete /rebootok "$INSTDIR"

SectionEnd



VIProductVersion "14.0.0.6"
VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "GPM Antivirus"
VIAddVersionKey /LANG=${LANG_ENGLISH} "Comments" "GPM Antivirus"
VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "GPM"
VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalTrademarks" "GPM Antivirus is a trademark of GPM."
VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "© 2010-2014 GPM"
VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "GPM Antivirus"
VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "14.0.0.6"