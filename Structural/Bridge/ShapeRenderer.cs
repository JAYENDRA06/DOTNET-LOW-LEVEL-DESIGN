namespace Bridge;

// separates abstraction(shape) from implementation(rendering method) so that the two can evolve independently.

public interface Renderer {
    void RenderCircle(float radius);
    void RenderSquare(float side);
}

public class VectorRenderer : Renderer {
    public void RenderCircle(float radius) {
        System.Console.WriteLine($"Drawing a circle of radius {radius} using vector graphics.");
    }

    public void RenderSquare(float side) {
        System.Console.WriteLine($"Drawing a square of side {side} using vector graphics.");
    }
}

public class RasterRenderer : Renderer {
    public void RenderCircle(float radius) {
        System.Console.WriteLine($"Drawing a circle of radius {radius} using raster graphics.");
    }

    public void RenderSquare(float side) {
        System.Console.WriteLine($"Drawing a square of side {side} using raster graphics.");
    }
}

public abstract class Shape {
    protected Renderer renderer;

    public Shape(Renderer renderer) {
        this.renderer = renderer;
    }

    public abstract void Draw();
}

public class Circle : Shape {
    private float radius;

    public Circle(float radius, Renderer renderer) : base(renderer) {
        this.radius = radius;
    }

    public override void Draw() {
        renderer.RenderCircle(radius);
    }
}

public class Square : Shape {
    private float side;

    public Square(float side, Renderer renderer) : base(renderer) {
        this.side = side;
    }

    public override void Draw() {
        renderer.RenderSquare(side);
    }
}
