using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductStock.Views.src
{
    internal interface ProductView
    {
        string ProductID { get; set; }
        string ProductName { get; set; }
        string ProductType {get; set; }
        string ProductPrice {get; set; }
        string ProductColor {get; set; }
        string ProductImage {get; set; }
        int ProductCount { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;

        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
