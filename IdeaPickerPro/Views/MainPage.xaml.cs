using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerPro.Models;

namespace IdeaPickerPro.Views;

public partial class MainPage : ContentPage
{
    private readonly Repository _repository;
    public MainPage()
    {
        InitializeComponent();
        _repository = new Repository();
        Glitch.StartGlitch(Layer1,Layer2,Layer3,Layer4);
        //Glitch.StartNew();
    }

    // private async void About(object sender, EventArgs e)
    // {
    //     if (Shell.Current.CurrentPage is AboutPage) return;
    //     await Shell.Current.GoToAsync("AboutPage");
    //     
    //     // Device.BeginInvokeOnMainThread(async () =>
    //     // {
    //     //     await Task.Delay(200);
    //     //     Glitch.StartNew();
    //     // });
    // }

    private void btnRandomIdea(object sender, EventArgs e)
    {
        var ideas = _repository.GetIdeas();

        if (ideas.Count == 0)
        {
            lblRandIdea.Text = "No ideas yet! Add some first";
            return;
        }

        var random = new Random();
        var randomIdea = ideas[random.Next(ideas.Count)];

        lblRandIdea.Text = $"{randomIdea._Text}";
    }
}