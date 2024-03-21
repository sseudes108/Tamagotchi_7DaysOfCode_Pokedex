using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_7DaysOfCode_Pokedex.Project.Model{
    internal class Mascote{
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Sono { get; set; }

    }

    /*  //Mapper Configuration Example (Sem uso no projeto, o classe pokemon já consegue se comportar como a classe que seria o resultado desse mapeamento//
     *  
        Pokemon poke = Dex.PegarPokemonInfo("abra");

        var config = new MapperConfiguration(cfg => cfg.CreateMap<Pokemon, Mascote>());

        var mapper = new Mapper(config);
        Mascote mascote = mapper.Map<Mascote>(poke);

        Console.WriteLine(mascote.Name);
        Console.WriteLine(mascote.Height);
        Console.WriteLine(mascote.Weight);
        Console.WriteLine(mascote.Sono);
     */
}
