Console.WriteLine("");

public class DataProvider2
{
    private static DataProvider2 instance;
    public static DataProvider2 Instance
    {
        get
        {
            if (instance is null)
            {
                instance = new DataProvider2();
                return instance;
            }
            else
            {
                return instance;
            }
        }
    }
}