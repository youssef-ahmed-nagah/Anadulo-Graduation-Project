using Microsoft.Extensions.Hosting;
//using MySqlX.XDevAPI.Common;
using Anadolu.DTO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;


namespace Anadolu
{
    public class UploaderImage
    {
        private static IHostingEnvironment host;

        public UploaderImage(IHostingEnvironment _host)
        {
            host = _host;
        }
        public async Task<string> Uploade(IFormFile File) 
        {
            string fileName = string.Empty;
            if (File == null || File.Length == 0)
            {
                return "No File Selected";
            }

            string myUpload = Path.Combine(host.WebRootPath, "images");
            fileName = File.FileName;
            string fullPath = Path.Combine(myUpload, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await File.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
