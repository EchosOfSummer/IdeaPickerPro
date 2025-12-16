namespace IdeaPickerPro.Models;

public static class Glitch
{
    public static async void StartGlitch(BoxView layer1, BoxView layer2, BoxView layer3, BoxView layer4)
    {
        var rand = new Random();

        while (true)
        {
            var layers = new[] { layer1, layer2, layer3, layer4 };
            
            foreach (var layer in layers)
            {
                // quick flash effect
                layer.Opacity = rand.NextDouble() * 0.8;
                await Task.Delay(rand.Next(50, 200));
                layer.Opacity = 0;
            }

            await Task.Delay(rand.Next(100, 800));
        }
    }

    public static async void StartNew()
    {
        var colors = new[]
        {
            "#FF006E","#8e2de2","#4a0080","#00d2ff","#ff0080",
            "#7928ca","#fa709a","#fdbb2d","#ff416c","#667eea",
            "#764ba2","#f093fb","#4facfe","#00f2fe","#fa709a",
            "#fee140","#43e97b","#38f9d7","#5ee7df","#66a6ff"
        };
        var random = new Random();

        while (true)
        {
            var topColor = Color.FromArgb(colors[random.Next(colors.Length)]);
            Shell.Current.BackgroundColor = topColor;

            await Task.Delay(random.Next(800, 1500));
            
            var bottomColor = Color.FromArgb(colors[random.Next(colors.Length)]);
            Shell.Current.BackgroundColor = bottomColor;
            
            await Task.Delay(random.Next(800, 1500));
        }
    }
}