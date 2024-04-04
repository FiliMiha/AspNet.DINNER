using AspNet.DINNER.Models;

namespace AspNet.DINNER.Services
{
    public class DinnerServices
    {
        public List<Dinner> vecere = new List<Dinner>
        {
            new Dinner{Id = 1, Predjelo = "Pileća juha", GlavnoJelo = "Goveđi odrezak", Desert = "Muffini", Pice = "Crno vino"},
            new Dinner{Id = 2, Predjelo = "Goveđa juha", GlavnoJelo = "Pržena piletina", Desert = "Voćna torta", Pice = "Gemišt"},
            new Dinner{Id = 3, Predjelo = "Svinjska juha", GlavnoJelo = "Goveđi odrezak", Desert = "Čokoladna torta", Pice = "Pivo"},
            new Dinner{Id = 4, Predjelo = "Pileća juha", GlavnoJelo = "Pržena piletina", Desert = "Čokoladna torta", Pice = "Gemišt"},
            new Dinner{Id = 5, Predjelo = "Goveđa juha", GlavnoJelo = "Ćevapi u lepinji", Desert = "Muffini", Pice = "Crno vino"},

        };
    }
}
