namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie fabryki tekstur
            var textureFactory = new TextureFactory();

            // Tworzenie współdzielonej tekstury
            var grassTexture = textureFactory.GetTexture("grass.png");
            var stoneTexture = textureFactory.GetTexture("stone.png");
            var treeTexture = textureFactory.GetTexture("tree.png");

            // Tworzenie obiektu w grze i przypisanie mu tekstury
            var grassTile1 = new GameObject("GrassTile1", grassTexture);
            var grassTile2 = new GameObject("GrassTile2", grassTexture);
            var stoneBlock = new GameObject("StoneBlock", stoneTexture);
            var tree = new GameObject("Tree", treeTexture);

            // Renderowanie obiektów
            grassTile1.Render();
            grassTile2.Render();
            stoneBlock.Render();
            tree.Render();
        }
    }
}