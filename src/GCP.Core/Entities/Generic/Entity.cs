using GCP.Core.Validations.CustomExceptions;

namespace GCP.Core.Entities.Generic
{
    public abstract class Entity
    {
        protected int Id { get; set; }
        protected DateTime DataInclusao { get; private set; }

        public Entity()
        {
            DataInclusao = DateTime.Now;
        }

        public Entity(int id)
        {
            DomainExceptionValidate.When(id <= 0, "Identificador inválido.");
            Id = id;
        }

        public Entity(int id, DateTime dataInclusao)
        {
            DomainExceptionValidate.When(id <= 0, "Identificador inválido.");
            Id = id;
            DataInclusao = dataInclusao;
        }

    }
}
