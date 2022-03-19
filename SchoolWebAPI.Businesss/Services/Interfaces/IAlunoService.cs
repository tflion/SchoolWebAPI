﻿using SchoolWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolWebAPI.Business.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<List<Aluno>> GetAlunosAsync();
    }
}
