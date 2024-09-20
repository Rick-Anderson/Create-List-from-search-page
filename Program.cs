
string input = @"
Use the Database Manager
/iis/extensions/database-manager/use-the-database-manager
Add a Connection String to a Web Application To add a new connection using a connection string: Open the Internet Information Services (IIS) Manager In the Connections view, select the site, application, or virtual directory to which you would like to add a connection string Figure 1: Features View In the Features View, double-click on the Connecti...

Database Manager for Hosters
/iis/web-hosting/web-server-for-shared-hosting/database-manager-for-hosters
The connection string includes the database server, database name, and user credentials (user name and password) IIS Manager has a Connection String module that the hoster can use to provide the connection string to the customer Or the customer can enter the connection string information that is provided by the hoster The user double-clicks the Dat...

Planning Step 3: Plan Data Source Settings
/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-3-plan-data-source-settings
A connection string usually supplies the server or location of the database server, the particular database to use, and the authentication information A connection string enables you to connect to databases from managed code applications in a centralized manner Adding a configuration setting adds the setting at the local level and to any child leve...

DatabaseProvider.CalculateConnectionString Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-calculateconnectionstring-method-microsoft-web-management-databasemanager
DatabaseProvider.CalculateConnectionString Method Returns the calculated connection string for the database provider Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters arguments Type: System.Collections.Generic.ICollection<Conne...

ConnectionStringsSection Class
/iis/wmi-provider/connectionstringssection-class
Name Description ConnectionStrings An array of ConnectionStringSettings values that contain database connection strings for ASP.NET applications and features Location (Inherited from ConfigurationSection.) A key property Path (Inherited from ConfigurationSection.) A key property SectionInformation (Inherited from ConfigurationSection.) Subclasses T...

Configuring Step 3: Configure Data Source Settings
/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-3-configure-data-source-settings
The variable connectionStringName='string' is the name of the connection string that is used to connect to the database The variable applicationName='string' is optional and is the virtual path of the application The variable enablePasswordReset=true enables password reset by using the provider ResetPassword method The default setting is false The ...

ConnectionStringSettings Class
/iis/wmi-provider/connectionstringsettings-class
Name Description ConnectionString A required read/write string value that specifies a database connection string Note: The value can be an empty string ("") IIS does not verify the validity of the connection string Name A required unique read/write string value that specifies the name of the database connection string This key attribute overrides ...

DatabaseProvider.ConnectionStringArguments Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-connectionstringarguments-property-microsoft-web-management-databasemanager
Remarks Your provider must implement the ConnectionStringArguments property in order to define the connection string arguments that your database provider requires Examples The following code sample illustrates an example ConnectionStringArguments property that returns the connection string arguments for a Microsoft Access database provider Permiss...

DatabaseProvider.GetServerTypes Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-getservertypes-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database connection Return Value Type: System.Collections.Generic.ICollection<TypeInfo> A read-only ICollectio...

Configuring Step 2: Configure ASP.NET Settings
/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-2-configure-asp-net-settings
On the Session State page, in the Session State Mode Settings area, click State Server Type a connection string in the Connection string text box, or click Create to create a connection string Type a time-out value in the Time-out (in seconds) text box The default time-out value is 10 seconds (Optional) Configure cookie settings in the Cookie Setti...

