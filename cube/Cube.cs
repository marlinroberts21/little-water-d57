
// A class that represents a cube, with width, depth and height.
// Contains one instance method that returns the calculated volume of the cube.
// A note to push
public class Cube {

public int Width, Depth, Height;

public Cube () {
    this.Depth = 0;
    this.Width = 0;
    this.Height = 0;
}

public Cube (int Depth, int Width, int Height) {
    this.Depth = Depth;
    this.Width = Width;
    this.Height = Height;
}

public int GetVolume() {
    return Width * Depth * Height;
}


} // end of class Cube