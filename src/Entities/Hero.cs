namespace ConsoleApp1.src.Entities
{
    public abstract class Hero
    {
        protected Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public virtual string Atack()
        {
            return this.Name + " Atacou com sua espada!";
        }

        public override string ToString()
        {
            return Name + " " + Level + " " + HeroType;
        }
    }
}
