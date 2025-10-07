namespace Bridge;

public class Handler {
    public static void Handle() {
        Renderer vectorRenderer = new VectorRenderer();
        Renderer rasterRenderer = new RasterRenderer();

        Shape circle = new Circle(5, vectorRenderer);
        Shape square = new Square(4, rasterRenderer);

        circle.Draw();
        square.Draw();
    }
}