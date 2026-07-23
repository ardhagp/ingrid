> [!IMPORTANT]
> This page is intended for developers who want to collaborate to improving Ingrid.
> If you are **_non developer_** and want to use Ingrid in your computer please see this [WIKI How to Install Page](https://github.com/ardhagp/Ingrid/wiki/02.-How-to-Install).

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**About Project & Status**</span>
Ingrid is a Desktop Application for Windows OS that has many modules for every purposes, made by your request.

## Project Branch
```mermaid
flowchart LR
id2(♾️ dev) --> id1(📦 master)
id3(🛠️ fix) --> id2(♾️ dev)
id4(🔄 feature) --> id2(♾️ dev)
id5(📗 doc) --> id2(♾️ dev)
id1(📦 master) --> id6(☁️ publish)
```

| Branch | Description | Merge To |
| :--- | :--- | :--- |
| master | For publishing / deployment only | - |
| dev | Active development | master |
| fix | Branch to fixing issues | dev |
| feature | Branch to add new features | dev |
| doc | Branch for updating README / CONTRIBUTING / other documentations | dev |
| publish | Branch for Github.io Project Static Web Page | - |


## Current Status
|Repository Status|
|:---|
|![GitHub License](https://img.shields.io/github/license/ardhagp/ingrid?label=License&color=blue) ![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/ardhagp/ingrid?label=Issues&color=ff0000) ![GitHub Issues or Pull Requests](https://img.shields.io/github/issues-closed/ardhagp/ingrid?label=Issues&color=green) ![GitHub repo size](https://img.shields.io/github/repo-size/ardhagp/ingrid?label=Repo%20Size) ![GitHub last commit](https://img.shields.io/github/last-commit/ardhagp/ingrid?label=Last%20Commit) ![GitHub Created At](https://img.shields.io/github/created-at/ardhagp/ingrid?label=Created%20At) |

|Sonar Status |
|:---|
|![Sonar Violations](https://img.shields.io/sonar/blocker_violations/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Blocker&labelColor=blue) ![Sonar Violations](https://img.shields.io/sonar/critical_violations/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Critical&labelColor=blue) ![Sonar Violations](https://img.shields.io/sonar/major_violations/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Major&labelColor=blue) ![Sonar Violations](https://img.shields.io/sonar/major_violations/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Minor&labelColor=blue) ![Sonar Violations](https://img.shields.io/sonar/info_violations/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Info&labelColor=blue) |
|![Sonar Tech Debt](https://img.shields.io/sonar/tech_debt/ardhagp_ingrid?server=https%3A%2F%2Fsonarcloud.io&logo=sonar&label=Tech%20Debt) ![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ardhagp_ingrid&label=Tech%20Debt&metric=duplicated_lines_density) |

|Pipeline Status|
|:---|
|[![dev Build](https://github.com/ardhagp/ingrid/actions/workflows/dev-build.yml/badge.svg?branch=dev)](https://github.com/ardhagp/ingrid/actions/workflows/dev-build.yml) [![Release](https://github.com/ardhagp/ingrid/actions/workflows/release.yml/badge.svg?branch=master)](https://github.com/ardhagp/ingrid/actions/workflows/release.yml)|

|Uptime Status / Chat / Installer|
|:---|
|![Uptime Robot status](https://img.shields.io/uptimerobot/status/m795460257-c182ecdc7b4ee9aea83252bf?label=Web) [![Discord](https://img.shields.io/discord/1402488110800961648?logo=discord&label=Discord%20Chat)](https://discord.gg/S45J3c7Wnr) [![Static Badge](https://img.shields.io/badge/Online%20%2F%20Offline-brightgreen?label=Download%20Installer)](https://ardhagp.github.io/ingrid/)|

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**Tools You Need**</span>
<span style="color:orange">1.</span>	Visual Studio 2022 Community Edition ([Download](https://visualstudio.microsoft.com/downloads/))<br/>
<span style="color:orange">2.</span>	.NET 8 ([Download](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.423-windows-x64-installer))<br/>
<span style="color:orange">3.</span> Open <span style="color:orange">**User Secret**</span> from <span style="color:orange">**Bridge Project**</span>, see below image.

![Manage User Secret](https://res.cloudinary.com/cagakmelon/image/upload/v1696932706/apps/ingrid-assets/readme.md/manage_user_secret.png)


Then type this json structure.
``` json
{
  "KEYS": {
	"SALT": "<input random characters including Upper and Lower Case, Symbols and Space>",
    "SYNCFUSION": "<input your Syncfusion Key>",
    "BETTERSTACK_LOG": "<input your BetterStack Log Key>",
    "BETTERSTACK_HEARTBEATS": "<input your BetterStack Heartbeats Key>",
    "CLOUDSTORAGE": "<input your Cloudstorage Url>",
    "REPOPAGE": "<input your Repository Page>"
  }
}
```
or simply by editing _secrets.json_ in this directory:
```
%APPDATA%\Microsoft\UserSecrets\f4e0ab0f-a60a-41b1-b56d-d9adae7b959d\
```
----
What if Manage User Secrets context menu doesn't show up?

![Missing User Secrets context menu](https://res.cloudinary.com/cagakmelon/image/upload/v1711475296/apps/ingrid-assets/readme.md/2024-03-27_002550.png)

No worries, you are still able to manage by using Dev PowerShell with this command:

| <span style="color:darkorange">_Dev PowerShell Commands_</span> | <span style="color:darkorange">_Function_</span> |
| -- | -- |
| dotnet user-secrets clear | Delete all KeyName |
| dotnet user-secrets list | Displaying KeyName and its values |
| dotnet user-secrets set KeyName "KeyValue" | Set KeyName and KeyValue |
| dotnet user-secrets remove KeyName | Remove specified KeyName |

then type this command using PowerShell:
```cmd
dotnet user-secrets set KEYS:SALT "<input random characters including Upper and Lower Case, Symbols and Space>"
dotnet user-secrets set KEYS:SYNCFUSION "<input your Syncfusion Key>"
dotnet user-secrets set KEYS:BETTERSTACK_LOG "<input your BetterStack Log Key>"
dotnet user-secrets set KEYS:BETTERSTACK_HEARTBEATS "<input your BetterStack Heartbeats Key>"
dotnet user-secrets set KEYS:CLOUDSTORAGE "<input your Cloudstorage Url>"
dotnet user-secrets set KEYS:REPOPAGE "<input your Repository Page>"
```
> [!WARNING]
> You should use sha256 hash for your _KEYS:SALT_ to prevent error when decrypting stored password.

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

# About Keys
## 1. Syncfusion
To obtain Syncfusion Key, please sign up with <span style="color:orange">**Community License**</span> and visit this page : [Syncfusion](https://www.syncfusion.com/account/downloads)
Then follow this steps below :

![](https://res.cloudinary.com/cagakmelon/image/upload/v1696932718/apps/ingrid-assets/readme.md/get_license_key.png)

## 2. BetterStack Log
To obtain BetterStack Key, please sign up <span style="color:orange">**BetterStack**</span> and open [https://betterstack.com/settings](https://betterstack.com/settings) 

![](https://res.cloudinary.com/cagakmelon/image/upload/v1712380400/apps/ingrid-assets/readme.md/2024-04-06_120426.jpg)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

# About Publishing Plan
```mermaid
flowchart LR
id1(♾️ Azure Devops) --> id30([📦 ClickOnce]) --> id19(🔥 Backblaze) --> id20([🌐 Github.io])
id1(♾️ Azure Devops) --> id31([📦 .zip]) --> id19(🔥 Backblaze) 
```

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

#   <span style="color:darkorange">**About License**</span>
This application is released under the [MIT license]($/Ingrid/LICENSE). You can use the code for any purpose, including commercial projects.

![MIT License](https://res.cloudinary.com/cagakmelon/image/upload/v1697064703/apps/ingrid-assets/readme.md/license.png)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

#   <span style="color:darkorange">**Navigation**</span>
| [App Page](https://ardhagp.github.io/ingrid) | [Wiki](https://github.com/ardhagp/ingrid/wiki/) | [Status Page](https://stats.uptimerobot.com/w2qHYcTmKb) | Tip (Indonesia) |
| -- | -- | -- | -- |










