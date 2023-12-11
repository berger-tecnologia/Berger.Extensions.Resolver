using Microsoft.Extensions.Configuration;

namespace Berger.Extensions.Resolver
{
    public class ResolverService : IResolverService
    {
        #region Properties
        private readonly IConfiguration _configuration;
        
        public List<Resolver> Resolvers = new List<Resolver>();
        #endregion

        #region Constructors
        public ResolverService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ResolverService()
        {
        }
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
        public string Resolve(string name)
        {
            string path = _configuration[$"Views:{name}"];

            return !string.IsNullOrEmpty(path) ? path : name;
        }
        #endregion
    }
}