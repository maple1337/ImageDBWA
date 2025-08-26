namespace ImageDBWA.Core.Interfaces;

public interface IAudioEffect
{
    string Name { get; }
    float[] ProcessAudio(float[] samples);
    float MixLevel { get; set; }
}