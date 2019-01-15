namespace Last_Army
{
    public class RPG : Ammunition
    {
        private const double Weight = 17.1;

        public RPG(string name)
            : base(name, Weight)
        {
        }
    }
}