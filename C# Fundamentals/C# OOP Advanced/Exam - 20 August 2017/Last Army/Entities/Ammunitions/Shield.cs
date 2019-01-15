namespace Last_Army
{
    public class Shield : Ammunition
    {
        public const double Weight = 3.7;

        public Shield(string name)
            : base(name, Weight)
        {
        }
    }
}