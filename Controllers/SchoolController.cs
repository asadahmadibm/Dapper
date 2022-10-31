using APIWithDapperTutorial.Core;
using APIWithDapperTutorial.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIWithDapperTutorial.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class SchoolController : ControllerBase
    {
        ISchoolRepostory _schoolRepository;
        public SchoolController(ISchoolRepostory schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        [HttpGet(Name ="GetAll")]
        public async Task<IActionResult> GetAllSchool()
        {
            try
            {
                var list = await _schoolRepository.GetAllSchoolsAsync();
                return Ok(list);

            }
            catch (Exception ex) 
            {
                return StatusCode(500,ex.GetBaseException().Message);
            }
        }
        [HttpGet("{id}",Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var s = await _schoolRepository.GetSchoolByIdAsync(id);
                return Ok(s);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.GetBaseException().Message);
            }

        }
        [HttpPost]
        public async Task<IActionResult> CreateSchool(School school)
        {
            try
            {
                var sc = await _schoolRepository.CreateSchoolAsync(school);
                return Ok(sc);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.GetBaseException().Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSchool(School school)
        {
            try
            {
                var sc = await _schoolRepository.UpdateSchoolAsync(school);
                return Ok(sc);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.GetBaseException().Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSchool(int id)
        {
            try
            {
                var deletedeffect = await _schoolRepository.DeleteSchoolByIdAsync(id);
                return Ok(deletedeffect);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.GetBaseException().Message);
            }
        }
    }
}
