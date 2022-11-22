//using D3vzDbLibrary;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Net;
//using System.Text.Json;
//using System.Text.Json.Nodes;
//using System.Text.Json.Serialization;
//using System.Text.RegularExpressions;

//namespace D3vz_API.Controllers.DBAPI {
//    public class AlunoController : UserControllerBase {

//        public override string Discriminacao => "aluno";

//        public AlunoController(ILogger<AlunoController> logger) : base(logger) { }

//        [HttpPost]
//        public override IActionResult Add(string nm_user, string descricao, string email, string senha, string cpf, DateTime dt_nasc,
//                string? foto, string[]? interesses) {
//            return base.Add(nm_user, descricao, email, senha, cpf, dt_nasc, foto, interesses, aluno: new TAluno());
//        }

//        [HttpPut]
//        public override IActionResult Update(long id, string? nm_user, string? descricao, string? email, string? senha, string? cpf,
//                DateTime? dt_nasc, string? foto, string[] interesses) {
//            return base.Update(id, nm_user, descricao, email, senha, cpf, dt_nasc, foto, interesses, aluno: new TAluno());
//        }

//    }

//}
