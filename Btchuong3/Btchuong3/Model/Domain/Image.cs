using System.ComponentModel.DataAnnotations.Schema;

namespace Btchuong3.Model.Domain
{
    public class Image
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInbytes { get; set; }
        public string FilePath { get; set; }
    }
}
