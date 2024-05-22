using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCNPJ.IntegracaoCNPJ.Entidades
{
    public class AtividadePrincipal
    {
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [JsonProperty("text")]
        public string Texto { get; set; }
    }
}
