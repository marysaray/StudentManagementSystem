# Student Management System
In-Class Example of an Object Oriented Program Application 
- Windows Form App in the .NET Framework using C#.
- Creating a prototype application for Students to register in a system.
- A desktop application that sends and retrieve data from a local database.

      CRUD Functionality:
        - Add
        - Get
        - Update
        - Delete
       
## SQL Server Data Type Mappings 
The following table shows the inferred:
- .NET Framework type
- the DbType and SqlDbType enumerations
- the accessor methods for the SqlDataReader.

Resource: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings

## Use Type-Safe SQL Parameters
### IMPORTANT! *Security Feature:* **Avoid vulnerabilities to the software and prevent SQL injections.**
- The Parameters collection in SQL Server provides type checking and length validation.
- If you use the Parameters collection, input is treated as a literal value instead of as executable code.
- An additional benefit of using the Parameters collection is that you can enforce type and length checks.
- Values outside the range will trigger an exception. The following code fragment shows using the Parameters collection: 

      SqlDataAdapter myCommand = new SqlDataAdapter("AuthorLogin", conn);  
      myCommand.SelectCommand.CommandType = CommandType.StoredProcedure;  
      SqlParameter parm = myCommand.SelectCommand.Parameters.Add("@au_id",  
           SqlDbType.VarChar, 11);  
      parm.Value = Login.Text;
      
## Use the Parameters Collection with Dynamic SQL
If you cannot use stored procedures, you can still use parameters, as shown in the following code example.

    SqlDataAdapter myCommand = new SqlDataAdapter(  
    "SELECT au_lname, au_fname FROM Authors WHERE au_id = @au_id", conn);  
    SQLParameter parm = myCommand.SelectCommand.Parameters.Add("@au_id",   
                            SqlDbType.VarChar, 11);  
    Parm.Value = Login.Text;
    
Resource: https://docs.microsoft.com/en-us/sql/relational-databases/security/sql-injection?view=sql-server-ver15
