using Microsoft.AspNetCore.Mvc;
using SchoolWebAPI.Business.Services.Interfaces;
using System.Collections.Generic;

namespace SchoolWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }    

        [HttpGet]
        [Route("/Alunos")]
        public IEnumerable<string> GetAlunos()
        {
            return _alunoService.GetAlunos();
        }

    }
}
