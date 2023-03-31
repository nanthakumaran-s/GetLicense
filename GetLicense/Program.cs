public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetLicense("Eric", 2, "Adam Caroline Rebecca Frank"));
        Console.WriteLine(GetLicense("Zebediah", 1, "Bob Jim Becky Pat"));
        Console.WriteLine(GetLicense("Aaron", 3, "Jane Max Olivia Sam"));
    }

    public static int GetLicense(string myself, int noOfAgents, string others)
    {
        List<string> names = others.Split(' ').Append(myself).OrderBy(name => name).ToList();
        Print(names);
        var myIndex = names.IndexOf(myself);
        return ((myIndex / noOfAgents) + 1) * 20;
    }

    public static void Print(List<string> name)
    {
        foreach (var n in name)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}