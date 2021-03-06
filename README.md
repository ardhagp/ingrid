![Welcome To My Project](https://res.cloudinary.com/cagakmelon/image/upload/v1592285857/globals/assets/img/tfso/ingrid_header.png)

#   <span style="color:orange">Pendahuluan</span>
INGRID adalah sebuah aplikasi dengan berbagai macam fungsi, semacam ERP dengan flow yang lebih
mudah untuk digunakan.

#   <span style="color:orange">Developer Tools</span>
Kebutuhan minimum sistem untuk pengembangan project ini adalah sebagai berikut :
1.	Visual Studio 2015 Community Edition (VB.Net)
2.	.NET Framework 4.8 ([https://go.microsoft.com/fwlink/?linkid=2088517](https://go.microsoft.com/fwlink/?linkid=2088517))

#   <span style="color:orange">MS SQL Server Database</span> (Recommended)
- SQL Server 2014 Express Advanced Services (_Please choose_ ExpressAdv 64BIT\SQLEXPRADV_x64_ENU.exe) ([https://www.microsoft.com/en-US/download/details.aspx?id=42299](https://www.microsoft.com/en-US/download/details.aspx?id=42299)) atau versi SQL Server lebih tinggi.
##  _SQL Server Connection Settings :_
1.  Tambahkan user "mvu_admin" dengan password "admin" pada SQL Server.
2.  Attach database "db_universe_erp.mdf" dan "db_universe_erp_file.mdf" dari direktori [$/QERP/Database/Empty Database (Default)].
3.  Set user "mvu_admin" sebagai owner database tersebut.

#   <span style="color:orange">MySQL Database</span>
- (**Optional**) MySQL Community 8.0.20 ([https://dev.mysql.com/downloads/installer/](https://dev.mysql.com/downloads/installer/))
**Note :** _Connection to this database are still in development._
##  _<u>MySQL Connection Settings :</u>_
> Still in development

#   <span style="color:orange">Portable Database</span>
1.  (**New**) LocalDB (_Tercakup di dalam SQL Server 2014 Express Advanced Services. Jangan lupa untuk mencentang fitur ini saat instalasi SQL Server, atau download terpisah dari [sini](https://www.microsoft.com/en-US/download/details.aspx?id=42299) dengan memilih **LocalDB 64BIT\SqlLocalDB.msi**)

#   <span style="color:orange">Dependencies</span>
Project ini membutuhkan komponen sebagai berikut :
1.  Syncfusion Community License ([https://www.syncfusion.com/products/communitylicense](https://www.syncfusion.com/products/communitylicense))
2.  Syncfusion - WindowsForm (16.4.0.52) ([https://www.syncfusion.com/account/downloads/studio/licensed/16_4_0_52](https://www.syncfusion.com/account/downloads/studio/licensed/16_4_0_52), [Mirror](https://mega.nz/file/Lh5Q2Y7A#z3D4lLgGbm_hvLU2sgMhZvh2xbiuZz_SX0htEP-20EQ))
3.  Syncfusion - FileFormat (16.4.0.52) ([https://www.syncfusion.com/account/downloads/studio/licensed/16_4_0_52](https://www.syncfusion.com/account/downloads/studio/licensed/16_4_0_52), [Mirror](https://mega.nz/file/3o41waJJ#4iVkL56Z8ydwibRxFw6VeRafGdvxd2LRH3YlQr6Ps1A))
4.  Microsoft Chart Control (_Nuget Package Included_)
5.  Microsoft Visual Basic Power Packs 3.0 ([https://www.microsoft.com/en-us/download/details.aspx?id=25169](https://www.microsoft.com/en-us/download/details.aspx?id=25169), [Mirror](https://mega.nz/file/KxxhgKpS#VdNY0O1vvfB_R71FEhQhQgQjfeU_7lRFvcAfWFzgWaE))
6.  Advanced Installer extension for Visual Studio (_Install from Visual Studio, Tools > Extensions and Updates..._)
8.  Advanced Installer Express 16.9 ([https://www.advancedinstaller.com/express-edition.html](https://www.advancedinstaller.com/express-edition.html), [Mirror](https://mega.nz/file/OkY22JrZ#GSaUU8aRTOII49yzlg_-11ORstSqHxtdj0Di6NpBV9Y))
7.  CMC Components ([https://github.com/ardhagp/cmc](https://github.com/ardhagp/cmc))

#   <span style="color:orange">Development Mode</span>
1.  Set "_PRODUCTIONMODE" pada file [$/QERP/Apps/QERP/020. Module/Mode.vb] dengan nilai "False".
2.  Konfigurasi dapat diubah pada file [$/QERP/Apps/QERP/080. Database/dev_catalog.mdb]

#   <span style="color:orange">Production Mode</span>
1.  Set "_PRODUCTIONMODE" pada file [$/QERP/Apps/QERP/020. Module/Mode.vb] dengan nilai "True".
2.  Sesuaikan nilai Server Address, Username, Password, Port pada file [$/QERP/Apps/QERP/080. Database/catalog.mdb]

#   <span style="color:orange">Ingrid Module List :</span>
- DAR

#   <span style="color:orange">Ikut Berkontribusi?</span>
Anda dapat berkontribusi dengan cara :
1.  Melaporkan bug di halaman [Issues](https://github.com/ardhagp/ingrid/issues)
2.  Membuat dokumentasi penggunaan aplikasi pada halaman [Wiki](https://github.com/ardhagp/ingrid/wiki)
3.  Jika anda seorang developer, silahkan email ke tito.ardha@windowslive.com untuk bergabung.
