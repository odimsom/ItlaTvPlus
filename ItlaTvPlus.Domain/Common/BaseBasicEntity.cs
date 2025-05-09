namespace ItlaTvPlus.Domain.Common
{
    public abstract class BaseBasicEntity<T>
    {
        public T Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
