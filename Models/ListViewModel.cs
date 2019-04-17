using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using FinalApp;
using System.Linq;
using Xamarin.Forms;

namespace FinalApp
{
    public class ListViewModel : Models.BaseFodyObservable
    {
        GroupedList = GetGroupedList();
        Delete = new Command<Item>(HandleDelete);
        ChangeIsCompleted = new Command<Item>(HandleChangeIsCompleted);

    }

    public ILookup<string, Item> GroupedList { get; set; }
    public string Title => "My  list";

    private List<Item> List = new List<Item>
        {
            new Item { Id = 0, Title = "Create First ", IsCompleted = true},
            new Item { Id = 1, Title = "Run a Marathon"},
            new Item { Id = 2, Title = "Create XamarinForms blog post"},
        };

    private ILookup<string, Item> GetGroupedList()
    {
        return List.OrderBy(t => t.IsCompleted)
                        .ToLookup(t => t.IsCompleted ? "Completed" : "Active");
    }
    public Command<Item> Delete { get; set; }
    public void HandleDelete(Item itemToDelete)
    {
        List.Remove(itemToDelete);
        GroupedList = GetGroupedList();
    }
    public Command<Item> ChangeIsCompleted { get; set; }
    public void HandleChangeIsCompleted(Item itemToUpdate)
    {
        itemToUpdate.IsCompleted = !itemToUpdate.IsCompleted;
        GroupedList = GetGroupedList();
    }
}

