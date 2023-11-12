namespace BlazorAppWasm.Client.Store
{
    public class DeleteItemAction
    {
        public DeleteItemAction(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
