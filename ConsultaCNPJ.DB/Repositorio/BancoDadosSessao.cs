using ConsultaCNPJ.Utilitarios.Entidades;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Dialect;

namespace ConsultaCNPJ.DB.Repositorio
{
    public class BancoDadosSessao
    {

        private ISessionFactory _sessao;

        public ISessionFactory Sessao
        {
            get { return _sessao ?? (_sessao = CriarSessao()); }
        }

        private string BuscarConnectionString()
         => JsonConvert.DeserializeObject<ConfiguracaoBanco>(File.ReadAllText("C:\\Users\\Nelso\\source\\repos\\ConsultaCnpjApi\\ConsultaCNPJ.Api\\appsettings.json")).BancoDadosConexao;


        private ISessionFactory CriarSessao()
         => Fluently.Configure()
              .Database(
                PostgreSQLConfiguration.Standard.ConnectionString(BuscarConnectionString())
              .Dialect<PostgreSQL83Dialect>)
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<BancoDadosSessao>())
              .BuildSessionFactory();
        
    }
}
