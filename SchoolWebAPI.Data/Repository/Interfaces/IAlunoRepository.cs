using SchoolWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolWebAPI.Data.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        Task<List<Aluno>> GetAlunosAsync();
    }
}
