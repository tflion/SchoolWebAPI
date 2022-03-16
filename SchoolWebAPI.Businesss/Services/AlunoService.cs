using SchoolWebAPI.Business.Repository;
using SchoolWebAPI.Business.Repository.Interfaces;
using SchoolWebAPI.Business.Services.Interfaces;
using System.Collections.Generic;

namespace SchoolWebAPI.Business.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public List<string> GetAlunos()
        {
            return _alunoRepository.GetListaAlunos();

        }
    }
}
