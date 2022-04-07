namespace PieShop.Models
{
    public class ShoopingCartItem
    {
        public int ShoopingCartItemId { get; set; }
        public Pie Pie { get; set; }    
        public int Amount { get; set; }
        public string ShoopingCartId { get; set; }
    }
}
