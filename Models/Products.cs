namespace ComputerShop.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc {  get; set; }
        public string Description { get; set; }
        public string img {  get; set; }
        public ushort price {  get; set; }
        public bool isHit {  get; set; }
        public ushort count {  get; set; }
        // К многим товарам одна категория
        public virtual Category Category { get; set; }
    }
}
