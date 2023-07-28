using Microsoft.AspNetCore.Components.Forms;

namespace ECommerceProject.Services.Images
{
    public class ImageUploadService : IImageUploadService
    {
        private IWebHostEnvironment _env;
        public ImageUploadService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public async Task<byte[]> GetImageBytesFromUploadAsync(IBrowserFile file, long maxAllowedSize)
        {
            string path = Path.Combine(_env.ContentRootPath, "Images", _env.EnvironmentName, file.Name);
            
            await using FileStream fs = new(path, FileMode.Create);
            await file.OpenReadStream(maxAllowedSize).CopyToAsync(fs);
            await using MemoryStream ms = new MemoryStream();
            fs.CopyTo(ms);
            return ms.ToArray();
        }
    }
}
