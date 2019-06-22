using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas.Core.Model
{
    public class Survery
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string FavoriteTeam { get; set; }
        public override string ToString()
        {
            return $"{Name} | {Birthdate} || { FavoriteTeam}";
        }

    }
}
