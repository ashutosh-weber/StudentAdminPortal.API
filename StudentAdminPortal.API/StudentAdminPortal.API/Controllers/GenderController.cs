using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController] // i will decorate my controller  apicontroller attribute .

    public class GenderController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GenderController(IStudentRepository studentRespository,IMapper mapper )
        {
            this.studentRepository = studentRespository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var genderList = await studentRepository.GetGendersAsync();
            if (genderList == null || !genderList.Any())
            {
                return NotFound();

            }
            return Ok(mapper.Map<List<Gender>>(genderList));
            
            
        }
    }
}
