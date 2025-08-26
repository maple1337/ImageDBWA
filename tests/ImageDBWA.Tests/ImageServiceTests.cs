using ImageDBWA.Core.Interfaces;

namespace ImageDBWA.Tests;

public class ImageServiceTests
{
    private readonly IImageService _imageService = new ImageService();
    [Fact]
    public void LoadImage_ShouldReturnNonEmptyBytes()
    {
        var bytes = _imageService.LoadImage("TestData/input.png");
        Assert.NotNull(bytes);
        Assert.NotEmpty(bytes);
    }

    [Fact]
    public void LoadImage_ShouldWriteFile()
    {
        var bytes = _imageService.LoadImage("TestData/input.png");
        _imageService.SaveImage("TestData/output.png", bytes, 64, 64, 3);
        
        Assert.True(File.Exists("TestData/output.png"));
    }
}