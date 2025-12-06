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
}