using RestSharp;

namespace ConsultaCNPJ.IntegracaoCNPJ.Api
{
    public class ApiBase
    {
        #region Propriedades Privadas
        private readonly RestClient _rest;
        #endregion

        #region Construtores
        public ApiBase(string urlApi)
        {
            _rest = new RestClient(urlApi);
        }
        #endregion

        #region Metodos Publicos
        public RestResponse ExecutarRequisicao(string caminho,Method metodo) 
            => _rest.Execute(new RestRequest(caminho, metodo)); 
        #endregion

    }
}
