using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTraoDoiHang
{
    public partial class UCDetailImage : UserControl
    {
        public UCDetailImage(Image x)
        {
            InitializeComponent();
            this.BackgroundImage = x;
        }
    }
}
