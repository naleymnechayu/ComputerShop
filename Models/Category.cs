namespace ComputerShop.Models
{
    public class Category
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Products> Categories { get; set;}
    }
}
