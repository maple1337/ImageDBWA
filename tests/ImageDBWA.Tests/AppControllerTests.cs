namespace ImageDBWA.Tests;

public class AppControllerTests
{
    [Fact]
    public void Run_ShouldProduceOutputFile()
    {
        var imageService = new ImageService();
        var bridge = new BinaryAudioBridge();
        var audioService = new AudioService();
        var controller = new AppController(imageService, bridge, audioService);

        var effects = new List<IAudioEffect>
        {
            new GainEffect { Gain = 1.5f, Mix = 1.0f }
        };
        
        controller.Run("TestData/input.png", "TestData/output.png", effects);
        
        Assert.True(File.Exists("TestData/output.png"));
    }
}