namespace Teste.HandsOn.API.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
