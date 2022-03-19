using Microsoft.AspNetCore.Mvc;
using SchoolWebAPI.Business.Services.Interfaces;
using SchoolWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<List<Aluno>> GetAlunos()
        {
            return await _alunoService.GetAlunosAsync();
        }

    }
}
