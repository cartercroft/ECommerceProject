namespace ECommerceProject.Models
{
    public class ImageRecord
    {
        public int Id { get; set; }
        public byte[] ImageBytes { get; set; }
        public string ImageFileType { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
    }
}
