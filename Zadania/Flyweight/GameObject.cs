namespace Flyweight
{
    // Klasa któa reprezentuje obiekt w grze
    public class GameObject
    {
        // Nazwa obiektu w grze
        private readonly string _name;

        // Współdzielona tekstura używana przez obiekt
        private readonly SharedTexture _texture;

        // Konstruktor, który przypisuje nazwę i teksturę do obiektu
        public GameObject(string name, SharedTexture texture)
        {
            _name = name;
            _texture = texture;
        }

        // renderowanie obiektu z jego teksturą
        public void Render()
        {
            Console.WriteLine($"Renderowanie obiektu: {_name}");
            _texture.Display(_name);
        }
    }
}