namespace ImageDBWA.Core.Interfaces;

public interface IAudioEffectChain
{
    void AddEffect(IAudioEffect effect);
    void RemoveEffect(string name);
    float[] Process(float[] input);
    IReadOnlyList<IAudioEffect> Effects { get; }    
}