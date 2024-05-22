using ConsultaCNPJ.DB.Entidades;
using ConsultaCNPJ.Negocios.ConsultaCNPJ;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ConsultaCNPJ.Api.Controllers
{
    public class CNPJController : Controller
    {
        [ActionName("CadastrarCNPJ")]
        [HttpGet]
        public PessoaJuridica CadastrarCNPJ(string cnpj)
        {
            try
            {
                return new ConsultaCNPJServico().CadastrarCNPJ(cnpj); 
            }
            catch
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [ActionName("AtualizarCNPJ")]
        [HttpPost]
        public void AtualizarCNPJ([FromBody] PessoaJuridica pessoaJuridica)
        {
            try
            {
                 new ConsultaCNPJServico().AtualizarCNPJ(pessoaJuridica);
            }
            catch
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [ActionName("BuscarTodosCNPJ")]
        [HttpPost]
        public List<string> BuscarTodosCNPJ([FromBody] FiltrosPessoaJuridica pessoaJuridica)
        {
            try
            {
                var teste = new ConsultaCNPJServico().BuscarTodosCNPJ(pessoaJuridica); 
                return new ConsultaCNPJServico().BuscarTodosCNPJ(pessoaJuridica);
            }
            catch
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }


        [ActionName("BuscarCNPJ")]
        [HttpGet]
        public PessoaJuridica BuscarCNPJ(string cnpj)
        {
            try
            {
                return new ConsultaCNPJServico().BuscarCNPJ(cnpj);
            }
            catch
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }


        [ActionName("ExcluirCNPJ")]
        [HttpPost]
        public void ExcluirCNPJ(string cnpj)
        {
            try
            {
                new ConsultaCNPJServico().ExcluirCNPJ(cnpj);
            }
            catch
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
