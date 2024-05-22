using ConsultaCNPJ.IntegracaoCNPJ.Api;
using ConsultaCNPJ.DB.Entidades;
using ConsultaCNPJ.IntegracaoCNPJ.Entidades;
using ConsultaCNPJ.Utilitarios;
using ConsultaCNPJ.Repositorio.CNPJ;

namespace ConsultaCNPJ.Negocios.ConsultaCNPJ
{
    public class ConsultaCNPJServico
    {
        #region Propriedades Privadas
        private readonly Api _integracaoCNPJ;
        private readonly CNPJRepositorio _CNPJRepositorio;
        #endregion

        #region Construtores
        public ConsultaCNPJServico()
        {
            _integracaoCNPJ = new Api();
            _CNPJRepositorio = new CNPJRepositorio();
        }
        #endregion

        #region Metodos Publicos
        public PessoaJuridica CadastrarCNPJ(string cnpj)
        {
            cnpj = TextoUtilitarios.RemoverMascaraCNPJ(cnpj);
            var dadosRetorno = _integracaoCNPJ.BuscarCnpj(cnpj);
            var pessoaJuridica = _CNPJRepositorio.BuscarCNPJ(cnpj);

            if (pessoaJuridica != null) _CNPJRepositorio.GravarCNPJ(PopularPessoaJuridicaBanco(pessoaJuridica,dadosRetorno));
            else _CNPJRepositorio.GravarCNPJ(PopularPessoaJuridica(dadosRetorno));

            return PopularPessoaJuridica(dadosRetorno);
        }

        public void AtualizarCNPJ(PessoaJuridica cnpj)
            => _CNPJRepositorio.GravarCNPJ(PopularPessoaJuridicaAtualizar(cnpj));
        

        public List<string> BuscarTodosCNPJ(FiltrosPessoaJuridica filtros)
           => _CNPJRepositorio.BuscarTodosCNPJ(TextoUtilitarios.RemoverMascaraCNPJ(filtros.Cnpj), filtros.FiltroPesquisa).Select(x => x.Cnpj).ToList();
        

        public PessoaJuridica BuscarCNPJ(string cnpj)
           => _CNPJRepositorio.BuscarCNPJ(TextoUtilitarios.RemoverMascaraCNPJ(cnpj));
        

        public void ExcluirCNPJ(string cnpj)
           => _CNPJRepositorio.ExcluirCNPJ(TextoUtilitarios.RemoverMascaraCNPJ(cnpj));
        
        #endregion

        #region Metodos Privados
        private PessoaJuridica PopularPessoaJuridicaAtualizar(PessoaJuridica cnpj)
        {
            var pessoaJuridica = _CNPJRepositorio.BuscarCNPJ(TextoUtilitarios.RemoverMascaraCNPJ(cnpj.Cnpj));
            pessoaJuridica.AtividadePrincipal = TextoUtilitarios.TruncarTexto(pessoaJuridica.AtividadePrincipal, 47);
            pessoaJuridica.Tipo = TextoUtilitarios.TruncarTexto(cnpj.Tipo, 17);
            pessoaJuridica.AtividadePrincipal = TextoUtilitarios.TruncarTexto(cnpj.AtividadePrincipal, 17);
            pessoaJuridica.Nome = TextoUtilitarios.TruncarTexto(cnpj.Nome, 17);
            return pessoaJuridica;
        }


        private PessoaJuridica PopularPessoaJuridicaBanco(PessoaJuridica pessoa, Retorno retorno)
        {
            pessoa.AtividadePrincipal = TextoUtilitarios.TruncarTexto(retorno.AtividadePrincipal.FirstOrDefault().Texto, 47);
            pessoa.DataSituacao = Convert.ToDateTime(retorno.DataSituacao);
            pessoa.Nome = TextoUtilitarios.TruncarTexto(retorno.Nome, 17);
            pessoa.Porte = TextoUtilitarios.TruncarTexto(retorno.Porte, 17);
            pessoa.Tipo = TextoUtilitarios.TruncarTexto(retorno.Tipo, 17);
            pessoa.Cnpj = retorno.Cnpj;
            return pessoa;
        }

        private PessoaJuridica PopularPessoaJuridica(Retorno retorno) => new PessoaJuridica()
        {
            AtividadePrincipal = TextoUtilitarios.TruncarTexto(retorno.AtividadePrincipal.FirstOrDefault().Texto, 47),
            DataSituacao = Convert.ToDateTime(retorno.DataSituacao),
            Nome = TextoUtilitarios.TruncarTexto(retorno.Nome, 17),
            Porte = TextoUtilitarios.TruncarTexto(retorno.Porte, 17),
            Tipo = TextoUtilitarios.TruncarTexto(retorno.Tipo, 17),
            Cnpj = retorno.Cnpj
        };
        #endregion

    }
}