DatabaseProvider Class (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-class-microsoft-web-management-databasemanager
Methods Method Type Name Description CalculateConnectionString Returns the calculated connection string for the database provider Equals (Inherited from Object.) ExecuteQuery Returns an array of query results after executing a database query Finalize (Inherited from Object.) GetDatabaseHostName Returns the host name of the computer where the databa...

DatabaseProvider.ExecuteQuery Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-executequery-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database connection. query Type: Microsoft.Web.Management.DatabaseManager.Query The Query object that contains...

IDbViewManager.GetViews Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbviewmanager-getviews-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database Return Value Type: System.Collections.Generic.ICollection<View> An ICollection object that contains t...

DatabaseProvider.GetDatabaseInfo Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-getdatabaseinfo-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database connection Return Value Type: Microsoft.Web.Management.DatabaseManager.DatabaseInfo A DatabaseInfo ob...

DatabaseProvider.TestConnection Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-testconnection-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string to test Remarks Your provider must implement the TestConnection method in order to test the database connection for yo...

IDbStoredProcedureManager.GetStoredProcedureParameters Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-getstoredprocedureparameters-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the stored procedure Note If schema is empty, the ...

IDbTableManager.GetTableInfo Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-gettableinfo-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table. schema Type: System.String The schema name for ...

IDbTableManager.CreateTable Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-createtable-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the table Note If schema is empty, the default sch...

Web Deploy error codes - Internet Information Services
/troubleshoot/developer/webapps/iis/deployment-migration/web-deploy-error-codes
ERROR_INVALID_CONNECTION_STRING Diagnosis An invalid database connection string was specified which caused a dbFullSql or dbMySql provider to not run correctly This error can happen if a connection string is malformed (Example, Se v ver=localhost;...) or if the connection string contains keys, which the target database server doesn't recognize Reso...

Verifying the Developer Experience - ASP.NET
/iis/web-hosting/verifying-the-deployment/verifying-the-developer-experience-aspnet
the new connection: Install any IIS Manager extension modules that are offered in the following dialog: Select your new Graffiti site, find the Connection String icon and double click on it: Change the Server Name to the new target SQL Server To upload the database you can use the facilities provided by the hoster Either through database backup and...

IDbStoredProcedureManager.GetStoredProcedures Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-getstoredprocedures-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database Return Value Type: System.Collections.Generic.ICollection<StoredProcedure> An ICollection object that...

ConnectionArgument.Name Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-name-property-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Property Value Type: System.String The name of the connection argument Examples The following code sample illustrates an example ConnectionStringArgument property that returns the connecti...

IDbTableManager.GetTables Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-gettables-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database Return Value Type: System.Collections.Generic.ICollection<Table> An ICollection object that contains ...

IDbBackupManager.CreateBackup Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbbackupmanager-createbackup-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. backupPath Type: System.String The path of the backup to create Remarks All implementations of the I...

IDbTableManager.DropTable Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-droptable-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the table Note If schema is empty, the default sch...

ConnectionArgument.Value Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-value-property-microsoft-web-management-databasemanager
Examples The following code sample illustrates an example ConnectionStringArgument property that returns the connection string arguments for a Microsoft Access database provider Permissions Full trust for the immediate caller This member cannot be used by partially trusted code For more information, see Using Libraries from Partially Trusted Code S...

ConnectionArgument.DefaultValue Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-defaultvalue-property-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Property Value Type: System.String The database connection argument Examples The following code sample illustrates an example ConnectionStringArgument property that returns the connection ...

IDbStoredProcedureManager.GetStoredProcedureCreateStatement Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-getstoredprocedurecreatestatement-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database Return Value Type: Microsoft.Web.Management.DatabaseManager.Query A Query object that contains the CR...

IDbTableManager.EditTable Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-edittable-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the table Note If schema is empty, the default sch...

IDbViewManager.DropView Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbviewmanager-dropview-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the view Note If schema is empty, the default sche...

IDbTableManager.GetPrimaryKey Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtablemanager-getprimarykey-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table. schema Type: System.String The schema name for ...

IDbViewManager.CreateView Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbviewmanager-createview-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the view Note If schema is empty, the default sche...

DatabaseProvider.GetDatabaseHostName Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-getdatabasehostname-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database connection Return Value Type: System.String A string that contains the host name for the computer whe...

ConnectionArgument.IsRequired Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-isrequired-property-microsoft-web-management-databasemanager
Examples The following code sample illustrates an example ConnectionStringArgument property that returns the connection string arguments for a Microsoft Access database provider Permissions Full trust for the immediate caller This member cannot be used by partially trusted code For more information, see Using Libraries from Partially Trusted Code S...

Application Pool Identities and SQL Server Express
/iis/manage/configuring-security/application-pool-identities-and-sql-server-express
Here it is: The default connection string is using RANU (User Instance=true) as you can see The default connection string is used, for example, when a feature requires a database to store some data but no database is configured yet ASP.NET Membership is a good example for this If a developer adds Membership functionality to his web application ASP....

ConnectionArgument Class (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-class-microsoft-web-management-databasemanager
ConnectionArgument Class Specifies a connection argument for a database connection Inheritance Hierarchy System.Object Microsoft.Web.Management.DatabaseManager.ConnectionArgument Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax The Conne...

IDbCustomBackupRestoreManager.ListBackups Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbcustombackuprestoremanager-listbackups-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database Return Value Type: System.Collections.Generic.ICollection<String> An ICollection object that contains...

DatabaseProvider Methods (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/databaseprovider-methods-microsoft-web-management-databasemanager
GetType (Inherited from Object.) MemberwiseClone (Inherited from Object.) TestConnection Tests a connection string for a database provider ToString (Inherited from Object.) VerifyDependencies Verifies the database dependencies for your provider See Also Reference DatabaseProvider Class Microsoft.Web.Management.DatabaseManager Namespace Lists the me...

Export a Package through IIS Manager
/iis/publish/using-web-deploy/export-a-package-through-iis-manager
connection string (which will be updated in 2 places, first when running the SQL script and second inside the Web.config file) Click Next to continue Finally, choose a location to save your package For this example, we chose C:\MyApplication.zip The wizard will now complete the packaging process and save the package to disk When it is complete, you...

SqlCacheDependencyDatabase Class
/iis/wmi-provider/sqlcachedependencydatabase-class
Name Description ConnectionStringName A read/write string value that specifies the name of the connection string to the SQL data source Name A read-only string value that contains the name of the SQL database whose data is cached by ASP.NET. PollTime A read/write sint32 value, in milliseconds, that specifies how often the SQL data source is queried...

Building a Web Deploy Package from Visual Studio 2010
/iis/publish/using-web-deploy/building-a-web-deploy-package-from-visual-studio-2010
Select a database from the Database Entries list In the Connection string for destination database field, enter the connection string to be used when the database is deployed to the server This is needed for one-click publishing, but for packaging, this value will be used as a default that can be changed at deployment time.) Note: This value will N...

IDbRestoreManager.RestoreBackup Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbrestoremanager-restorebackup-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. backupPath Type: System.String The path of the backup to restore Remarks All implementations of the ...

IDbStoredProcedureManager.DropProcedure Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-dropprocedure-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the stored procedure Note If schema is empty, the ...

ConnectionArgument.IsPassword Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/connectionargument-ispassword-property-microsoft-web-management-databasemanager
This code sample offers the syntax to get or set a value that indicates whether the connection argument is a password.. /iis/extensions/database-manager-reference/connectionargument-ispassword-property-microsoft-web-management-databasemanager. Examples The following code sample illustrates an example ConnectionStringArgument property that returns ...

PowerShell scripts for automating Web Deploy setup
/iis/publish/using-web-deploy/powershell-scripts-for-automating-web-deploy-setup
Notice that the connection string fields are empty - they can be filled by hand or you can add this to the profile using the database generation scripts: Create a SQL database for a publishing account using the CreateSqlDatabase script Script: CreateSqlDatabase.ps1 Description: Creates a database, a login, a database user that has db_owner permissi...

Import a Package through IIS Manager
/iis/publish/using-web-deploy/import-a-package-through-iis-manager
In the Install an Application Package dialog, you will see the application and the database On the Parameters page, enter a new application name if desired and enter a SQL connection string Click Next to install the package The Summary page will provide a high-level overview of some items that were installed from the package The Details tab will gi...

APPL_PHYSICAL_PATH Server Variable on Windows Vista RTM
/iis/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/applphysicalpath-server-variable-on-windows-vista-rtm
For example, if the ASP code was in a page in the root folder of the Default Web Site, the contents of the computed connection string might resemble the following: If you have ASP configured to send errors to the browser, you will see the following error: To resolve this issue for Windows Vista, you can install Windows Vista SP1, or you can have yo...

Table.CreateDate Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/table-createdate-property-microsoft-web-management-databasemanager
Examples The following code sample implements the GetTables method to retrieve the list of tables for an OLEDB connection by using the connection string that the database manager provides Permissions Full trust for the immediate caller This member cannot be used by partially trusted code For more information, see Using Libraries from Partially Trus...

Table.Schema Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/table-schema-property-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Property Value Type: System.String The schema name for a table Remarks The Schema property specifies the name of the schema for a table in a database Examples The following code sample imp...

Table.Name Property (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/table-name-property-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Property Value Type: System.String The name for a table Remarks The Name property specifies the name of a table in a database Examples The following code sample implements the GetTables me...

APPL_PHYSICAL_PATH Server Variable on Windows Vista RTM
/iis/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/applphysicalpath-server-variable-on-windows-vista-rtm
For example, if the ASP code was in a page in the root folder of the Default Web Site, the contents of the computed connection string might resemble the following: If you have ASP configured to send errors to the browser, you will see the following error: To resolve this issue for Windows Vista, you

IDbViewManager.CreateView Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbviewmanager-createview-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the

Introduction to Web Deploy
/iis/publish/using-web-deploy/introduction-to-web-deploy
You can use Web Deploy to change a connection string or application setting during a sync.

IDbStoredProcedureManager.GetStoredProcedureCreateFromExistingStatement Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-getstoredprocedurecreatefromexistingstatement-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String storedProcedureName Type:

Configuring FTP with .NET Membership Authentication in IIS 7
/iis/publish/using-the-ftp-service/configuring-ftp-with-net-membership-authentication-in-iis-7
Configure the following options: Name: ""FtpSqlRoleProvider"" Connection string name: ""FtpLocalSQLServer"" Application name: ""/"" Click OK.Configure the following options: Name: ""FtpSqlMembershipProvider"" Connection string name: ""FtpLocalSQLServer"" Application name: ""/"" Click OK.

Web Deploy PowerShell Cmdlets
/iis/publish/using-web-deploy/web-deploy-powershell-cmdlets
Auto generated Web Deploy parameters: A parameter is created for changing the database connection string during restore or install Examples: 2.Auto generated Web Deploy parameters: A parameter is created for changing the database connection string during restore or install III.

IDbTableDataManager.DeleteRow Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtabledatamanager-deleterow-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table.

IDbTableDataManager.EditRow Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtabledatamanager-editrow-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table.

IDbStoredProcedureManager.GetStoredProcedureExecStatement Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbstoredproceduremanager-getstoredprocedureexecstatement-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. schema Type: System.String The schema name for the

IDbTableDataManager.GetData Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtabledatamanager-getdata-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table.

Run SQL Server stored procedures from an ASP Page - Internet Information Services
/troubleshoot/developer/webapps/iis/active-server-pages/run-sql-server-stored-procedures-asp-page
Modify the ADO connection string as appropriate for your environment.

IDbTableDataManager.DeleteRow Method (Microsoft.Web.Management.DatabaseManager)
/iis/extensions/database-manager-reference/idbtabledatamanager-deleterow-method-microsoft-web-management-databasemanager
Namespace: Microsoft.Web.Management.DatabaseManager Assembly: Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll) Syntax Parameters connectionString Type: System.String The connection string for the database. tableName Type: System.String The name of the table.

Tools and Utilities Questions
/iis/web-hosting/frequently-asked-questions-faq/tools-and-utilities-questions
Is there a way to test the connection strings in the UI when the strings are being specified?Unfortunately, there is no easy way to test connection strings because the connection string might only work in the context of the worker process.

Feature to Configuration Reference
/iis/get-started/planning-your-iis-architecture/feature-to-configuration-reference
Strings connectionStrings Custom Error Pages system.webServer/httpErrors CustomErrorModule (custerr.dll) Default Document system.webServer/defaultDocument DefaultDocumentModule (defdoc.dll) Directory Browsing system.webServer/directoryBrowse DirectoryListingModule (dirlist.dll) Failed Request Tracing

SessionStateSection Class
/iis/wmi-provider/sessionstatesection-class
SqlConnectionString A read/write string value that contains the connection string to a SQL Server.If you use this setting, you must specify a connection string in the SqlConnectionString property.

Using Custom Rewrite Providers with URL Rewrite Module
/iis/extensions/url-rewrite-module/using-custom-rewrite-providers-with-url-rewrite-module
Use the ""Edit Provider Setting"" dialog to configure the provider: Use the following values for the provider settings: SQL Server connection string: provide a SQL Server connection string, for example: ""Data Source=servername\sqlexpress;Initial Catalog=RewriteDB;Integrated Security=True"" Stored procedure

Delegated Administration
/iis/web-hosting/web-server-for-shared-hosting/delegated-administration
Connection Strings Read/Write Specifies the connection strings that applications use.

Use the Web Deployment Tool
/iis/publish/using-web-deploy/use-the-web-deployment-tool
Can add powerful parameters to change text in files when they are deployed (such as prompting to replace a connection string when deploying from quality assurance to staging environments).

Using Classic ASP with Microsoft Access Databases on IIS
/iis/application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/using-classic-asp-with-microsoft-access-databases-on-iis
Your ASP code would then reference the System DSN in the connection string instead of the physical path of the database, which is also better for security.

Planning Step 2: Plan ASP.NET Settings
/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/planning-step-2-plan-asp-net-settings
If you decide to store session state by using a state server, make the following design decisions: Define a connection string for the state server.If you decide to store session state in a SQL Server database, make the following design decisions: Define a connection string for the database.

ConfigurationSectionWithCollection Class
/iis/wmi-provider/configurationsectionwithcollection-class
ConnectionStringsSection Specifies a collection of database connection strings for ASP.NET applications.

CollectionElement Class
/iis/wmi-provider/collectionelement-class
ConnectionStringSettings Represents a named database connection string.

Create an FTP Authentication Provider with Dynamic IP Restrictions
/iis/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions
In SQL Server you would run the script in a new query window, and then create a database login that you will use with your connection string.

Web Deploy Parameterization
/iis/publish/using-web-deploy/web-deploy-parameterization
At a basic level, the above command uses the dbFullSql provider to copy data from a database using a database connection string (""-source:dbfullsql=…"") and copies it to a database script file (""-dest:dbfullsql=…"") Step 3 - Create a parameter file After you create the manifest file that tells Web Deploy
";







// Split the input into individual lines using a blank line (double new line) as a separator
var sections = input.Split(new[] { "\n\n", "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Line count: {sections.Length}");

foreach (var section in sections)
{
    // Split each section into its components
    var lines = section.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

    if (lines.Length >= 2)
    {
        // Extract the title and URL path
        string title = lines[0].Trim();
        string urlPath = lines[1].Trim();

        // Construct the full URL
        string fullUrl = "https://docs.microsoft.com/en-us" + urlPath;

        // Output the formatted result
        Console.WriteLine($"- [{title}]({fullUrl})");
    }
}




#if FIRST
string input = @"
- [ ] https://learn.microsoft.com/en-us/iis/wmi-provider/connectionstringssection-class
- [ ] https://learn.microsoft.com/en-us/iis/application-frameworks/scenario-build-an-aspnet-website-on-iis/configuring-step-3-configure-data-source-settings
- [ ] https://learn.microsoft.com/en-us/iis/wmi-provider/connectionstringsettings-class
- [ ] https://learn.microsoft.com/en-us/iis/extensions/database-manager-reference/databaseprovider-connectionstringarguments-property-microsoft-web-management-databasemanager
- [ ] https://learn.microsoft.com/en-us/iis/develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions
- [ ] https://learn.microsoft.com/en-us/iis/publish/using-web-deploy/web-deploy-parameterization";

// Split the input into individual lines
var lines = input.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

foreach (var line in lines)
{
    // Extract the URL part from the line (removing the "- [ ]" prefix)
    string url = line.Substring(line.IndexOf("https"));

    // Extract the last segment of the URL (after the last '/')
    string lastSegment = url.Split('/').Last();

    // Replace hyphens with spaces
    string title = lastSegment.Replace("-", " ");

    // Format the output
    Console.WriteLine($"- [ ] [{title}]({url})");
}

Console.WriteLine($"Line count: {lines.Length}");
#endif




