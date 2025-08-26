namespace ImageDBWA.Core.Interfaces;

public interface IBinaryAudioBridge
{
    float[] BytesToSamples(byte[] bytes);
    byte[] SamplesToBytes(float[] samples, int width, int height, int channels);
}