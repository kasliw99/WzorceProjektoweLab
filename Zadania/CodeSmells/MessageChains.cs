namespace CodeSmells
{
    internal class MessageChains
    {
        public class Car
        {
            //public string GetEngine()
            //{
            //    return new Engine();
            //}
            public string GetCylinderSize()
            {
                Engine engine = new Engine();
                return engine.GetCylinder().GetSize();
            }
        }

        public class Engine
        {
            public Cylinder GetCylinder()
            {
                return new Cylinder();
            }
        }

        public class Cylinder
        {
            public string GetSize()
            {
                return "2.0L";
            }
        }

        // Przykład wywołania
        //Car car = new Car();
        //string cylinderSize = car.GetEngine().GetCylinder().GetSize();
    }
}
