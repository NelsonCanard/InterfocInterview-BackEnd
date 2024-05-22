using ConsultaCNPJ.DB.Entidades;
using FluentNHibernate.Mapping;

namespace ConsultaCNPJ.DB.Mapeamentos
{
    public class PessoaJuridicaMap : ClassMap<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            Table("PessoaJuridica");
            Id(c => c.IdPessoaJuridica).GeneratedBy.Identity();
            Map(x => x.Tipo);
            Map(a => a.Nome);
            Map(a => a.AtividadePrincipal);
            Map(a => a.DataSituacao);
            Map(a => a.Cnpj);
            Map(a => a.Porte);
        }
    }
}
