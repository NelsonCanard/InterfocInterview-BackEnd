using ConsultaCNPJ.DB.Entidades.Enumeradores;
using Newtonsoft.Json;

namespace ConsultaCNPJ.DB.Entidades
{
    public class FiltrosPessoaJuridica
    {
        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("filtroPesquisa")]
        public EnumFiltrosPessoaJuridica FiltroPesquisa { get; set; }
       
    }
}
