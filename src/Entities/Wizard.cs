namespace ConsoleApp1.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string Atack()
        {
            return this.Name + " Lançou magia!";
        }

        public string Atack(int bonus)
        {
            if (bonus > 6)
                return this.Name + " Lançou Magia super efetiva com bonus de " + bonus + " !";
            else 
                return this.Name + " Lançou magia com bonus com força franca de " + bonus + " !";
        }
    }

}
