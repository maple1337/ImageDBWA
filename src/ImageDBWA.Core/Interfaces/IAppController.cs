namespace ImageDBWA.Core.Interfaces;

public interface IAppController
{
    /// <summary>
    /// Runs the full pipeline:
    /// 1. Load image
    /// 2. Convert image bytes -> audio samples
    /// 3. Apply effects
    /// 4. Convert samples -> image bytes
    /// 5. Save output image
    /// </summary>
    /// <param name="inputPath">Path to input image file</param>
    /// <param name="outputPath">Path to save processed image file</param>
    /// <param name="effects">List of effects to apply in serial</param>
    void Run(string inputPath, string outputPath, IEnumerable<IAudioEffect> effects);
}