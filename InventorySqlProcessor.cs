using System.Threading.Tasks;

namespace CorSample
{
    public class InventorySqlProcessor : ChainBase
    {
        public InventorySqlProcessor()
        {
        }
        public override async Task<InventoryItem> ProcessRequestAsync(string itemCode)
        {
            var inventoryItem = new InventoryItem
            {
                Id = 3,
                Name = "Sql Name"
            };

            return inventoryItem;
        }
    }
}