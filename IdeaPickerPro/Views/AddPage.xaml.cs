using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerPro.Models;

namespace IdeaPickerPro.Views;

public partial class AddPage : ContentPage
{
    private readonly Repository _repository;
    public AddPage()
    {
        InitializeComponent();
        _repository = new Repository();
        
        var tbi = new ToolbarItem { Text = "About" };
        ToolbarItems.Add(tbi);
        tbi.Clicked += async (_, __) =>
        {
            if (Shell.Current.CurrentPage is AboutPage) return;
            await Shell.Current.GoToAsync("AboutPage");
        };
    }

    private async void BtnSave_OnClicked(object sender, EventArgs e)
    {
        var newIdea = new Idea();

        if (!string.IsNullOrEmpty(txtIdea.Text))
        {
            newIdea._Text = txtIdea.Text;
            
            _repository.SaveIdea(newIdea);

            await DisplayAlert("Success", "Idea saved!", "OK");
            txtIdea.Text = "";
        }
        else
        {
            await DisplayAlert("Error", "Please enter an idea!", "OK");
        }
    }

    private void BtnClear_OnClicked(object sender, EventArgs e)
    {
        txtIdea.Text = "";
    }
}