using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Modules
{
    internal class ImageBinaryConverter
    {

        public Bitmap ByteToImage(byte[] imgBinary)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = imgBinary;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public OpenFileDialog getImage()
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                return opnfd;
            }
            return null;
        }

        public byte[] ImageToByte(string imagePath)
        {
            byte[] rawData = File.ReadAllBytes(imagePath);
            return rawData;
        }

        public byte[] ImageBoxToByte(Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
