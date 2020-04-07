using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrForm
{
    public partial class INFO : Form
    {
        public INFO(string index)
        {
            InitializeComponent();

            List<Cars> li = new List<Cars>();
            Cars ca = new Cars();
            int i = Convert.ToInt32(index);

            ca.update(li);

            mark_t.Text = li[i].mark;
            year_t.Text = Convert.ToString(li[i].year);
            probeg_t.Text = Convert.ToString(li[i].probeg);
            colour_t.Text = li[i].colour;
            mark_t.ReadOnly = true;
            year_t.ReadOnly = true;
            probeg_t.ReadOnly = true;
            colour_t.ReadOnly = true;
        }

        private void INFO_Load(object sender, EventArgs e)
        {

        }
    }
}
