namespace Shatably.data.Entities
{
    public class Package
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<PackageItem> Items { get; set; }
    }
}
