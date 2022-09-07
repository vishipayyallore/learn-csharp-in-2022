namespace GenericRepository.V1.Entities
{

    public class EntityBase : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }

}
