namespace ConsultaCNPJ.DB.Repositorio
{
    public interface IRepositorio
    {
        void Salvar(object obj);
        void Deletar(object obj);
        object GetById(Type objType, object objId);
        IQueryable<TEntity> ToList<TEntity>();
    }
}
