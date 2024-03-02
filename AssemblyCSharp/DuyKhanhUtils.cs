using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssemblyCSharp
{
    internal class DuyKhanhUtils
    {
        public static void SaveImageLocally(byte[] imageData, string filename)
        {
            try
            {
                // Tạo ảnh từ dữ liệu
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);

                    // Lưu ảnh xuống đĩa cục bộ
                    image.Save(filename);
                    Console.WriteLine("Đã lưu ảnh thành công: " + filename);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lưu ảnh: " + ex.Message);
            }
        }
    }
}
