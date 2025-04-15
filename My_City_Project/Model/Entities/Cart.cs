namespace My_City_Project.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; internal set; }
        public decimal TotalPrice { get; internal set; }
    }
}
    