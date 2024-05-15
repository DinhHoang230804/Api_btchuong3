using Btchuong3.Model.Domain;

namespace Btchuong3.Repositories
{
    public interface IImageRepository
    {

        Image Upload(Image image);
        List<Image> GetAllInfoImages();
        (byte[], string, string) DownloadFile(int Id);

    }
}
