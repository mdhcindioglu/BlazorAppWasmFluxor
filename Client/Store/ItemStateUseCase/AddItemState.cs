using BlazorAppWasm.Shared;

namespace BlazorAppWasm.Client.Store.ItemStateUseCase
{
    [FeatureState]
    public class AddItemState
    {
        public Item Item { get; } = default!;
        private AddItemState() { }
        public AddItemState(Item item) { Item = item; }
    }
}
