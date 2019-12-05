using System.Threading.Tasks;

namespace CorSample
{
    public class InventoryElasticProcessor : ChainBase
    {
        public InventoryElasticProcessor()
        {
        }

        public override async Task<InventoryItem> ProcessRequestAsync(string itemCode)
        {
            bool isAvailable = false; //client.Ping();
            if (isAvailable)
            {
                return new InventoryItem
                {
                    Id = 1,
                    Name = "Elastic"
                };
            }

            return await Successor.ProcessRequestAsync(itemCode);
        }
    }
}