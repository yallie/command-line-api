namespace System.CommandLine.Tests.SampleDotNetCli
{
    public class CommandLineParser
    {
        internal static void Invoke<TRootCommand>(string[] args) where TRootCommand: new()
        {
            // Populate the command hierarchy.
            // Configure parser/Invokations
            // Call Invoke with parseresult
        }
    }
}