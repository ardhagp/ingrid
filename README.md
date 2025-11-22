> [!IMPORTANT]
> This page is intended for developers who want to collaborate to improving Ingrid.
> If you are **_non developer_** and want to use Ingrid in your computer please see this [WIKI How to Install Page](https://github.com/ardhagp/Ingrid/wiki/02.-How-to-Install).

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**About Project & Status**</span>
Ingrid is a Desktop Application for Windows OS that has many modules for every purposes, made by your request.

[![Static Badge](https://img.shields.io/badge/License-MIT-blue)](https://opensource.org/license/mit/) [![Codacy Badge](https://app.codacy.com/project/badge/Grade/d1728d753b8c4b579d97a467bf751322)](https://app.codacy.com/gh/ardhagp/ingrid/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade) [![dotnet CI Build](https://github.com/ardhagp/Ingrid/actions/workflows/dotnet-ci-build.yml/badge.svg)](https://github.com/ardhagp/Ingrid/actions/workflows/dotnet-ci-build.yml) [![Build Status](https://dev.azure.com/ardhagp/ingrid/_apis/build/status%2Fgithub-linked%2Fscheduled%2Fazure-pipelines?branchName=master)](https://dev.azure.com/ardhagp/ingrid/_build/latest?definitionId=12&branchName=master) [![Better Stack Badge](https://uptime.betterstack.com/status-badges/v3/monitor/182mi.svg)](https://ingrid.betteruptime.com/) [![Static Badge](https://img.shields.io/badge/Download-ingrid--offline.zip-gold)](https://ardhagp.github.io/ingrid/ingrid-offline.zip)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**Tools You Need**</span>
<span style="color:orange">1.</span>	Visual Studio Community Edition ([Download](https://visualstudio.microsoft.com/downloads/)) <br/>
<span style="color:orange">2.</span>	.NET 7 ([Download](https://dotnet.microsoft.com/en-us/download/dotnet/7.0))<br/>
<span style="color:orange">3.</span>  SQL Server 2022 Express / Developer Edition ([Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads))<br/>
| <span style="color:darkorange">_Instruction For Database_</span> |
| -- |
| 1. Download [Data](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?version=T&path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/File/db_universe_erp.mdf) and [File](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_apis/tfvc/items?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/File/db_universe_erp_file.mdf&versionDescriptor%5BversionOptions%5D=0&versionDescriptor%5BversionType%5D=5&versionDescriptor%5Bversion%5D=&%24format=octetStream&api-version=5.0&download=true) as your database attachments. <br/>2. Synchronize two database above by using this file inside Ingrid repository : [db_universe_erp.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/db_universe_erp.scmp) and [db_universe_erp_file.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/db_universe_erp_file.scmp) <br/>3. Create user <span style="color:orange">**mvu_admin**</span> with password <span style="color:orange">**admin**</span> <br/>4. Set <span style="color:orange">**db_universe_erp.mdf**</span> and <span style="color:orange">**db_universe_erp_file.mdf**</span> ownership to <span style="color:orange">**mvu_admin**</span> |

<span style="color:orange">4.</span> Open <span style="color:orange">**User Secret**</span> from <span style="color:orange">**Bridge Project**</span>, see below image.

![Manage User Secret](https://res.cloudinary.com/cagakmelon/image/upload/v1696932706/apps/ingrid-assets/readme.md/manage_user_secret.png)


Then type this json structure.
``` json
{
  "KEYS": {
	  "SALT": "<input random characters including Upper and Lower Case, Symbols and Space>",
    "SYNCFUSION": "<input your Syncfusion Key>",
    "BETTERSTACK_LOG": "<input your BetterStack Key>"
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
```
dotnet user-secrets set KEYS:SALT "<input random characters including Upper and Lower Case, Symbols and Space>"
dotnet user-secrets set KEYS:SYNCFUSION "<input your Syncfusion Key>"
dotnet user-secrets set KEYS:BETTERSTACK_LOG "<input your BetterStack Key>"
```
> [!WARNING]
> You should use sha256 hash for your _KEYS:SALT_ to prevent error when decrypting stored password.

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
## About Keys :
### 1. Syncfusion
To obtain Syncfusion Key, please sign up with <span style="color:orange">**Community License**</span> and visit this page : [Syncfusion](https://www.syncfusion.com/account/downloads)
Then follow this steps below :

![](https://res.cloudinary.com/cagakmelon/image/upload/v1696932718/apps/ingrid-assets/readme.md/get_license_key.png)

### 2. BetterStack
To obtain BetterStack Key, please sign up <span style="color:orange">**BetterStack**</span> and open [https://betterstack.com/settings](https://betterstack.com/settings) 

![](https://res.cloudinary.com/cagakmelon/image/upload/v1712380400/apps/ingrid-assets/readme.md/2024-04-06_120426.jpg)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**About License**</span>
This application is released under the [MIT license]($/Ingrid/LICENSE). You can use the code for any purpose, including commercial projects.

![MIT License](https://res.cloudinary.com/cagakmelon/image/upload/v1697064703/apps/ingrid-assets/readme.md/license.png)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**Navigation**</span>
| <span style="color:darkcyan">Helpful Pages :</span> | [Ingrid Web](https://ardhagp.github.io/ingrid) | [Ingrid Wiki](https://github.com/ardhagp/ingrid/wiki/01.-Home) |
| -- | -- | -- |



