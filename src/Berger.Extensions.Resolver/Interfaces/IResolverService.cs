namespace Berger.Extensions.Resolver
{
    public interface IResolverService
    {
        #region Methods
        string Resolve(string name);
        List<Resolver> Get();
        Resolver Get(Type type, bool mandatory = true);
        #endregion
    }
}