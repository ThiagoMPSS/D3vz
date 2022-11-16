using D3vzDbLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace D3vz_API.Controllers.DBAPI {
    public class ProfessorController : UserControllerBase {

        public override string Discriminacao => "prof";

        public ProfessorController(ILogger<AlunoController> logger) : base(logger) { }

        [HttpPost()]
        public IActionResult Add(string nm_user, string descricao, string email, string senha, string cpf, DateTime dt_nasc, string[] qualidades) {
            try {
                base.Add(nm_user, email, senha, cpf, dt_nasc, qualidades);

                using var db = new D3vzAPI_dbContext();
                var inte = MakeInterQuali(qualidades, db);
                var user = new TUser() {
                    Discriminacao = this.Discriminacao,
                    NmUsuario = nm_user,
                    DsEmail = email,
                    DsSenha = senha,
                    NrCpf = cpf,
                    DtNascimento = dt_nasc,
                    TUser_TInterQuali = MakeInterQuali(qualidades, db),
                    TProf = new TProf() { DsProf = descricao }
                };
                db.TUsers.Add(user);
                db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpDelete()]
        public override IActionResult Delete(int Id) {
            try {
                using var db = new D3vzAPI_dbContext();
                var prof = db.TProfs.Where(e => e.TUserIdUser == Id)
                    .Include(e => e.TUserIdUserNavigation)
                    .FirstOrDefault();
                if (prof == null)
                    return StatusCode((int)HttpStatusCode.NotFound, new JsonResult(new {
                        Erro = "Cadastro não encontrado."
                    }));

                db.TProfs.Remove(prof);
                db.TUsers.Remove(prof.TUserIdUserNavigation);
                db.SaveChanges();

                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet("GetById")]
        public override IActionResult Get(long id) {
            try {
                using var db = new D3vzAPI_dbContext();
                var prof = (from professor in (db.TProfs
                                .Include(e => e.TUserIdUserNavigation)
                                .ThenInclude(e => e.TUser_TInterQuali)
                                .ThenInclude(e => e.TInterQuali_Navigation))
                                .Where(e => e.TUserIdUserNavigation.IdUser == id)
                            select new {
                                ID = professor.TUserIdUser,
                                Nome = professor.TUserIdUserNavigation.NmUsuario,
                                Descricao = professor.DsProf,
                                Email = professor.TUserIdUserNavigation.DsEmail,
                                CPF = professor.TUserIdUserNavigation.NrCpf,
                                Nascimento = professor.TUserIdUserNavigation.DtNascimento,
                                Qualidades = professor.TUserIdUserNavigation.TUser_TInterQuali.Select(e => e.TInterQuali_Navigation.DsLinguagem)
                            }).FirstOrDefault();

                return new JsonResult(prof);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet()]
        public override IActionResult Get(string email) {
            try {
                using var db = new D3vzAPI_dbContext();
                var prof = (from professor in (db.TProfs
                                .Include(e => e.TUserIdUserNavigation)
                                .ThenInclude(e => e.TUser_TInterQuali)
                                .ThenInclude(e => e.TInterQuali_Navigation)
                                .Where(e => e.TUserIdUserNavigation.DsEmail == email))
                            select new {
                                ID = professor.TUserIdUser,
                                Nome = professor.TUserIdUserNavigation.NmUsuario,
                                Descricao = professor.DsProf,
                                Email = professor.TUserIdUserNavigation.DsEmail,
                                CPF = professor.TUserIdUserNavigation.NrCpf,
                                Nascimento = professor.TUserIdUserNavigation.DtNascimento,
                                Qualidades = professor.TUserIdUserNavigation.TUser_TInterQuali.Select(e => e.TInterQuali_Navigation.DsLinguagem)
                            }).FirstOrDefault();

                return new JsonResult(prof);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpPut()]
        public IActionResult Update(long id, string? nm_user, string? descricao, string? email, string? senha, string? cpf, DateTime? dt_nasc, string[] interesses) {
            try {
                using var db = new D3vzAPI_dbContext();
                var prof = db.TProfs
                    .Where(a => a.TUserIdUser == id)
                    .Include(e => e.TUserIdUserNavigation)
                    .ThenInclude(e => e.TUser_TInterQuali)
                    .ThenInclude(e => e.TInterQuali_Navigation)
                    .FirstOrDefault();

                if (prof == null)
                    return StatusCode((int)HttpStatusCode.NotFound, new JsonResult(new {
                        Erro = "Cadastro não encontrado."
                    }));

                if (!string.IsNullOrEmpty(nm_user)) prof.TUserIdUserNavigation.NmUsuario = nm_user;
                if (!string.IsNullOrEmpty(descricao)) prof.DsProf = descricao;
                if (!string.IsNullOrEmpty(email)) prof.TUserIdUserNavigation.DsEmail = email;
                if (!string.IsNullOrEmpty(senha)) prof.TUserIdUserNavigation.DsSenha = senha;
                if (!string.IsNullOrEmpty(cpf)) prof.TUserIdUserNavigation.NrCpf = cpf;
                if (dt_nasc != null) prof.TUserIdUserNavigation.DtNascimento = dt_nasc.Value;
                if (interesses != null) {
                    var remover = prof.TUserIdUserNavigation.TUser_TInterQuali.Where(e => !interesses.Contains(e.TInterQuali_Navigation.DsLinguagem));
                    var adicionar = interesses.Where(e => prof.TUserIdUserNavigation.TUser_TInterQuali.Where(e1 => e1.TInterQuali_Navigation.DsLinguagem == e).FirstOrDefault() == null);
                    foreach (var item in remover)
                        prof.TUserIdUserNavigation.TUser_TInterQuali.Remove(item);
                    foreach (var item in adicionar)
                        prof.TUserIdUserNavigation.TUser_TInterQuali.Add(MakeInterQuali(new string[] { item }, db).First());
                }

                db.SaveChanges();

                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

    }
}
