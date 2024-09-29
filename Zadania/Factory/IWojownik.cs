using System;

namespace Factory
{
    public interface IWojownik
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

    }
}
