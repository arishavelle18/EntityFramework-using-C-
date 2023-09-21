namespace EFCoreTutorial.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // since many product
        public ICollection<Product> Products { get; set; }



    }
}
