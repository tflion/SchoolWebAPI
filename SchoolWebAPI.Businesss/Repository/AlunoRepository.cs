using SchoolWebAPI.Business.Repository.Interfaces;
using System.Collections.Generic;

namespace SchoolWebAPI.Business.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        public List<string> GetListaAlunos()
        {
            return new List<string> { "Thales", "Lucas", "Nicole"};
        }
    }
}
