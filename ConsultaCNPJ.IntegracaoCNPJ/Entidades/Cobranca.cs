using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCNPJ.IntegracaoCNPJ.Entidades
{
    public class Cobranca
    {
        [JsonProperty("free")]
        public bool Livre { get; set; }

        [JsonProperty("database")]
        public bool DataBase { get; set; }
    }
}
