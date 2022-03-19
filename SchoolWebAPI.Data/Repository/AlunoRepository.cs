using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using SchoolWebAPI.Data.Repository.Interfaces;
using SchoolWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWebAPI.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly IConfiguration _configuracoes;

        private string Conexao {  get { return _configuracoes.GetConnectionString("DefaultConnection"); } }
        
        public AlunoRepository(IConfiguration configuracoes)
        {
            _configuracoes = configuracoes;
        }

        public async Task<List<Aluno>> GetAlunosAsync()
        {
            using var conexao = new MySqlConnection(Conexao);

            var alunos = await conexao.QueryAsync<Aluno>("SELECT * FROM aluno");

            return alunos.ToList();
        }

        public async Task<Aluno> InsertAlunoAsync(string nome, string cpf, string telefone, DateTime dataNascimento)
        {
            using var conexao = new MySqlConnection(Conexao);

            await conexao.ExecuteAsync("INSERT INTO aluno (Nome, CPF, Telefone, DataNascimento) VALUES (@Nome, @CPF, @Telefone, @DataNascimento)", new Aluno
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                DataNascimento = dataNascimento
            });

            return new Aluno 
            { 
               Nome = nome,
               CPF = cpf,
               Telefone = telefone,
               DataNascimento = dataNascimento
            };

        }
    }
}
