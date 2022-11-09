using D3vz_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace D3vz_API.Controllers.DBAPI {

    [Route("[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase {

        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger) {
            _logger = logger;
        }

        [HttpGet("GetById")]
        public JsonResult Get(long id) {
            try {
                using (var db = new D3vzAPI_dbContext()) {
                    var alunos = (from aluno in (db.TAlunos
                                    .Include(e => e.TUserIdUserNavigation)
                                    .Where(e => e.TUserIdUserNavigation.IdUser == id)
                                    .Include(e => e.TAluno_TInteresses).ThenInclude(e => e.TInteress_Navigation))
                                  select new {
                                      ID = aluno.TUserIdUser,
                                      Nome = aluno.TUserIdUserNavigation.NmUsuario,
                                      Email = aluno.TUserIdUserNavigation.DsEmail,
                                      CPF = aluno.TUserIdUserNavigation.NrCpf,
                                      Nascimento = aluno.TUserIdUserNavigation.DtNascimento,
                                      Interesses = aluno.TAluno_TInteresses.Select(e => e.TInteress_Navigation.DsInteresse)
                                  }).FirstOrDefault();

                    return new JsonResult(alunos);
                }
            } catch (Exception ex) {
                return new JsonResult(ex);
            }
        }

        [HttpGet()]
        public JsonResult Get(string email) {
            try {
                using (var db = new D3vzAPI_dbContext()) {
                    var alunos = (from aluno in (db.TAlunos
                                    .Include(e => e.TUserIdUserNavigation)
                                    .Where(e => e.TUserIdUserNavigation.DsEmail == email)
                                    .Include(e => e.TAluno_TInteresses).ThenInclude(e => e.TInteress_Navigation))
                                  select new {
                                      ID = aluno.TUserIdUser,
                                      Nome = aluno.TUserIdUserNavigation.NmUsuario,
                                      Email = aluno.TUserIdUserNavigation.DsEmail,
                                      CPF = aluno.TUserIdUserNavigation.NrCpf,
                                      Nascimento = aluno.TUserIdUserNavigation.DtNascimento,
                                      Interesses = aluno.TAluno_TInteresses.Select(e => e.TInteress_Navigation.DsInteresse)
                                  }).FirstOrDefault();
                    return new JsonResult(alunos);
                }
            } catch (Exception ex) {
                return new JsonResult(ex);
            }
        }

        private static TAluno_TInteress[] MakeInteresses(string[] interesses, D3vzAPI_dbContext db) {
            try {
                var arr = interesses.Select(s => {
                    var interesseFounded = db.TInteresses.Where(e => e.DsInteresse == s).FirstOrDefault();
                    if (interesseFounded == null)
                        return new TAluno_TInteress() { TInteress_Navigation = new TInteress() { DsInteresse = s } };
                    else
                        return new TAluno_TInteress() { TInteress_Navigation = interesseFounded };
                }).ToArray();
                return arr;
            } catch (Exception ex) {
                throw;
            }
        }

        [HttpPost()]
        public JsonResult Add(string nm_user, string email, string senha, string cpf, DateTime dt_nasc, string[] interesses) {
            try {
                if (!Regex.IsMatch(email, "^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$"))
                    return new JsonResult(new {
                        Erro = "Endereço de email inválido."
                    });

                using (var db = new D3vzAPI_dbContext()) {
                    var inte = MakeInteresses(interesses, db);
                    var user = new TUser() {
                        Discriminacao = "aluno",
                        NmUsuario = nm_user,
                        DsEmail = email,
                        DsSenha = senha,
                        NrCpf = cpf,
                        DtNascimento = dt_nasc,
                        TAluno = new TAluno() {
                            TAluno_TInteresses = MakeInteresses(interesses, db)
                        }
                    };
                    db.TUsers.Add(user);
                    db.SaveChanges();
                    return new JsonResult("OK");
                }
            } catch (Exception ex) {
                return new JsonResult(ex);
            }
        }

        [HttpPut()]
        public JsonResult Update(long id, string? nm_user, string? email, string? senha, string? cpf, DateTime? dt_nasc, string[] interesses) {
            try {
                using (var db = new D3vzAPI_dbContext()) {
                    var aluno = db.TAlunos
                        .Where(a => a.TUserIdUser == id)
                        .Include(e => e.TUserIdUserNavigation)
                        .Include(e => e.TAluno_TInteresses)
                        .ThenInclude(e => e.TInteress_Navigation)
                        .FirstOrDefault();

                    if (aluno == null)
                        return new JsonResult(new {
                            Erro = "Cadastro não encontrado."
                        });

                    if (!string.IsNullOrEmpty(nm_user)) aluno.TUserIdUserNavigation.NmUsuario = nm_user;
                    if (!string.IsNullOrEmpty(email)) aluno.TUserIdUserNavigation.DsEmail = email;
                    if (!string.IsNullOrEmpty(senha)) aluno.TUserIdUserNavigation.DsSenha = senha;
                    if (!string.IsNullOrEmpty(cpf)) aluno.TUserIdUserNavigation.NrCpf = cpf;
                    if (dt_nasc != null) aluno.TUserIdUserNavigation.DtNascimento = dt_nasc.Value;
                    if (interesses != null) {
                        var remover = aluno.TAluno_TInteresses.Where(e => !interesses.Contains(e.TInteress_Navigation.DsInteresse));
                        var adicionar = interesses.Where(e => aluno.TAluno_TInteresses.Where(e1 => e1.TInteress_Navigation.DsInteresse == e).FirstOrDefault() == null);
                        foreach (var item in remover)
                            aluno.TAluno_TInteresses.Remove(item);
                        foreach (var item in adicionar)
                            aluno.TAluno_TInteresses.Add(MakeInteresses(new string[] { item }, db).First());
                    }

                    db.SaveChanges();

                    return new JsonResult("Ok");
                }
            } catch (Exception ex) {
                return new JsonResult(ex);
            }
        }

        [HttpDelete]
        public JsonResult Delete(int Id) {
            try {
                using (var db = new D3vzAPI_dbContext()) {
                    var aluno = db.TAlunos.Where(e => e.TUserIdUser == Id).Include(e => e.TUserIdUserNavigation).FirstOrDefault();
                    if (aluno == null)
                        return new JsonResult(new {
                            Erro = "Cadastro não encontrado."
                        });

                    db.TAlunos.Remove(aluno);
                    db.TUsers.Remove(aluno.TUserIdUserNavigation);
                    db.SaveChanges();
                    return new JsonResult("Ok");
                }
            } catch (Exception ex) {
                return new JsonResult(ex);
            }
        }

    }

}
