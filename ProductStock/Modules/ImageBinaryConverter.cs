using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
