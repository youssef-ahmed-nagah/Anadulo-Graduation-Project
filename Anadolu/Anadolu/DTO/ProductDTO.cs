namespace Anadolu.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public IFormFile? File { get; set; }
    }
}
