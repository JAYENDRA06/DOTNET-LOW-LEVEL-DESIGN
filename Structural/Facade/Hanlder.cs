namespace Facade;

public class Handler {
    public static void Handle () {
        MediaFacade mediaFacade = new MediaFacade();
        mediaFacade.PerformAction("PlayMusic");
        mediaFacade.PerformAction("PlayVideo");
        mediaFacade.PerformAction("InvalidAction");
    }
}