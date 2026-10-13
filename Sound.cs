using System.Media;

public class SoundManager
{
    public static void Play(string file)
    {
        SoundPlayer player = new SoundPlayer(file);
        player.Play();
    }
}
