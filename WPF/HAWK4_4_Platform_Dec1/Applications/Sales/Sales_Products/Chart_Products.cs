using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Sales.Sales_Products
{
    public partial class Chart_Products : Infrastructure. Chart_Template
    {
        public Chart_Products()
        {
            InitializeComponent();
        }
        public Chart_Products(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
