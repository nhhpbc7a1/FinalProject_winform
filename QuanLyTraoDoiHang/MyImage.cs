using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTraoDoiHang
{
    public class MyImage
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static Image ChooseImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                try
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    return img;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Cannot open {openFileDialog1.FileName}: {ex.Message}");
                }

            }
            return Properties.Resources.empty_product;
        }
        public static List<Image> ChooseImageList()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select Images";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.ShowDialog();
            List<Image> selectedImages = new List<Image>();

            if (openFileDialog1.FileName != "")
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    try
                    {
                        Image img = Image.FromFile(filename);
                        selectedImages.Add(img);
                        Console.WriteLine(selectedImages.Count);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Cannot open {filename}: {ex.Message}");
                    }
                }
            }
            else
            {
                // Xử lý trường hợp người dùng không chọn bất kỳ tệp nào
                Console.WriteLine("No chosen image.");
            }
            return selectedImages;
        }

        public static Image ByteArrayToImage(byte[] imgData)
        {
            if (imgData == null)
                return Properties.Resources.empty_product;
            MemoryStream ms = new MemoryStream(imgData);
            return Image.FromStream(ms);
        }
    }
}
