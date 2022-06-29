; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "BooksApp"
#define MyAppVersion "1.1.1"
#define MyAppPublisher "Gekkel Nikita"
#define MyAppExeName "BooksApp.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{2A022C6B-BC4B-459D-9294-A8E2C2FA3E54}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
OutputDir=..\Install
OutputBaseFilename=BooksApp
SetupIconFile=..\src\BooksApp\BooksApp\Resources\book.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.runtimeconfig.dev.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\BooksApp.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\BooksApp\BooksApp\bin\Release\net5.0-windows\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

