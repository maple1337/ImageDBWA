using ImageDBWA.Core.Interfaces;

namespace ImageDBWA.Tests;

public class AudioServiceTests
{
    private readonly IAudioService _service = new AudioService();
    [Fact]
    public void ApplyEffects_WithGainEffect_ShouldChangeSamples()
    {
        _service.AddEffect(new GainEffect { Gain = 2.0f, Mix = 1.0f });

        float[] input = { 0.1f, 0.2f, -0.1f };
        var output = _service.ApplyEffects(input);

        Assert.Equal(input, output);
    }
}