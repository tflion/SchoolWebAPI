using SchoolWebAPI.Data.Repository.Interfaces;
using SchoolWebAPI.Business.Services.Interfaces;
using System.Collections.Generic;
using SchoolWebAPI.Models;
using System.Threading.Tasks;

namespace SchoolWebAPI.Business.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<List<Aluno>> GetAlunosAsync()
        {
            return await _alunoRepository.GetAlunosAsync();

        }
    }
}
