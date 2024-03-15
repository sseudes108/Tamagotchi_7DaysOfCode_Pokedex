namespace Tomagochi7DaysOfCode
{
    internal class Pokemon{
        public string Name { get; set; }
        public Abilities[] Abilities { get; set; }
        public Moves[] Moves { get; set; }
        public Types[] Types { get; set; }
        public Stats[] Stats { get; set; }
    }

    public class Ability{
        public string Name { get; set; }
    }

    public class Abilities{
        public Ability Ability { get; set; }
    }

    public class Move{
        public string Name { get; set; }
    }

    public class Moves{
        public Move Move { get; set; }
    }

    public class Type{
        public string Name { get; set; }
    }

    public class Types{
        public Type Type { get; set; }
    }

    public class Stat{
        public string Name { get; set; }
    }
    public class Stats{
        public int Base_stat { get; set; }
        public Stat Stat { get; set; }
    }
}
