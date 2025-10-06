namespace Iterator;

public class Handler {
    public static void Handle() {
        Playlist playlist = new Playlist();
        playlist.AddSong("Song 1");
        playlist.AddSong("Song 2");
        playlist.AddSong("Song 3");

        IIterator iterator = playlist.GetIterator("simple");

        Console.WriteLine("Playlist Songs:");
        while (iterator.HasNext()) {
            Console.WriteLine(iterator.Next());
        }
    }
}