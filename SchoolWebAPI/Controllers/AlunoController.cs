using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        readonly List<string> alunos = new List<string> { "Thales", "Lucas", "Helena" };

        [HttpGet]
        public IEnumerable<string> GetAlunos()
        {
            return alunos;
        }

    }
}
