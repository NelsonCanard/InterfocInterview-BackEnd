using ConsultaCNPJ.IntegracaoCNPJ.Entidades;
using Newtonsoft.Json;

namespace ConsultaCNPJ.IntegracaoCNPJ.Api
{
    public class Api : ApiBase
    {
        #region Construtores
        public Api() : base("https://receitaws.com.br/v1") { }
        #endregion

        #region Metodos Publicos
        public Retorno BuscarCnpj(string cnpj)
         => JsonConvert.DeserializeObject<Retorno>(ExecutarRequisicao(@$"/cnpj/{cnpj}", RestSharp.Method.Get).Content);

        
        #endregion
    }
}
