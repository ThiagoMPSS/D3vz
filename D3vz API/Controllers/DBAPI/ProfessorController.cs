//using D3vzDbLibrary;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Net;
//using System.Text.RegularExpressions;

//namespace D3vz_API.Controllers.DBAPI {
//    public class ProfessorController : UserControllerBase {

//        public override string Discriminacao => "prof";

//        public ProfessorController(ILogger<AlunoController> logger) : base(logger) { }

//        [HttpPost]
//        public override IActionResult Add(string nm_user, string descricao, string email, string senha, string cpf, DateTime dt_nasc,
//                string? foto, string[]? interesses) {
//            try {
//                return base.Add(nm_user, descricao, email, senha, cpf, dt_nasc, foto, interesses, new TProf());
//            } catch (Exception ex) {
//                return BadRequest(ex);
//            }
//        }

//        [ApiExplorerSettings(IgnoreApi = true)]
//        public override IActionResult Update(long id, string? nm_user, string? descricao, string? email, string? senha, string? cpf, DateTime? dt_nasc, string? foto, string[] interesses) {
//            return base.Update(id, nm_user, descricao, email, senha, cpf, dt_nasc, foto, interesses);
//        }


//    }
//}
