
public class TestDataService : IDataService
{
    public static readonly string[] TestData = ["test one", "test two", "test three"];

    public string[] GetData() => TestData;
}
