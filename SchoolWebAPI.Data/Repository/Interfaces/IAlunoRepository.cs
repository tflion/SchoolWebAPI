using SchoolWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolWebAPI.Data.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        Task<List<Aluno>> GetAlunosAsync();

        Task<Aluno> InsertAlunoAsync(string nome, string cpf, string telefone, DateTime dataNascimento);
    }
}
