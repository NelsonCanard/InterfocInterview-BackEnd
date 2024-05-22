using ConsultaCNPJ.DB.Entidades;
using ConsultaCNPJ.DB.Entidades.Enumeradores;
using ConsultaCNPJ.DB.Repositorio;
using NHibernate.Criterion;
using NHibernate.Id.Insert;

namespace ConsultaCNPJ.Repositorio.CNPJ
{
    public class CNPJRepositorio
    {

        #region Metodos Publicos
        public void GravarCNPJ(PessoaJuridica pessoaJuridica)
        {
            using (RepositorioMetodos RepositorioMetodos = new RepositorioMetodos())
            {
                try
                {
                    RepositorioMetodos.Merge(pessoaJuridica);
                }
                catch
                {
                    throw new NotImplementedException();
                }
                finally
                {
                    RepositorioMetodos.Dispose();
                }
            }
        }

        public PessoaJuridica BuscarCNPJ(string cnpj)
        {
            using (RepositorioMetodos RepositorioMetodos = new RepositorioMetodos())
            {
                try
                {
                    return RepositorioMetodos.Query<PessoaJuridica>().Where(x => x.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "") == cnpj).FirstOrDefault();
                }
                catch
                {
                    throw new NotImplementedException();
                }
                finally
                {
                    RepositorioMetodos.Dispose();
                }
            }
        }

        public List<PessoaJuridica> BuscarTodosCNPJ(string cnpj, EnumFiltrosPessoaJuridica enumFiltrosPessoaJuridica = EnumFiltrosPessoaJuridica.Crescente)
        {
            using (RepositorioMetodos RepositorioMetodos = new RepositorioMetodos())
            {
                try
                {

                    if (cnpj == "")
                    {
                        if (enumFiltrosPessoaJuridica == EnumFiltrosPessoaJuridica.Crescente)
                            return RepositorioMetodos.Query<PessoaJuridica>().OrderBy(y => y.Cnpj).ToList();
                        else if (enumFiltrosPessoaJuridica == EnumFiltrosPessoaJuridica.Decrescente)
                            return RepositorioMetodos.Query<PessoaJuridica>().OrderByDescending(y => y.Cnpj).ToList();
                    }
                    else if (enumFiltrosPessoaJuridica == EnumFiltrosPessoaJuridica.Crescente)
                        return RepositorioMetodos.Query<PessoaJuridica>().Where(x => x.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "").Contains(cnpj)).OrderBy(y => y.Cnpj).ToList();
                    else if (enumFiltrosPessoaJuridica == EnumFiltrosPessoaJuridica.Decrescente)
                        return RepositorioMetodos.Query<PessoaJuridica>().Where(x => x.Cnpj.Replace(".", "").Replace("/", "").Replace("-", "").Contains(cnpj)).OrderByDescending(y => y.Cnpj).ToList();

                    throw new NotImplementedException();

                }
                catch
                {
                    throw new NotImplementedException();
                }
                finally
                {
                    RepositorioMetodos.Dispose();
                }
            }
        }

        public void ExcluirCNPJ(string cnpj)
        {
            using (RepositorioMetodos RepositorioMetodos = new RepositorioMetodos())
            {
                try
                {
                    RepositorioMetodos.Deletar(BuscarCNPJ(cnpj));
                }
                catch
                {
                    throw new NotImplementedException();
                }
                finally
                {
                    RepositorioMetodos.Dispose();
                }
            }
        }

        #endregion
    }
}
