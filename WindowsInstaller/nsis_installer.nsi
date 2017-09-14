; Installer for EdgeDeflector


;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"

;--------------------------------
;General

  ;Define name of the product
  !define PRODUCT "EdgeDeflector"
  !define ABOUTURL "https://github.com/AnonymerNiklasistanonym/EdgeDeflector"
  ;!define INSTALLATIONURL "https://github.com/da2x/EdgeDeflector/wiki/Thank-you-for-installing-EdgeDeflector"
  !define SEARCH_MACHINE_PLUGIN "Change Cortanas Search Machine"
  !define UNINSTALLER_STRING "_uninstaller"

  ;Properly display all languages
  Unicode true

  ;Show 'console' in installer and uninstaller
  ShowInstDetails "show"
  ShowUninstDetails "show"

  ;Name and file
  Name "${PRODUCT}"
  OutFile "${PRODUCT} Installer.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\${PRODUCT}"

  ;Directory for custom search machine url
  !define INSTDIR_DATA "$APPDATA\${PRODUCT}"

  ;Get installation folder from registry if available
  InstallDirRegKey HKLM "Software\${PRODUCT}" ""

  ;Request application admin
  RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  ;Show warning if user wants to abort
  !define MUI_ABORTWARNING

  ;Show all languages, despite user's codepage
  !define MUI_LANGDLL_ALLLANGUAGES

  ;Use the custom own icon
  !define MUI_ICON "Icons\Icon.ico"
  !define MUI_UNICON "Icons\UnIcon.ico"
  !define MUI_HEADERIMAGE_RIGHT
  !define MUI_WELCOMEFINISHPAGE_BITMAP "Pictures\installer_picture.bmp"
  !define MUI_UNWELCOMEFINISHPAGE_BITMAP "Pictures\uninstaller_picture.bmp"

  ;No descripton for all components
  !define MUI_COMPONENTSPAGE_NODESC

;--------------------------------
;Pages

  ;For the installer
  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "..\LICENSE"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH

  ;For the uninstaller
  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages

  ;At start will be searched if the current system language is in this list,
  ;if not the first language in this list will be chosen as language
  !insertmacro MUI_LANGUAGE "English"
  !insertmacro MUI_LANGUAGE "French"
  !insertmacro MUI_LANGUAGE "German"
  !insertmacro MUI_LANGUAGE "Spanish"
  !insertmacro MUI_LANGUAGE "SpanishInternational"
  !insertmacro MUI_LANGUAGE "SimpChinese"
  !insertmacro MUI_LANGUAGE "TradChinese"
  !insertmacro MUI_LANGUAGE "Japanese"
  !insertmacro MUI_LANGUAGE "Korean"
  !insertmacro MUI_LANGUAGE "Italian"
  !insertmacro MUI_LANGUAGE "Dutch"
  !insertmacro MUI_LANGUAGE "Danish"
  !insertmacro MUI_LANGUAGE "Swedish"
  !insertmacro MUI_LANGUAGE "Norwegian"
  !insertmacro MUI_LANGUAGE "NorwegianNynorsk"
  !insertmacro MUI_LANGUAGE "Finnish"
  !insertmacro MUI_LANGUAGE "Greek"
  !insertmacro MUI_LANGUAGE "Russian"
  !insertmacro MUI_LANGUAGE "Portuguese"
  !insertmacro MUI_LANGUAGE "PortugueseBR"
  !insertmacro MUI_LANGUAGE "Polish"
  !insertmacro MUI_LANGUAGE "Ukrainian"
  !insertmacro MUI_LANGUAGE "Czech"
  !insertmacro MUI_LANGUAGE "Slovak"
  !insertmacro MUI_LANGUAGE "Croatian"
  !insertmacro MUI_LANGUAGE "Bulgarian"
  !insertmacro MUI_LANGUAGE "Hungarian"
  !insertmacro MUI_LANGUAGE "Thai"
  !insertmacro MUI_LANGUAGE "Romanian"
  !insertmacro MUI_LANGUAGE "Latvian"
  !insertmacro MUI_LANGUAGE "Macedonian"
  !insertmacro MUI_LANGUAGE "Estonian"
  !insertmacro MUI_LANGUAGE "Turkish"
  !insertmacro MUI_LANGUAGE "Lithuanian"
  !insertmacro MUI_LANGUAGE "Slovenian"
  !insertmacro MUI_LANGUAGE "Serbian"
  !insertmacro MUI_LANGUAGE "SerbianLatin"
  !insertmacro MUI_LANGUAGE "Arabic"
  !insertmacro MUI_LANGUAGE "Farsi"
  !insertmacro MUI_LANGUAGE "Hebrew"
  !insertmacro MUI_LANGUAGE "Indonesian"
  !insertmacro MUI_LANGUAGE "Mongolian"
  !insertmacro MUI_LANGUAGE "Luxembourgish"
  !insertmacro MUI_LANGUAGE "Albanian"
  !insertmacro MUI_LANGUAGE "Breton"
  !insertmacro MUI_LANGUAGE "Belarusian"
  !insertmacro MUI_LANGUAGE "Icelandic"
  !insertmacro MUI_LANGUAGE "Malay"
  !insertmacro MUI_LANGUAGE "Bosnian"
  !insertmacro MUI_LANGUAGE "Kurdish"
  !insertmacro MUI_LANGUAGE "Irish"
  !insertmacro MUI_LANGUAGE "Uzbek"
  !insertmacro MUI_LANGUAGE "Galician"
  !insertmacro MUI_LANGUAGE "Afrikaans"
  !insertmacro MUI_LANGUAGE "Catalan"
  !insertmacro MUI_LANGUAGE "Esperanto"
  !insertmacro MUI_LANGUAGE "Asturian"
  !insertmacro MUI_LANGUAGE "Basque"
  !insertmacro MUI_LANGUAGE "Pashto"
  !insertmacro MUI_LANGUAGE "Georgian"
  !insertmacro MUI_LANGUAGE "Vietnamese"
  !insertmacro MUI_LANGUAGE "Welsh"
  !insertmacro MUI_LANGUAGE "Armenian"
  !insertmacro MUI_LANGUAGE "Corsican"

