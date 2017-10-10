using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public int Rating { get; set; }
        public int LegalAge { get; set; }
    }
}
