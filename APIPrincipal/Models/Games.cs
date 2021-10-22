using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPrincipal.Models
{
    public class Games : Entity
    {
        public string Nome { get; private set; }
        public Enum Plataforma { get; private set; }
        
        public Games(string nome, Plataforma plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }
    }
}
