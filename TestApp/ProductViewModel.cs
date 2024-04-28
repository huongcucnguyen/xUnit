namespace TestApp
{
    public class ProductViewModel
    {
        public bool IsCheked { get; set; } = true;
        public bool IsReadOnly { get; set; }
        public int Price { get; set; }
        public string PriceText => Price + "円";
    }
}


