namespace Teste.HandsOn.API.Entities
{
    public class Order : BaseEntity
    {
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
