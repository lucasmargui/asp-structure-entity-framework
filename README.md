<H1 align="center">Entity Framework Structure</H1>
<p align="center">🚀 Project to create a structure using Entity Framework for future references</p>

## Resources Used

* NET 4.7.0
* Entity Framework

  ## Entity Framework execution in IDE's: VS 2015/2017:

 

  <details>
   <summary>Click to show content</summary>
   When executing the commands:
 
   ```
     Enable-Migrations
   ```
   It is
  
   ```
     Update-Database -Verbose
   ```
  
In the most recent versions of Visual Studio (2015/2017), it is necessary to create a new instance of sql localdb on your computer. Which can be created in the following way:

Step 1: Open cmd and execute the following command:
   ```
   SqlLocalDB.exe create "Local"
   ```
Step 2: Run the instance with the following command:
   ```
   SqlLocalDb.exe start
   ```
  
Step 3: Go to the 'Package Manager Console' and execute the following command:
   ```
   Update-Database -Verbose
   ```

## Changing the connection string

Configure connectionStrings with local database where 'name' will be used as a reference for connecting to Entity Framework
```
Web.Config
```
```
<connectionStrings>
   <add name="Registration" connectionString="Data Source=(localdb)\Local;Initial Catalog=DbClientes;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```


</details>

 
 
## Model Create
<details>
   <summary>Click to show content</summary>
  
### Context Registration Creation

This class will be responsible for creating the database with its respective tables through the Entity Framework
```
Models/CadastroContext.cs
```
<br>
<br>

Method responsible for using the connectionString from web.config to connect to the database and create the database

```
   public CadastroContext():base("Registration")
         {

         }
```
<br>
<br>

DbSet uses the Model of classes to create tables

```
public DbSet<Customer> Customers { get; set; }
```

### Customer Create

Model that will be used as a basis for creating tables through EntityFramework and Data Annotations in CadastroContext.cs
```
Models/Cliente.cs
```


</details>
