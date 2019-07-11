namespace DotNetRuServer.Meetups.BL.Entities
{
    public class ImageData
    {
        public int Id { get; set; }
        public bool IsSmall { get; set; }
        public string ExternalUrl { get; set; }
        public string MimeType { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public byte[] Data { get; set; }
    }
}