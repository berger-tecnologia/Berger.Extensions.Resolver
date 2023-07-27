namespace Berger.Extensions.Resolver
{
    public interface IResolver
    {
        #region Methods
        List<Resolver> Get();
        Resolver Get(Type type, bool mandatory = true);
        #endregion
    }
}