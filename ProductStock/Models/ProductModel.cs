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
    internal class ProductModel
    {
        private string id;
        private string name;
        private string typeName;
        private string price;
        private string color;
        private string image;
        private int productCount;

        [DisplayName("Product ID")]
        public string Id { get => id; set => id = value; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "product name is requered")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Type Name")]
        [Required(ErrorMessage = "Type name is requered")]
        public string TypeName { get => typeName; set => typeName = value; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "price is requerid")]
        public string Price { get => price; set => price = value; }

        [DisplayName("Color")]
        [Required(ErrorMessage = "color is requerid")]
        public string Color { get => color; set => color = value; }

        [DisplayName("Image")]
        public string Image { get => image; set => image = value; }

        [DisplayName("Count")]
        public int ProductCount { get => productCount; set => productCount = value; }
    }
}
