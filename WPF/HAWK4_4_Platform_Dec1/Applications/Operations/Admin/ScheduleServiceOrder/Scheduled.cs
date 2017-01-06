using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Operations.Admin.ScheduleServiceOrder
{
    public partial class Scheduled : HAWK_Template_2
    {
        public Scheduled()
        {
            InitializeComponent();
        }
        public Scheduled(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
    }
}
