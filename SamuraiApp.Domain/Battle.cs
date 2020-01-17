using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        public int BattleId { get; set; }
        public string Nome { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
