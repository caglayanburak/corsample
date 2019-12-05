using System.Threading.Tasks;

namespace CorSample
{
    public abstract class ChainBase
    {
        protected ChainBase Successor;

        public void SetProcessor(ChainBase successor)
        {
            this.Successor = successor;
        }

        public abstract Task<InventoryItem> ProcessRequestAsync(string code);
    }
}