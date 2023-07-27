namespace Berger.Extensions.Resolver
{
    public class Resolver
    {
        #region Constructors
        public Resolver(Type type, Type destination, string policy)
        {
            Type = type;
            Policy = policy;
            Destination = destination;
            ResolverType = ResolverType.GraphQL;
            OperationType = OperationType.Query;
        }
        public Resolver(Type type, Type input, Type destination, Type validator, string policy)
        {
            Type = type;
            Input = input;
            Policy = policy;
            Validator = validator;
            Destination = destination;
            ResolverType = ResolverType.GraphQL;
            OperationType = OperationType.Mutation;
        }
        #endregion

        #region Properties
        public ResolverType ResolverType { get; private set; }
        public OperationType OperationType { get; private set; }
        public Type Type { get; private set; }
        public Type Input { get; private set; }
        public Type Destination { get; private set; }
        public Type Validator { get; private set; }
        public string Policy { get; private set; }
        public List<string> Items { get; private set; } = new List<string>();
        #endregion

        #region Methods
        public void SetResolverType(ResolverType resolverType)
        {
            ResolverType = resolverType;
        }
        public void SetOperationType(OperationType operationType)
        {
            OperationType = operationType;
        }
        public void SetType(Type type)
        {
            Type = type;
        }
        public void SetInput(Type input)
        {
            Input = input;
        }
        public void SetDestination(Type destination)
        {
            Destination = destination;
        }
        public void SetValidator(Type validator)
        {
            Validator = validator;
        }
        public void SetPolicy(string policy)
        {
            Policy = policy;
        }
        public void AddItem(string item)
        {
            Items.Add(item);
        }
        public void AddItens(List<string> itens)
        {
            Items.AddRange(itens);
        }
        #endregion
    }
}