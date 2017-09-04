; Installer for EdgeDeflector

;--------------------------------

!define PRODUCT "EdgeDeflector"

Name "${PRODUCT} Installer"

OutFile "..\bin\Release\${PRODUCT}_install.exe"

; Default installation directory
InstallDir $PROGRAMFILES\${PRODUCT}

; Store install dir in the registry
InstallDirRegKey HKLM "Software\${PRODUCT}" "Install_Dir"

; Request application privileges for UAC
RequestExecutionLevel admin

ShowInstDetails "show"
ShowUninstDetails "show"


;--------------------------------

; Installer pages
Page license
Page components
Page directory
Page instfiles

; Uninstaller pages
UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------


;Data
 
  LicenseData "..\..\LICENSE.txt"


Section "EdgeDeflector (Required)"

  SectionIn RO

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "..\bin\Release\${PRODUCT}.exe"


  ; Self-registeres to the registry
  ExecWait '$INSTDIR\${PRODUCT}.exe'

  ; Write the installation path to the registry
  WriteRegStr HKLM SOFTWARE\${PRODUCT} "Install_Dir" "$INSTDIR"
  
  ;create start-menu items
  CreateDirectory "$SMPROGRAMS\${PRODUCT}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\Uninstall ${PRODUCT}.lnk" "$INSTDIR\${PRODUCT}_uninstall.exe" "" "$INSTDIR\${PRODUCT}_uninstall.exe" 0
  
  ; Write the uninstall keys to the registry
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "DisplayName" "${PRODUCT}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "UninstallString" '"$INSTDIR\${PRODUCT}_uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoRepair" 1
  WriteUninstaller "${PRODUCT}_uninstall.exe"

  ExecShell "open" "microsoft-edge:https://github.com/da2x/EdgeDeflector/wiki/Thank-you-for-installing-EdgeDeflector"
  
  !echo "click 'Close' to continue"

SectionEnd

Section "Change Search Machine to Google" SEC_ENG 
  SectionIn 1
      ; Set output path to the installation directory.
      SetOutPath $INSTDIR
      File "..\..\ChangeUrl.txt"
SectionEnd

;--------------------------------


Section "Uninstall"

  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}"
  DeleteRegKey HKLM SOFTWARE\${PRODUCT}
  
  ;Delete Files 
  RMDir /r "$INSTDIR\*.*"    
 
;Remove the installation directory
  RMDir "$INSTDIR"
 
;Delete Start Menu Shortcuts
  Delete "$SMPROGRAMS\${PRODUCT}\*.*"
  RmDir  "$SMPROGRAMS\${PRODUCT}"

SectionEnd

Function .onInit
  StrCpy $0 ${SEC_ENG}
FunctionEnd


;Function that calls a messagebox when installation finished correctly
Function .onInstSuccess
  MessageBox MB_OK "You have successfully installed ${PRODUCT}. Change your Windows 10 default browser if you want to change the browser which opens the Cortana search querys."
FunctionEnd
 
 
Function un.onUninstSuccess
  MessageBox MB_OK "You have successfully uninstalled ${PRODUCT}."
FunctionEnd
