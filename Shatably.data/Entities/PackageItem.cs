namespace Shatably.data.Entities
{
    public class PackageItem
    {
        public int PackageItemId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}