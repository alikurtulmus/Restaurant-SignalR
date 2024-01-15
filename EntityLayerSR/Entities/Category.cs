namespace EntityLayerSR.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string? CategoryImageUrl { get; set; }

        public string? CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set;}
    }
}
