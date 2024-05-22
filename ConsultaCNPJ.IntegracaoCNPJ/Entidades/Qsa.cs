using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCNPJ.IntegracaoCNPJ.Entidades
{
    public class Qsa
    {

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("qual")]
        public string Qual { get; set; }

        [JsonProperty("pais_origem")]
        public string PaisOrigem { get; set; }

        [JsonProperty("nome_rep_legal")]
        public string RepresentanteLegal { get; set; }

        [JsonProperty("qual_rep_legal")]
        public string QualRepresentateLegal { get; set; }
    }
}
