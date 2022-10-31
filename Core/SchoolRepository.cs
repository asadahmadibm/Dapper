using APIWithDapperTutorial.Entities;
using Dapper;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Data;

namespace APIWithDapperTutorial.Core
{
    public class SchoolRepository : ISchoolRepostory
    {
        private readonly SchoolContext _schoolContext;
        IDbConnection con;
        public SchoolRepository(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
            con = _schoolContext.CreateConnection();
        }

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

        public async Task<int> CreateSchoolAsync(School school)
        {
            string query = "Insert into school values(@id,@name,@address)";
            var q = await con.ExecuteAsync(query, school);
            return q;

        }

        public async Task<int> DeleteSchoolByIdAsync(int id)
        {
            string del = "delete from school where id=@id";
            var deletedcount=await con.ExecuteAsync(del,new
            {
                id = id
            });
            return deletedcount;
        }

        public async Task<IEnumerable<School>> GetAllSchoolsAsync()
        {
            var cnn = _schoolContext.CreateConnection();
            string query = "Select * from School";
            var list = await cnn.QueryAsync<School>(query);
            return list.ToList();
        }

        public async Task<School> GetSchoolByIdAsync(int id)
        {
            string query = "select * from School Where id=@id";
            var result= await con.QueryFirstAsync<School>(query,new
            {
                Id = id
            });
            return result;
        }

        public async Task<School> GetSchoolByIdStoredProcedureAsync(int id)
        {
            string ProcedureName = "SpGetById";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32, ParameterDirection.Input);
            var res=await con.QueryFirstAsync<School>(ProcedureName, parameters, commandType: CommandType.StoredProcedure);
            return res;

        }

        public async Task<int> UpdateSchoolAsync(School school)
        {
            string query = "Update School set id=@id,name=@name,address=@address where id=@id";

            var affectedRows = await con.ExecuteAsync(query, school);
            return affectedRows;
        }
    }
}
