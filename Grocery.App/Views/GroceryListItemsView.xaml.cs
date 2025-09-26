using Grocery.App.ViewModels;
using Grocery.Core.Models;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
    private GroceryListItemsViewModel _viewModel;
    public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
        _viewModel = viewModel;
    }
    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is GroceryListItem item)
        {
            _viewModel.TogglePurchasedCommand.Execute(item);
        }
    }

}