namespace Last_Army
{
    public class Grenades : Ammunition
    {
        private const double Weight = 1.0;

        public Grenades(string name) 
            : base (name, Weight)
        {
        }
    }
}