using System;

namespace Builder
{
    public interface IWarrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        string Weapon { get; set; }

    }
}

