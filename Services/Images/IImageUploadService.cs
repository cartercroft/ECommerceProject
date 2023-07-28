using Microsoft.AspNetCore.Components.Forms;

namespace ECommerceProject.Services.Images
{
    public interface IImageUploadService
    {
        public Task<byte[]> GetImageBytesFromUploadAsync(IBrowserFile file, long maxAllowedSize);
    }
}
