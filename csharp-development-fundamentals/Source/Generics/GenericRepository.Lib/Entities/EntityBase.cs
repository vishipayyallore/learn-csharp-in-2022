namespace GenericRepository.Lib.Entities
{

    public class EntityBase : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }

}
