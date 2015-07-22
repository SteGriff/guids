using System;

namespace guids
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 1;
            if (args.Length > 0 && !String.IsNullOrWhiteSpace(args[0]))
            {
                Int32.TryParse(args[0], out quantity);
            }

            for(int i = 0; i < quantity; i++)
            {
                Guid newGuid = Guid.NewGuid();
                Console.WriteLine(newGuid);
            }
        }
    }
}
