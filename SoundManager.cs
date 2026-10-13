using System.Media;
using System.IO;

public static class SoundManager
{
    public static void Play(string path)
    {
        if (File.Exists(path))
        {
            SoundPlayer player = new SoundPlayer(path);
            player.Play();
        }
    }
}
