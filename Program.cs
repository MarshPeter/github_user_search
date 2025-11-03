using System.Reflection;

namespace GithubUserSearchCLI;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            var versionString = Assembly.GetEntryAssembly()?
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion
                .ToString() ?? "";

            if (string.IsNullOrEmpty(versionString))
            {
                Console.WriteLine("Program started outside of CLI, closing program");
                return;
            }

            Console.WriteLine($"Github User Search v{versionString}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\nUsage:");
            Console.WriteLine("  github-activity <username>");

            return;
        }

        ShowUsername(string.Join(" ", args));
    }

    static void ShowUsername(string username)
    {
        string message = $"Here is the username: {username}";

        Console.WriteLine(message);
    }
}
