Circle circle = new Circle {Id = 1};
Rectangule rectangule = new Rectangule {Id = 2};
Square square = new Square {Id = 3};

circle.Draw();
rectangule.Draw();
square.Draw();

Console.WriteLine("Clonados");

Circle clonecircle = (Circle)circle.Clone();

Rectangule cloneRectangule = (Rectangule)rectangule.Clone();

Square cloneSquare = (Square)square.Clone();

clonecircle.Draw();
cloneRectangule.Draw();
cloneSquare.Draw();