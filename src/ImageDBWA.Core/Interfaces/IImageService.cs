namespace ImageDBWA.Core.Interfaces;

public interface IImageService
{
    byte[] LoadImage(string path);
    void SaveImage(string path, byte[] data, int width, int height, int channels);
    (int width, int height, int channels) GetImageInfo(string path);
}