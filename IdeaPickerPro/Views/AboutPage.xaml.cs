using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdeaPickerPro.Models;

namespace IdeaPickerPro.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        Glitch.StartGlitch(Layer1,Layer2,Layer3,Layer4);
        Title = "About";
    }
}

