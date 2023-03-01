namespace Teste.HandsOn.API.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
