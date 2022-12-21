using APIWithDapper.Entities;
using APIWithDapperTutorial.Entities;

namespace APIWithDapperTutorial.Core
{
    public interface ISchoolRepostory
    {
        Task<IEnumerable<School>> GetAllSchoolsAsync();
        Task<School> GetSchoolByIdAsync(int id);
        Task<School> GetSchoolByIdStoredProcedureAsync(int id);
        Task<int> CreateSchoolAsync(School school);
        Task<int> UpdateSchoolAsync(School school);
        Task<int> DeleteSchoolByIdAsync(int id);
        Task CreateMultipleschools(List<School> schools);
        List<ReportInfo> GetReport(int PageIndex, int PageSize, out int TotalRecords);
        //        Task<School> GetSchoolByStudentIdAsync(int studentId);
        //        Task<School> GetSchoolWithStudentsBySchoolId(int schoolId);
        //        Task<List<School>> GetMultipleSchoolsAndStudentsAsyn();
        //        Task CreateListOfSchoolsByAsync(List<School> schoolList);
    }
}
