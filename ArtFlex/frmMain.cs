/*
 * ++++++++++++++++++++++++++++++++++++++++++++++++++
 * This code is generated by a tool and is provided "as is", without warranty of any kind,
 * express or implied, including but not limited to the warranties of merchantability,
 * fitness for a particular purpose and non-infringement.
 * In no event shall the authors or copyright holders be liable for any claim, damages or
 * other liability, whether in an action of contract, tort or otherwise, arising from,
 * out of or in connection with the software or the use or other dealings in the software.
 * ++++++++++++++++++++++++++++++++++++++++++++++++++
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtFlex
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


    private void frmcategoriesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmcategories f = new frmcategories();
      f.Show();
    }

    private void frmclientsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmclients f = new frmclients();
      f.Show();
    }

    private void frmconsumptionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmconsumption f = new frmconsumption();
      f.Show();
    }

    private void frmemployeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmemployees f = new frmemployees();
      f.Show();
    }

    private void frmjob_titlesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmjob_titles f = new frmjob_titles();
      f.Show();
    }

    private void frmmaterialsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmmaterials f = new frmmaterials();
      f.Show();
    }

    private void frmordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmorders f = new frmorders();
      f.Show();
    }

    private void frmrestsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmrests f = new frmrests();
      f.Show();
    }

    private void frmsupplierToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmsuppliers f = new frmsuppliers();
      f.Show();
    }

    private void frmsupplyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmsupplies f = new frmsupplies();
      f.Show();
    }

    private void frmunitsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmunits f = new frmunits();
      f.Show();
    }

    private void frmwaybillsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmwaybills f = new frmwaybills();
      f.Show();
    }

    }
}
