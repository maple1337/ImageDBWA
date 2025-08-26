namespace ImageDBWA.Core.Interfaces;

public interface IAudioService
{
    void AddEffect(IAudioEffect effect);
    void ClearEffects();
    float[] ApplyEffects(float[] samples);
    void SaveAsWav(float[] samples, string path, int sampleRate);
}