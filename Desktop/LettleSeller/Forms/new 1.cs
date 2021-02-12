public class SQLiteProviderInvariantName : IProviderInvariantName
{
    public static readonly SQLiteProviderInvariantName Instance = new SQLiteProviderInvariantName();
    private SQLiteProviderInvariantName() { }
 
    public string Name { get { return ProviderName; } }
}

class SQLiteDbDependencyResolver : IDbDependencyResolver
{
    public object GetService(Type type, object key)
    {
        if (type == typeof(IProviderInvariantName)) return SQLiteProviderInvariantName.Instance;
        if (type == typeof(DbProviderFactory)) return SQLiteProviderFactory.Instance;
        return SQLiteProviderFactory.Instance.GetService(type);
    }

    public IEnumerable<object> GetServices(Type type, object key)
    {
        var service = GetService(type, key);
        if (service != null) yield return service;
    }
}

class SQLiteDbConfiguration : DbConfiguration
{
    public SQLiteDbConfiguration()
    {
        AddDependencyResolver(new SQLiteDbDependencyResolver());
    }
}

==========================================
var context = new MyContext("Data Source = mytest.db; Version = 3;");
var entities = context.MyEntities.ToList();

==========================================

Update: For NET4.0 you would also need a custom IDbProviderFactoryResolver:

class SQLiteDbProviderFactoryResolver : IDbProviderFactoryResolver
{
    public static readonly SQLiteDbProviderFactoryResolver Instance = new SQLiteDbProviderFactoryResolver();
    private SQLiteDbProviderFactoryResolver() { }
    public DbProviderFactory ResolveProviderFactory(DbConnection connection)
    {
        if (connection is SQLiteConnection) return SQLiteProviderFactory.Instance;
        if (connection is EntityConnection) return EntityProviderFactory.Instance;
        return null;
    }
}

and add

if (type == typeof(IDbProviderFactoryResolver)) return SQLiteDbProviderFactoryResolver.Instance;

to the SQLiteDbDependencyResolver.GetService method implementation.