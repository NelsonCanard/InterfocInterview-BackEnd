using NHibernate;

namespace ConsultaCNPJ.DB.Repositorio
{
    public class RepositorioMetodos : IRepositorio, IDisposable
    {
        protected ISession _sessao = null;
        protected ITransaction transacao = null;

        public RepositorioMetodos()
        {
            _sessao = new BancoDadosSessao().Sessao.OpenSession();
        }

        public RepositorioMetodos(ISession session)
        {
            _sessao = session;
        }

        #region Metodos Publicos 

        public void AbrirTransacao()
        {
            transacao = _sessao.BeginTransaction();
        }

        public void CommitTransacao()
        {
            transacao.Commit();

            FecharTransacao();
        }

        public void RollbackTransacao()
        {
            transacao.Rollback();

            FecharTransacao();
            FecharSessao();
        }

        private void FecharTransacao()
        {
            transacao.Dispose();
            transacao = null;
        }

        private void FecharSessao()
        {
            _sessao.Close();
            _sessao.Dispose();
            _sessao = null;
        }

        public virtual void Salvar(object obj)
        {
            _sessao.SaveOrUpdate(obj);
        }

        public virtual IQueryable<T> Query<T>()
        {
            return _sessao.Query<T>();
        }

        public virtual void Merge(object obj)
        {
            _sessao.Merge(obj);
        }

        public virtual void Deletar(object obj)
        {
            _sessao.Delete(obj);
        }

        public virtual object GetById(Type objType, object objId)
        {
            return _sessao.Load(objType, objId);
        }

        public virtual IQueryable<TEntity> ToList<TEntity>()
        {
            return (from entity in _sessao.Query<TEntity>() select entity);
        }

        #endregion

        #region Metodos Dispose

        public void Dispose()
        {
            if (transacao != null)
            {
                CommitTransacao();
            }

            if (_sessao != null)
            {
                _sessao.Flush();
                FecharSessao();
            }
        }

        #endregion
    }
}
