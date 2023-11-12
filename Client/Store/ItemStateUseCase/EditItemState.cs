using BlazorAppWasm.Shared;

namespace BlazorAppWasm.Client.Store.ItemStateUseCase
{
    [FeatureState]
    public class EditItemState
    {
        public Item Item { get; } = default!;
        private EditItemState() { }
        public EditItemState(Item item) { Item = item; }
    }
}
