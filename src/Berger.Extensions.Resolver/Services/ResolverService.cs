namespace Berger.Extensions.Resolver
{
    public class ResolverService : IResolver
    {
        #region Properties
        public List<Resolver> Resolvers = new List<Resolver>();
        #endregion

        #region Methods
        public List<Resolver> Get()
        {
            return Resolvers;
        }
        public Resolver Get(Type type, bool mandatory = true)
        {
            var resolvers = Get()
                .Where(e => e.Type == type)
                .FirstOrDefault();

            if (mandatory && resolvers.Equals(default(Resolver)))
                throw new Exception($"The resolver configuration for the type {type.GetType()} was not found.");

            return resolvers;
        }
        #endregion
    }
}