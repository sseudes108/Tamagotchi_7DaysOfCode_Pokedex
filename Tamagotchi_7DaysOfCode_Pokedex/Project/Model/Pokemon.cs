namespace Tomagochi.Model{
    internal class Pokemon{
        public string? Name { get; set; }
        public Abilities[]? Abilities { get; set; }
        public Types[]? Types { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }

    public class Ability{
        public string? Name { get; set; }
    }

    public class Abilities{
        public Ability? Ability { get; set; }
    }

    public class Type{
        public string? Name { get; set; }
    }

    public class Types{
        public Type? Type { get; set; }
    }
}
