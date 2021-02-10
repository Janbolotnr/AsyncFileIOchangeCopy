using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncFileIOiz
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var from = "life.txt";
            var to = "october.txt";

            using (FileStream source = File.Open(from, FileMode.Open))
            {
                using (FileStream target = File.Open(to, FileMode.Open))
                {
                    await source.CopyToAsync(target);
                }
            }
        }
    }
}


/* var file = File.OpenText("life.txt");

            for (var i = 0; i < 3; i++)
            {
                var line = await file.ReadLineAsync();
                Console.WriteLine($"line {i + 1}: {line}");
            }*/
