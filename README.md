# Pendahuluan
QERP / Project Agatha / INGRID adalah sebuah aplikasi dengan berbagai macam fungsi, semacam ERP dengan flow yang lebih
mudah untuk digunakan.

# Aplikasi Developer
Kebutuhan minimum sistem yang digunakanan untuk mengembangkan project ini adalah sebagai berikut :
1.	Visual Studio 2015 Community Edition (VB)
2.	SQL Server 2014 Express
3.	~~MS Access~~ / Digantikan dengan LocalDB (_Include in SQL Server 2014 Express_)
4.	.NET Framework 4.6

# Dependensi
Project ini membutuhkan komponen sebagai berikut :
1.  Syncfusion for Desktop ([https://www.syncfusion.com/products/windows-forms](https://www.syncfusion.com/products/windows-forms))
2.  Syncfusion Community License ([https://www.syncfusion.com/products/communitylicense](https://www.syncfusion.com/products/communitylicense))
3.  CMC Components ([https://cagakmelon.visualstudio.com/CMC](https://cagakmelon.visualstudio.com/CMC))
4.  Microsoft Chart Control (_Nuget Package Included_)

# Database & Koneksi
1.  Tambahkan user "mvu_admin" dengan password "admin" pada SQL Server.
2.  Attach database "db_universe_erp.mdf" dan "db_universe_erp_file.mdf" dari direktori [$/QERP/Database/Empty Database (Default)].
3.  Set user "mvu_admin" sebagai owner database tersebut.

# Development Mode
1.  Set "_PRODUCTIONMODE" pada file [$/QERP/Apps/QERP/020. Module/Mode.vb] dengan nilai "False".
2.  Konfigurasi dapat diubah pada file [$/QERP/Apps/QERP/080. Database/dev_catalog.mdb]

# Production Mode
1.  Set "_PRODUCTIONMODE" pada file [$/QERP/Apps/QERP/020. Module/Mode.vb] dengan nilai "True".
2.  Sesuaikan nilai Server Address, Username, Password, Port pada file [$/QERP/Apps/QERP/080. Database/catalog.mdb]

# Compiling Project
1.  Gunakan Project QERP Setup untuk mengcompile project ini.

# Ikut Berkontribusi?
Anda dapat berkontribusi dengan cara :
1.  Melaporkan bug
2.  Membuat dokumentasi penggunaan aplikasi pada halaman Wiki
3.  Jika anda seorang developer, silahkan email ke tito.ardha@windowslive.com untuk bergabung.
