using System;

namespace APIPrincipal.Models
{
    public class Entity
    {
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataUltimaAlteracao { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.UtcNow;
            DataUltimaAlteracao = DataCriacao;
        }
    }
}
