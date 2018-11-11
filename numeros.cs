using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo_Sistema
{
    public partial class numeros : Button
    {

        public numeros()
        {
            base.SetStyle(ControlStyles.Selectable, false);
            base.UpdateStyles();
        }


    }
}
