using Newtonsoft.Json;


namespace ConsultaCNPJ.DB.Entidades
{
    public class PessoaJuridica
    {
        [JsonProperty("idPessoaJuridica")]
        public virtual int IdPessoaJuridica { get; protected set; }

        [JsonProperty("tipo")]
        public virtual string Tipo { get; set; }

        [JsonProperty("nome")]
        public virtual string Nome { get; set; }

        [JsonProperty("porte")]
        public virtual string Porte { get; set; }

        [JsonProperty("dataSituacao")]
        public virtual DateTime DataSituacao { get; set; }

        [JsonProperty("cnpj")]
        public virtual string Cnpj { get; set; }

        [JsonProperty("atividadePrincipal")]
        public virtual string AtividadePrincipal { get; set; }
    }
}
