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
	public partial class frmemployees : Form
	{
		private ModelEntities context;
		
		public frmemployees()
		{
			InitializeComponent();
		}
		
		private void frmemployees_Load(object sender, EventArgs e)
		{
			context = new ModelEntities();
			context.employees.Load();
			BindingList<employees> _entities = context.employees.Local.ToBindingList();
			employeesBindingSource.DataSource = _entities;
			this.employee_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_id", true ));
			this.employee_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_login", true ));
			this.employee_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_password", true ));
			this.employee_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_name", true ));
			this.employee_surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_surname", true ));
			this.employee_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_email", true ));
			this.employee_displaynameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_displayname", true ));
			this.employee_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_phone", true ));
			this.employee_mphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_mphone", true ));
			this.employee_wphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_wphone", true ));
			this.employee_faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_fax", true ));
			this.employee_skypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_skype", true ));
			this.employee_hphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_hphone", true ));
			this.employee_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_address", true ));
			this.employee_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "employee_description", true ));
			this.jobtitle_id_comboBox.DataSource = context.job_titles.ToList();
			this.jobtitle_id_comboBox.DisplayMember = "jobtitle_id";
			this.jobtitle_id_comboBox.ValueMember = "jobtitle_id";
			this.jobtitle_id_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "jobtitle_id", true));
			
		}
		
		private void Save_Click(object sender, EventArgs e)
		{
			if (!this.Validate()) return;
			employeesBindingSource.EndEdit();
			context.SaveChanges();
			
		}
		
		private void frmemployees_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
		}
		
		private void employee_idTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_idTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_idTextBox, "The field employee_id is required" ); 
			}
			int v;
			string s = employee_idTextBox.Text;
			if( !int.TryParse( s, out v ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_idTextBox, "The field employee_id must be int." );
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_idTextBox, "" ); } 
		}
		
		private void employee_loginTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_loginTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_loginTextBox, "The field employee_login is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_loginTextBox, "" ); } 
		}
		
		private void employee_passwordTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_passwordTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_passwordTextBox, "The field employee_password is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_passwordTextBox, "" ); } 
		}
		
		private void employee_nameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_nameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_nameTextBox, "The field employee_name is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_nameTextBox, "" ); } 
		}
		
		private void employee_surnameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_surnameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_surnameTextBox, "The field employee_surname is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_surnameTextBox, "" ); } 
		}
		
		private void employee_emailTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_emailTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_emailTextBox, "The field employee_email is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_emailTextBox, "" ); } 
		}
		
		private void employee_displaynameTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_displaynameTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_displaynameTextBox, "The field employee_displayname is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_displaynameTextBox, "" ); } 
		}
		
		private void employee_phoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_phoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_phoneTextBox, "The field employee_phone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_phoneTextBox, "" ); } 
		}
		
		private void employee_mphoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_mphoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_mphoneTextBox, "The field employee_mphone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_mphoneTextBox, "" ); } 
		}
		
		private void employee_wphoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_wphoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_wphoneTextBox, "The field employee_wphone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_wphoneTextBox, "" ); } 
		}
		
		private void employee_faxTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_faxTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_faxTextBox, "The field employee_fax is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_faxTextBox, "" ); } 
		}
		
		private void employee_skypeTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_skypeTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_skypeTextBox, "The field employee_skype is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_skypeTextBox, "" ); } 
		}
		
		private void employee_hphoneTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_hphoneTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_hphoneTextBox, "The field employee_hphone is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_hphoneTextBox, "" ); } 
		}
		
		private void employee_addressTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_addressTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_addressTextBox, "The field employee_address is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_addressTextBox, "" ); } 
		}
		
		private void employee_descriptionTextBox_Validating(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
			if( string.IsNullOrEmpty( employee_descriptionTextBox.Text ) )
			{
				e.Cancel = true;
				errorProvider1.SetError( employee_descriptionTextBox, "The field employee_description is required" ); 
			}
			if( !e.Cancel ) { errorProvider1.SetError( employee_descriptionTextBox, "" ); } 
		}
		
		private void jobtitle_id_comboBox_Validating(object sender, CancelEventArgs e)
		{
			int i = jobtitle_id_comboBox.SelectedIndex;
			e.Cancel = false;
			if( i == -1 )
			{
				e.Cancel = true; 
				errorProvider1.SetError(jobtitle_id_comboBox, "Must select a jobtitle_id");
			}
			if( !e.Cancel )
			{
				errorProvider1.SetError(jobtitle_id_comboBox, "");
			}
		}
		
		
		
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			employeesBindingSource.AddNew();
		}
	}
}
