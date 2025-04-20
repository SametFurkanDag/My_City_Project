namespace My_City_Project.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
