
// kod sayısını düşürme


public class DataProvider
{
    private static DataProvider instance;
    public static DataProvider Instance => instance ?? (instance = new DataProvider());
}
