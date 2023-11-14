using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtg
{
    class MazzoTipo
    {
        public List<CarteTipo> Listatipi { get; set; }
        //CarteTipo Land { get; set; }
        //CarteTipo Creature { get; set; }
        //CarteTipo Artifact { get; set; }
        //CarteTipo Enchantment { get; set; }
        //CarteTipo Planeswalker { get; set; }
        //CarteTipo Instant { get; set; }
        //CarteTipo Sorcery { get; set; }
        public MazzoTipo()
        {
            Listatipi = new List<CarteTipo>();
            Listatipi.Add(new CarteTipo("Artifact"));
            Listatipi.Add(new CarteTipo("Creature"));
            Listatipi.Add(new CarteTipo("Enchantment"));
            Listatipi.Add(new CarteTipo("Planeswalker"));
            Listatipi.Add(new CarteTipo("Instant"));
            Listatipi.Add(new CarteTipo("Sorcery"));
            Listatipi.Add(new CarteTipo("Land"));
            Listatipi.Add(new CarteTipo("Side"));
        }
    }
}
