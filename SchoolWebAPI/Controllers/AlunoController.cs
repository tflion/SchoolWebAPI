using Microsoft.AspNetCore.Mvc;
using SchoolWebAPI.Business.Services.Interfaces;
using SchoolWebAPI.Models;
using System;
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
        [Route("/Buscar")]
        public async Task<List<Aluno>> GetAlunos()
        {
            return await _alunoService.GetAlunosAsync();
        }

        [HttpPost]
        [Route("/Inserir")]
        public async Task<Aluno> InsertAluno([FromQuery] string nome, [FromQuery] string cpf, [FromQuery] string telefone, [FromQuery] DateTime dataNascimento)
        {
            return await _alunoService.InsertAlunoAsync(nome, cpf, telefone, dataNascimento);
        }

    }
}
