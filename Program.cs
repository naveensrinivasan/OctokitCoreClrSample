using System;

namespace Octokit.CoreClr.Sample
{
    public class Program
    {
        public void Main(string[] args)
        {
            var client = new GitHubClient(new ProductHeaderValue("coreclr"));
            var result = client.User.Get("naveensrinivasan").Result;
            Console.WriteLine(result.Name);
            Console.WriteLine(result.HtmlUrl);
        }
    }
}
