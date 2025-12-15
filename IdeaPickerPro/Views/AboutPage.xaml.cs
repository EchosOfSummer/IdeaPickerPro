using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerPro.Models;
//using Color = System.Drawing.Color;

// using Color = System.Drawing.Color;

namespace IdeaPickerPro.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        Glitch.StartGlitch(Layer1,Layer2,Layer3,Layer4);
        
        Shell.SetBackgroundColor(this, Color.FromArgb("#8e2de2"));
        // Shell.Current.BackgroundColor = Color.FromArgb("#4a0080");
        
        // System.Diagnostics.Debug.WriteLine($"Current Shell: {Shell.Current}");
        // System.Diagnostics.Debug.WriteLine($"Shell Background: {Shell.Current.BackgroundColor}");
        //
        // Shell.Current.BackgroundColor = Color.FromArgb("#ff006e");
        Shell.SetTabBarBackgroundColor(Shell.Current, Colors.Green);
        
        // Glitch.StartNew();
        
        Title = "About";
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Shell.SetBackgroundColor(this, Colors. Transparent);
    }
}

