using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductStock.Models
{
    public class ProductModel
    {
        private string id;
        private string name;
        private string typeName;
        private string price;
        private string color;
        private string colorHex;
        private byte[] image;
        private int productCount;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string ColorHex { get => colorHex; set => colorHex = value; }
        public byte[] Image { get => image; set => image = value; }
        public int ProductCount { get => productCount; set => productCount = value; }
    }
}
