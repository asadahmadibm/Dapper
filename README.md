# Dapper
Using Dapper with ASP.NET Core Web API
About Extension Methods
# Dapper extends the IDbConnection interface with these multiple methods:

Execute – an extension method that we use to execute a command one or multiple times and return the number of affected rows

Query – with this extension method we can execute a query and map the result

QueryFirst –  it executes a query and maps the first result

QueryFirstOrDefault – we use this method to execute a query and map the first result, or a default value if the sequence contains no elements

QuerySingle – an extension method that can execute a query and map the result.  It throws an exception if there is not exactly one element in the sequence

QuerySingleOrDefault – executes a query and maps the result, or a default value if the sequence is empty. It throws an exception if there is more than one element in the sequence

QueryMultiple – an extension method that executes multiple queries within the same command and map results
# install two required packages
Dapper – PM> Install-Package Dapper

SQL Client – PM> Install-Package Microsoft.Data.SqlClient

# Example FOR CRUD
 INSERT :

string query = "Insert into school values(@id,@name,@address)";

var q = await con.ExecuteAsync(query, school);

Update :

string query = "Update School set id=@id,name=@name,address=@address where id=@id";

var affectedRows = await con.ExecuteAsync(query, school);

Delete :

string del = "delete from school where id=@id";

var deletedcount=await con.ExecuteAsync(del,new
{id = id });

Get all:

var cnn = _schoolContext.CreateConnection();

string query = "Select * from School";

var list = await cnn.QueryAsync<School>(query);

return list.ToList();

Get by id :

string query = "select * from School Where id=@id";
            
var result= await con.QueryFirstAsync<School>(query,new
            {
                Id = id
            });

Translation:

public async Task CreateMultipleschools(List<School> schools)
        
{
            
     string query = "Insert into School values(@id,@name,@address)";
            
     con.Open();
            
   using (var trans=con.BeginTransaction())
            
   {
                
    foreach (var item in schools)
              
    {
                   
     var res=await con.ExecuteAsync(query,item, transaction: trans);
                
     }
                
      trans.Commit();
            
    }
        
}

Sp
     string ProcedureName = "SpGetById";
     var parameters = new DynamicParameters();
     parameters.Add("Id", id, DbType.Int32, ParameterDirection.Input);
     var res=await con.QueryFirstAsync<School>(ProcedureName, parameters, commandType: CommandType.StoredProcedure);


