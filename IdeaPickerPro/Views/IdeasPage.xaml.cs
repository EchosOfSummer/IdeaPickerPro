using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPickerPro.Views;

public partial class IdeasPage : ContentPage
{
    public IdeasPage()
    {
        InitializeComponent();
        var tbi = new ToolbarItem { Text = "About" };
        ToolbarItems.Add(tbi);
        tbi.Clicked += async (_, __) =>
        {
            if (Shell.Current.CurrentPage is AboutPage) return;
            await Shell.Current.GoToAsync("AboutPage");
        };
    }


    private void LstIdeas_Stuff(object sender, SelectedItemChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void BtnDelete_OnClicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}