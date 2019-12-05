using System;

namespace CorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ChainBase elastic = new InventoryElasticProcessor();
            ChainBase sql = new InventorySqlProcessor();

            elastic.SetProcessor(sql);
            var inventoryItem =  elastic.ProcessRequestAsync("code").Result;

            Console.WriteLine(inventoryItem.Name);

        }
    }
}
