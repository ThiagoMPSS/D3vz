using D3vzDbLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace D3vz_API.Controllers.DBAPI {
    [ApiController, Route("API/[controller]")]
    public abstract class UserControllerBase : ControllerBase, IBaseController {

        public virtual string Discriminacao => "";

        private readonly ILogger<AlunoController> _logger;
        public UserControllerBase(ILogger<AlunoController> logger) {
            _logger = logger;
        }

        internal static TUser_TInterQuali[] MakeInterQuali(string[] interesses, D3vzAPI_dbContext db) {
            try {
                var arr = interesses.Select(s => {
                    var interesseFound = db.TInteresses.Where(e => e.DsLinguagem == s).FirstOrDefault();
                    if (interesseFound == null)
                        return new TUser_TInterQuali() { TInterQuali_Navigation = new TInterQuali() { DsLinguagem = s } };
                    else
                        return new TUser_TInterQuali() { TInterQuali_Navigation = interesseFound };
                }).ToArray();
                return arr;
            } catch {
                throw;
            }
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult Add(string nm_user, string email, string senha, string cpf, DateTime dt_nasc, string[] interesses) {
            try {
                if (!Regex.IsMatch(email, "^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$"))
                    return new JsonResult(new {
                        Erro = "Endereço de email inválido."
                    });
                return null!;
            } catch {
                throw;
            }
        }

        public virtual IActionResult Delete(int Id) {
            return null!;
        }

        public virtual IActionResult Get(long id) {
            return null!;
        }

        public virtual IActionResult Get(string email) {
            return null!;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public virtual IActionResult Update(long id, string? nm_user, string? email, string? senha, string? cpf, DateTime? dt_nasc, string[] interesses) {
            return null!;
        }

        [HttpPost("Auth")]
        public virtual IActionResult Auth(string email, string senha) {
            try {
                var db = new D3vzAPI_dbContext();
                var userExists = (from user in db.TUsers
                                 where user.DsEmail == email
                                    && user.DsSenha == senha
                                    && user.Discriminacao == Discriminacao
                                 select user.IdUser).ToArray().FirstOrDefault(-1);
                if (userExists == -1)
                    return NotFound(new { Auth = false });

                return new JsonResult(new { Auth = true, Id = userExists });
            } catch (Exception ex) {
                return BadRequest(ex);
            }
        }
    }
}