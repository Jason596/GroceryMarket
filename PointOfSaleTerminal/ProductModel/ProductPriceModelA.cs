namespace PointOfSaleTerminal.ProductModel
{
    public class ProductModelA
    {
        public decimal UnitPrice { get; set; } = 1.25m;
        private const int Volume = 3;
        public decimal VolumePrice { get; set; } = 3.00m;
    }
}