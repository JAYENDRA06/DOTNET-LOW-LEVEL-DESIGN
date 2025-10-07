namespace Iterator;

// THEORY: allows easy traversal of a collection of objects without exposing the underlying representation.

public interface IIterator {
    bool HasNext();
    string Next();
}

public class SimplePlaylistIterator : IIterator {
    private Playlist playlist;
    private int position = 0;

    public SimplePlaylistIterator(Playlist playlist) {
        this.playlist = playlist;
    }

    public bool HasNext() {
        return position < playlist.GetSongs().Count;
    }

    public string Next() {
        if (!HasNext()) throw new InvalidOperationException("No more songs in the playlist.");
        return playlist.GetSongs()[position++];
    }
}

public class Playlist {
    private List<string> songs = new List<string>();

    public void AddSong(string song) {
        songs.Add(song);
    }

    public List<string> GetSongs() {
        return songs;
    }

    public IIterator GetIterator(string type) {
        switch (type.ToLower()) {
            case "simple":
                return new SimplePlaylistIterator(this);
            // Future iterator types can be added here
            default:
                throw new ArgumentException("Unknown iterator type");
        }
    }
}