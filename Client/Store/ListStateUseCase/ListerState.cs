using BlazorAppWasm.Shared;

namespace BlazorAppWasm.Client.Store.ListStateUseCase
{
    [FeatureState]
    public class ListState
    {
        public List<Item> ListItems { get; } = default!;
        private ListState() { }
        public ListState(List<Item> listItems) { ListItems = listItems; }
    }
}
