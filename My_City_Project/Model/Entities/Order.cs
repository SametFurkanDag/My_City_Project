namespace My_City_Project.Entities
{
    public class Order
    {
        public int OrderId { get; set; }       
        public int CartId { get; set; }        
        public decimal TotalAmount { get; set; } 
        public DateTime OrderDate { get; set; }  
    }
}
