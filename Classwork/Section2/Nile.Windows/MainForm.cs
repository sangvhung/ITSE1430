using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var product = new Product();

            Decimal.TryParse("123", out var price);
            product.Price = price;

            var name = product.Name;
            //var name = product.GetName();
            product.Name = "Product A";
            product.Price = 50;
            product.isDiscontinued = true;

            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;
            //product.SetName("Product A");

            var error = product.Validate();

            var str = product.ToString();

            var productb = new Product();
            //productb.Name = "ProductB";
            productb.SetName("Product B");
            //productb.Description = product.Description;
            error = productb.Validate();
        }

     
    }

}
