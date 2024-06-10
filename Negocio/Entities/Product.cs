namespace Negocio.Entities
{
    public class Product
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public float actualStock { get; set; }
        public DateTime creationDate { get; set; }

    }
}
