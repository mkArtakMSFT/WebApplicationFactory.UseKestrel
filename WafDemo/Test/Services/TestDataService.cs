namespace Test.Services;

internal class TestDataService : IDataService
{
    public static readonly string TestData = "Test information";

    public string GetData() => TestData;
}