;--------------------------------
;Macro for URL shortcut

!macro CreateInternetShortcut FILENAME URL ICONFILE ICONINDEX
WriteINIStr "${FILENAME}.url" "InternetShortcut" "URL" "${URL}"
WriteINIStr "${FILENAME}.url" "InternetShortcut" "IconFile" "${ICONFILE}"
WriteINIStr "${FILENAME}.url" "InternetShortcut" "IconIndex" "${ICONINDEX}"
!macroend


;--------------------------------
;Installer Section

Section "EdgeDeflector (Required)"
  SectionIn RO # Just means if in component mode this is locked

  ;Set output path to the installation directory.
  SetOutPath $INSTDIR

  ;Put file here
  File "..\EdgeDeflector\bin\Release\${PRODUCT}.exe"
  File "Icons\Icon.ico"

  ;Execute EdgeDeflector.exe for self-registering
  ExecWait '$INSTDIR\${PRODUCT}.exe'

  ;Store installation folder in registry
  WriteRegStr HKLM "Software\${PRODUCT}" "" $INSTDIR

  ;Registry information for add/remove programs
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "DisplayName" "${PRODUCT}"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "UninstallString" '"$INSTDIR\${PRODUCT}${UNINSTALLER_STRING}.exe"'
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "URLInfoAbout" "$\"${ABOUTURL}$\""
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}" "NoRepair" 1

  ;Create start menu shortcut for uninstaller and search machine plugin
  CreateDirectory "$SMPROGRAMS\${PRODUCT}"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\Uninstall ${PRODUCT}.lnk" "$INSTDIR\${PRODUCT}${UNINSTALLER_STRING}.exe" "" "$INSTDIR\${PRODUCT}${UNINSTALLER_STRING}.exe" 0

  ;Create start menu shortcut for an 'About' link with icon
  !insertmacro CreateInternetShortcut "$SMPROGRAMS\${PRODUCT}\About ${PRODUCT}" "${ABOUTURL}" "$INSTDIR\Icon.ico" 0

  ;Create uninstaller
  WriteUninstaller "${PRODUCT}${UNINSTALLER_STRING}.exe"

SectionEnd

Section "Plugin: Change Cortanas Search Machine"
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  File "..\ChangeCortanasSearchMachine\bin\Release\Change Search Machine.exe"
  CreateShortCut "$SMPROGRAMS\${PRODUCT}\${SEARCH_MACHINE_PLUGIN}.lnk" "$INSTDIR\Change Search Machine.exe" "" "$INSTDIR\Change Search Machine.exe" 0
SectionEnd

Section "Change Search Machine to Google" sec1
  ; Set output path to the installation directory.
  SetOutPath ${INSTDIR_DATA}
  File "Google\ChangeUrl.txt"
SectionEnd

Section "Change Search Machine to DuckDuckGo" sec2
  ; Set output path to the installation directory.
  SetOutPath ${INSTDIR_DATA}
  File "DuckDuckGo\ChangeUrl.txt"
SectionEnd


;--------------------------------
;Installer For Choosing Search Machine
;Soure: http://nsis.sourceforge.net/Mutually_Exclusive_Sections

Function .onInit
  Push $0
 
  StrCpy $R9 ${sec1} ; Gotta remember which section we are at now...
  SectionGetFlags ${sec1} $0
  IntOp $0 $0 | ${SF_SELECTED}
  SectionSetFlags ${sec1} $0
 
  SectionGetFlags ${sec2} $0
  IntOp $0 $0 & ${SECTION_OFF}
  SectionSetFlags ${sec2} $0
 
  Pop $0
FunctionEnd
 
Function .onSelChange
  Push $0
 
  StrCmp $R9 ${sec1} check_sec1
 
    SectionGetFlags ${sec1} $0
    IntOp $0 $0 & ${SF_SELECTED}
    IntCmp $0 ${SF_SELECTED} 0 done done
      StrCpy $R9 ${sec1}
      SectionGetFlags ${sec2} $0
      IntOp $0 $0 & ${SECTION_OFF}
      SectionSetFlags ${sec2} $0
 
    Goto done
 
  check_sec1:
 
    SectionGetFlags ${sec2} $0
    IntOp $0 $0 & ${SF_SELECTED}
    IntCmp $0 ${SF_SELECTED} 0 done done
      StrCpy $R9 ${sec2}
      SectionGetFlags ${sec1} $0
      IntOp $0 $0 & ${SECTION_OFF}
      SectionSetFlags ${sec1} $0
 
  done:
 
  Pop $0
FunctionEnd


;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT}"
  DeleteRegKey HKLM "Software\${PRODUCT}"

  ;Delete the installation directory + files
  RMDir /r "$INSTDIR\*.*"
  RMDir "$INSTDIR"

  ;Delete the appdata directory + files
  RMDir /r "${INSTDIR_DATA}\*.*"
  RMDir "${INSTDIR_DATA}"

  ;Delete Start Menu Shortcuts
  Delete "$SMPROGRAMS\${PRODUCT}\*.*"
  RMDir "$SMPROGRAMS\${PRODUCT}"

SectionEnd


;--------------------------------
;After Installation Function

;Function .onInstSuccess

  ;Open GitHub 'Thank you for installing EdgeDeflector' site
  ;ExecShell "open" "microsoft-edge:${INSTALLATIONURL}"

;FunctionEnd