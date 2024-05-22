using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCNPJ.IntegracaoCNPJ.Entidades
{
    public class Retorno
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ultima_atualizacao")]
        public string UltimaAtualizacao { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("porte")]
        public string Porte { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("fantasia")]
        public string Fantasia { get; set; }

        [JsonProperty("abertura")]
        public string Abertura { get; set; }

        [JsonProperty("atividade_principal")]
        public List<AtividadePrincipal> AtividadePrincipal { get; set; }

        [JsonProperty("atividades_secundarias")]
        public List<AtividadesSecundaria> AtividadesSecundarias { get; set; }

        [JsonProperty("natureza_juridica")]
        public string NaturezaJuridica { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }

        [JsonProperty("efr")]
        public string Efr { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_situacao")]
        public string DataSituacao { get; set; }

        [JsonProperty("motivo_situacao")]
        public string MotivoSituacao { get; set; }

        [JsonProperty("situacao_especial")]
        public string SituacaoEspecial { get; set; }

        [JsonProperty("data_situacao_especial")]
        public string DataSituacaoEspecial { get; set; }

        [JsonProperty("capital_social")]
        public string CapitalSocial { get; set; }

        [JsonProperty("qsa")]
        public List<Qsa> qsa { get; set; }

        [JsonProperty("billing")]
        public Cobranca Cobranca { get; set; }
    }
}
