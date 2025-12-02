using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerPro.Models;

namespace IdeaPickerPro.Views;

public partial class IdeasPage : ContentPage
{
    private readonly Repository _repository;
    private Idea _selectedIdea;
    public IdeasPage()
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

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadIdeas();
    }

    private void LoadIdeas()
    {
        var ideas = _repository.GetIdeas();
        lstIdeas.ItemsSource = ideas;
    }


    private void LstIdeas_List(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            _selectedIdea = (Idea)e.SelectedItem;
        }
    }

    private async void BtnDelete_OnClicked(object sender, EventArgs e)
    {
        if (_selectedIdea == null)
        {
            await DisplayAlert("Error", "Please select an idea first!", "OK");
            return;
        }

        bool confirm = await DisplayAlert("Delete", $"Delete '{_selectedIdea._Text}'?", "Yes", "No");

        if (confirm)
        {
            _repository.DeleteIdea(_selectedIdea.ID);
            _selectedIdea = null;
            LoadIdeas();
        }
    }
}