
namespace Flyweight
{
    // klasa do zarządzania tworzenia i współdzielenia tekstur
    public class TextureFactory
    {
        // Słownik przechowujący współdzielone tekstury
        private readonly Dictionary<string, SharedTexture> _textures = new();

        // funkcja zwracająca istniejącą teksturę lub tworząca nową, jeśli jeszcze nie istnieje
        public SharedTexture GetTexture(string filePath)
        {
            if (!_textures.ContainsKey(filePath))
            {
                _textures[filePath] = new SharedTexture(filePath);
            }

            return _textures[filePath];
        }
    }
}