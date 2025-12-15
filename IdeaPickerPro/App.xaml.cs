using IdeaPickerPro.Views;
using IdeaPickerPro.Models;

namespace IdeaPickerPro;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var shell = new Shell
        {
            Items =
            {
                new TabBar
                {
                    Items =
                    {
                        new Tab
                        {
                            Title = "Welcome",
                            Icon = "",
                            Items =
                            {
                                new ShellContent()
                                {
                                    Route = "MainPage",
                                    ContentTemplate = new DataTemplate(() => new MainPage())
                                }
                            }
                        },
                        new Tab
                        {
                            Title = "Add An Idea",
                            Icon = "",
                            Items =
                            {
                                new ShellContent()
                                {
                                    Route = "AddPage",
                                    ContentTemplate = new DataTemplate(() => new AddPage())
                                }
                            }
                        },
                        new Tab
                        {
                            Title = "Ideas",
                            Icon = "",
                            Items =
                            {
                                new ShellContent()
                                {
                                    Route = "IdeasPage",
                                    ContentTemplate = new DataTemplate(() => new IdeasPage())
                                }}}
                    }
                }
            }
        };
        Routing.RegisterRoute("AboutPage", typeof(AboutPage));
        MainPage = shell;
        //Glitch.StartNew();
    }
}