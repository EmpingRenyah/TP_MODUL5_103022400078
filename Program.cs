


public class HaloGeneric
{
    public static void SapaUser(string name)
    {
        Console.WriteLine("Hello, User " + name);
    }

    public static void Main(string[] args)
    {
        SapaUser("Vincent");
        DataGeneric<long> data = new DataGeneric<long>(103022400078);
        data.PrintData();
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}