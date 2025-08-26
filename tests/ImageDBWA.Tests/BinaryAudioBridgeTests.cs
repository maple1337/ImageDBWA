using ImageDBWA.Core.Interfaces;

namespace ImageDBWA.Tests;

public class BinaryAudioBridgeTests
{
    private readonly IBinaryAudioBridge _bridge = new BinaryAudioBridge();

    [Fact]
    public void BytesToSamples_ThenBack_ShouldPreserveLength()
    {
        var original = new byte[] { 0, 127, 255 };
        var samples = _bridge.BytesToSamples(original);
        var result = _bridge.SamplesToBytes(samples, 1, 3, 1);
        
        Assert.Equal(original.Length, result.Length);
    }
}