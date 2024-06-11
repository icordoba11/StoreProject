namespace Negocio.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Nombre { get; set; }
        public string ItemDescription { get; set; }
        public float Price { get; set; }
        public float ActualStock { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
