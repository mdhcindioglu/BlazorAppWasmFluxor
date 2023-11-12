using BlazorAppWasm.Client.Pages;
using BlazorAppWasm.Client.Store.ItemStateUseCase;
using BlazorAppWasm.Client.Store.ListStateUseCase;
using BlazorAppWasm.Shared;

namespace BlazorAppWasm.Client.Store
{
    public static class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncreamentCounterAction(CounterState state, IncreamentCounterAction action)
        {
            return new CounterState(clickCount: state.ClickCount + 1);
        }

        [ReducerMethod]
        public static ListState ReduceFillListAction(ListState state, FillListAction action)
        {
            return new ListState(Item.List);
        }

        [ReducerMethod]
        public static AddItemState ReduceAddItemAction(AddItemState state, AddItemAction action)
        {
            Item.List.Add(action.Item);
            return new AddItemState(action.Item);
        }

        [ReducerMethod]
        public static EditItemState ReduceEditItemAction(EditItemState state, EditItemAction action)
        {
            var item = Item.List.FirstOrDefault(x => x.Id == action.Item.Id);
            if (item != null)
            {
                item.FirstName = action.Item.FirstName;
                item.LastName = action.Item.LastName;
                item.Email = action.Item.Email;
            }
            return new EditItemState(action.Item);
        }

        [ReducerMethod]
        public static DeleteItemState ReduceDeleteItemAction(DeleteItemState state, DeleteItemAction action)
        {
            var item = Item.List.FirstOrDefault(x => x.Id == action.Id);
            if (item != null)
                Item.List.Remove(item);
            
            return new DeleteItemState(action.Id);
        }
    }
}
