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
	public partial class frmsupplier : Form
	{
		private ModelEntities context;
		
		public frmsupplier()
		{
			InitializeComponent();
		}
		
		private void frmsupplier_Load(object sender, EventArgs e)
		{
			context = new ModelEntities();
			context.supplier.Load();
			BindingList<supplier> _entities = context.supplier.Local.ToBindingList();
			supplierBindingSource.DataSource = _entities;
			this.supplier_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_id", true ));
			this.supplier_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_name", true ));
			this.supplier_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_surname", true ));
			this.supplier_jobtitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_jobtitle", true ));
			this.supplier_organisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_organisation", true ));
			this.supplier_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_email", true ));
			this.supplier_mphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_mphone", true ));
			this.supplier_wphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_wphone", true ));
			this.supplier_faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_fax", true ));
			this.supplier_skipeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_skipe", true ));
			this.supplier_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_address", true ));
			this.supplier_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "supplier_description", true ));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			supplierBindingSource.EndEdit();
			context.SaveChanges();
			
		}
		
		private void frmsupplier_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void supplier_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_idTextBox, "The field supplier_id is required" ); 
			}
			int v;
			string s = supplier_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_idTextBox, "The field supplier_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_idTextBox, "" ); } 
		}
		
		private void supplier_nameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_nameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_nameTextBox, "The field supplier_name is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_nameTextBox, "" ); } 
		}
		
		private void supplier_surnameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_surnameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_surnameTextBox, "The field supplier_surname is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_surnameTextBox, "" ); } 
		}
		
		private void supplier_jobtitleTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_jobtitleTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_jobtitleTextBox, "The field supplier_jobtitle is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_jobtitleTextBox, "" ); } 
		}
		
		private void supplier_organisationTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_organisationTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_organisationTextBox, "The field supplier_organisation is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_organisationTextBox, "" ); } 
		}
		
		private void supplier_emailTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_emailTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_emailTextBox, "The field supplier_email is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_emailTextBox, "" ); } 
		}
		
		private void supplier_mphoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_mphoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_mphoneTextBox, "The field supplier_mphone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_mphoneTextBox, "" ); } 
		}
		
		private void supplier_wphoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_wphoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_wphoneTextBox, "The field supplier_wphone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_wphoneTextBox, "" ); } 
		}
		
		private void supplier_faxTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_faxTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_faxTextBox, "The field supplier_fax is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_faxTextBox, "" ); } 
		}
		
		private void supplier_skipeTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_skipeTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_skipeTextBox, "The field supplier_skipe is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_skipeTextBox, "" ); } 
		}
		
		private void supplier_addressTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_addressTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_addressTextBox, "The field supplier_address is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_addressTextBox, "" ); } 
		}
		
		private void supplier_descriptionTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( supplier_descriptionTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( supplier_descriptionTextBox, "The field supplier_description is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( supplier_descriptionTextBox, "" ); } 
		}
		
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			supplierBindingSource.AddNew();
		}
	}
}
