using BlazorAppWasm.Shared;

namespace BlazorAppWasm.Client.Store.ItemStateUseCase
{
    [FeatureState]
    public class DeleteItemState
    {
        public int Id { get; } = default!;
        private DeleteItemState() { }
        public DeleteItemState(int id) { Id = id; }
    }
}
