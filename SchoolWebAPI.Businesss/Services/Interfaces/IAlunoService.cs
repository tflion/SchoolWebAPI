using SchoolWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolWebAPI.Business.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<List<Aluno>> GetAlunosAsync();

        Task<Aluno> InsertAlunoAsync(string nome, string cpf, string telefone, DateTime dataNascimento);
    }
}
