using System;

namespace Qus18
{
    public class AsyncAwait
    {
        public async Task<int> GetUrlContentLengthAsync(string url)
        {
            Console.WriteLine($"Connecting to {url} and fetching the contents..");
            var client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(url);
            DoIndependentWork();
            string contents = await getStringTask;
            Console.WriteLine("Fetching completed !");
            return contents.Length;

        }
        void DoIndependentWork()
        {
            Console.WriteLine("Working..");
            Console.WriteLine("Completed.");
        }
        static void Main(string[] args)
        {
            AsyncAwait ap = new AsyncAwait();
            Task<int> result = ap.GetUrlContentLengthAsync("https://youtube.com/");
            Console.WriteLine("Length of the contents : {0}", result.Result);
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}

