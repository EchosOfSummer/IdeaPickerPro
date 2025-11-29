using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaPickerPro.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void About(object sender, EventArgs e)
    {
        if (Shell.Current.CurrentPage is AboutPage) return;
        await Shell.Current.GoToAsync("AboutPage");
    }
}