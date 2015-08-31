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
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using MySqlDB;

namespace ArtFlex
{
	public partial class frmunits : Form
	{
		private ArtflexDbContext context;
		
		public frmunits()
		{
			InitializeComponent();
		}
		
		private void frmunits_Load(object sender, EventArgs e)
		{
            context = new ArtflexDbContext();
			context.units.Load();
			BindingList<units> _entities = context.units.Local.ToBindingList();
			unitsBindingSource.DataSource = _entities;
			bindingNavigatorAddNewItem.Enabled = false;
			bindingNavigatorCountItem.Enabled = false;
			bindingNavigatorDeleteItem.Enabled = false;
			bindingNavigatorMoveFirstItem.Enabled = false;
			bindingNavigatorMovePreviousItem.Enabled = false;
			bindingNavigatorPositionItem.Enabled = false;
			bindingNavigatorMoveNextItem.Enabled = false;
			bindingNavigatorMoveLastItem.Enabled = false;
			toolStripButton1.Enabled = true;
			dataGridView1.AutoGenerateColumns = false;

			System.Windows.Forms.DataGridViewTextBoxColumn colunit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colunit_id.DataPropertyName = "unit_id";
			colunit_id.HeaderText = "unit_id";
			colunit_id.Name = "colunit_id";
			dataGridView1.Columns.Add(colunit_id);
			System.Windows.Forms.DataGridViewTextBoxColumn colunit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colunit_name.DataPropertyName = "unit_name";
			colunit_name.HeaderText = "unit_name";
			colunit_name.Name = "colunit_name";
			dataGridView1.Columns.Add(colunit_name);
			System.Windows.Forms.DataGridViewTextBoxColumn colunit_shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colunit_shortname.DataPropertyName = "unit_shortname";
			colunit_shortname.HeaderText = "unit_shortname";
			colunit_shortname.Name = "colunit_shortname";
			dataGridView1.Columns.Add(colunit_shortname);
			dataGridView1.DataSource = _entities;
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			unitsBindingSource.EndEdit();
			context.SaveChanges();
			
		}
		
		private void frmunits_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string s;
			DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
			object value = e.FormattedValue;
			e.Cancel = false;
			row.ErrorText = "";
			if (row.IsNewRow) return;
			if (e.ColumnIndex == 0)
			{
				int v;
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field unit_id is required";
					return;
				}
				s = value.ToString();
				if( !int.TryParse( s, out v ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field unit_id must be int.";
					return;
				}
			}
			if (e.ColumnIndex == 1)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field unit_name is required";
					return;
				}
			}
			if (e.ColumnIndex == 2)
			{
				if( (value is DBNull) || string.IsNullOrEmpty( value.ToString() ) )
				{
					e.Cancel = true;
					row.ErrorText = "The field unit_shortname is required";
					return;
				}
			}
		}
		
		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			dataGridView1.Rows[e.RowIndex].ErrorText = e.Exception.Message;
			e.Cancel = true;
		}
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			unitsBindingSource.AddNew();
		}
	}
}
