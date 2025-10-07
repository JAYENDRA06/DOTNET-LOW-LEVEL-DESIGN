namespace Facade;

// THEORY: provides a unified interface to a set of interfaces in a subsystem.

public class MusicPlayer {
    public void InitializeAudioDriver() {
        Console.WriteLine("Audio driver initialized.");
    }
    public void DecodeAudio() {
        Console.WriteLine("Audio decoded.");
    }
    public void PlayAudio() {
        Console.WriteLine("Playing audio.");
    }
}

public class VideoPlayer {
    public void InitializeVideoDriver() {
        Console.WriteLine("Video driver initialized.");
    }
    public void DecodeVideo() {
        Console.WriteLine("Video decoded.");
    }
    public void PlayVideo() {
        Console.WriteLine("Playing video.");
    }
}
public class MediaFacade {
    private MusicPlayer musicPlayer;
    private VideoPlayer videoPlayer;

    public MediaFacade() {
        musicPlayer = new MusicPlayer();
        videoPlayer = new VideoPlayer();
    }

    public void PerformAction(string actionType) {
        if (actionType == "PlayMusic") {
            musicPlayer.InitializeAudioDriver();
            musicPlayer.DecodeAudio();
            musicPlayer.PlayAudio();
        } else if (actionType == "PlayVideo") {
            videoPlayer.InitializeVideoDriver();
            videoPlayer.DecodeVideo();
            videoPlayer.PlayVideo();
        } else {
            Console.WriteLine("Invalid action type.");
        }
    }
}