using D3vz_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;

namespace D3vz_API.Controllers.DBAPI {

    [Route("[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase {

        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger) {
            _logger = logger;
        }

        [HttpGet()]
        public JsonResult Get() {
            var db = D3vzAPI_dbContext.Instance;
            var alunos = (from aluno in db.TAlunos
                          join user in db.TUsers on aluno.TUserIdUser equals user.IdUser
                          join interesses in db.TInteresses on user.IdUser equals interesses.TAlunoTUserIdUser
                          select new {
                              user.IdUser,
                              user.NmUsuario,
                              user.DsEmail,
                              user.NrCpf,
                              user.DtNascimento,
                              aluno.TInteresses
                          });
            return new JsonResult(alunos);
        }

        [HttpPost()]
        public JsonResult Add(string nm_user, string email, string senha, int cpf, DateTime dt_nasc, string[] interesses) {
            //try {
                var db = D3vzAPI_dbContext.Instance;
                db.TUsers.Add(new TUser() {
                    Discriminacao = "aluno",
                    NmUsuario = nm_user,
                    DsEmail = email,
                    DsSenha = senha,
                    NrCpf = cpf,
                    DtNascimento = dt_nasc,
                    TAluno = new TAluno() {
                        TInteresses = interesses.Select(s => new TInteress() { DsInteresse = s }).ToArray()
                    }
                });
                db.SaveChanges();
                return new JsonResult("OK");
            //} catch (Exception ex) {
            //    return new JsonResult(ex);
            //}
        }

    }

}
