namespace Composite
{
    using System;
    using System.Collections.Generic;

    public class MenuCategory : IMenuComponent
    {
        private readonly string _name;
        private readonly List<IMenuComponent> _components = new();

        public MenuCategory(string name)
        {
            _name = name;
        }

        public void Add(IMenuComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IMenuComponent component)
        {
            _components.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"Kategoria: {_name}");
            foreach (var component in _components)
            {
                component.Display();
            }
        }
    }

}
