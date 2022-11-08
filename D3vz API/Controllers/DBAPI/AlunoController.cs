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

        //[HttpGet("GetById")]
        //public JsonResult Get(long id) {
        //    try {
        //        var db = D3vzAPI_dbContext.Instance;
        //        var alunos = (from aluno in db.TAlunos
        //                      join user in db.TUsers on aluno.TUserIdUser equals user.IdUser
        //                      join interesses in db.TInteresses on user.IdUser equals interesses.TAlunoTUserIdUser
        //                      where user.IdUser == id
        //                      select new {
        //                          ID = user.IdUser,
        //                          Nome = user.NmUsuario,
        //                          Email = user.DsEmail,
        //                          CPF = user.NrCpf,
        //                          Nascimento = user.DtNascimento,
        //                          Interesses = interesses
        //                      }).FirstOrDefault();

        //        JsonSerializerOptions options = new() { ReferenceHandler = ReferenceHandler.Preserve };

        //        return new JsonResult(alunos, options);
        //    } catch (Exception ex) {
        //        return new JsonResult(ex);
        //    }
        //}

        //[HttpGet()]
        //public JsonResult Get(string email) {
        //    try {
        //        var db = D3vzAPI_dbContext.Instance;
        //        var alunos = (from aluno in db.TAlunos
        //                      join user in db.TUsers on aluno.TUserIdUser equals user.IdUser
        //                      join interesses in db.TInteresses on user.IdUser equals interesses.TAlunoTUserIdUser
        //                      where user.DsEmail == email
        //                      select new {
        //                          ID = user.IdUser,
        //                          Nome = user.NmUsuario,
        //                          Email = user.DsEmail,
        //                          CPF = user.NrCpf,
        //                          Nascimento = user.DtNascimento,
        //                          Interesses = interesses
        //                      }).FirstOrDefault();
        //        return new JsonResult(alunos);
        //    } catch (Exception ex) {
        //        return new JsonResult(ex);
        //    }
        //}

        //[HttpPost()]
        //public JsonResult Add(string nm_user, string email, string senha, string cpf, DateTime dt_nasc, string[] interesses) {
        //    try {
        //        if (!Regex.IsMatch(email, "^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$"))
        //            return new JsonResult(new {
        //                Erro = "Endereço de email inválido."
        //            });

        //        var db = D3vzAPI_dbContext.Instance;
        //        var user = new TUser() {
        //            Discriminacao = "aluno",
        //            NmUsuario = nm_user,
        //            DsEmail = email,
        //            DsSenha = senha,
        //            NrCpf = cpf,
        //            DtNascimento = dt_nasc,
        //            TAluno = new TAluno() {
        //                TInteresses = interesses.Select(s => new TInteress() { DsInteresse = s }).ToArray()
        //            }
        //        };
        //        db.TUsers.Add(user);
        //        db.SaveChanges();
        //        return new JsonResult("OK");
        //    } catch (Exception ex) {
        //        return new JsonResult(ex);
        //    }
        //}

        //[HttpPut()]
        //public JsonResult Update(long id, string? nm_user, string? email, string? senha, string? cpf, DateTime? dt_nasc) {
        //    try {
        //        var db = D3vzAPI_dbContext.Instance;
        //        var aluno = db.TAlunos
        //            .Where(a => a.TUserIdUser == id)
        //            .Include(e => e.TUserIdUserNavigation)
        //            .Include(e => e.TInteresses)
        //            .FirstOrDefault();

        //        if (aluno == null)
        //            return new JsonResult(new {
        //                Erro = "Cadastro não encontrado."
        //            });

        //        if (!string.IsNullOrEmpty(nm_user)) aluno.TUserIdUserNavigation.NmUsuario = nm_user;
        //        if (!string.IsNullOrEmpty(email)) aluno.TUserIdUserNavigation.DsEmail = email;
        //        if (!string.IsNullOrEmpty(senha)) aluno.TUserIdUserNavigation.DsSenha = senha;
        //        if (!string.IsNullOrEmpty(cpf)) aluno.TUserIdUserNavigation.NrCpf = cpf;
        //        if (dt_nasc != null) aluno.TUserIdUserNavigation.DtNascimento = dt_nasc.Value;

        //        db.SaveChanges();

        //        return new JsonResult("Ok");
        //    } catch(Exception ex) {
        //        return new JsonResult(ex);
        //    }
        //}

        //[HttpPut()]
        //public JsonResult UpdateInteresses(int id, string[] interesses) {
        //    try {
        //        var db = D3vzAPI_dbContext.Instance;
        //        var i = db.TInteresses.Where(it => it.TAlunoTUserIdUser == id).ToArray();



        //    } catch (Exception ex) {
        //        return new JsonResult(ex);
        //    }
        //}

    }

}
