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
    public partial class frmmaterials : Form
    {
        private ModelEntities context;

        public frmmaterials()
        {
            InitializeComponent();
        }

        private void frmmaterials_Load(object sender, EventArgs e)
        {
            context = new ModelEntities();
            context.materials.Where<materials>(b => b.category_id == 1).Load();
            BindingList<materials> _materials = context.materials.Local.ToBindingList();
            materialsBindingSource.DataSource = _materials;

            this.material_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "material_name", true));
            this.material_sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "material_size", true));
            this.material_rollwidthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "material_rollwidth", true));
            this.material_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "material_description", true));
            this.material_createtimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialsBindingSource, "material_createtime", true));

            this.material_CategoryComboBox.DataSource = context.categories.ToList();
            this.material_CategoryComboBox.DisplayMember = "category_name";
            this.material_CategoryComboBox.ValueMember = "category_id";
            this.material_CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialsBindingSource, "category_id"));

            this.material_UnitsComboBox.DataSource = context.units.ToList();
            this.material_UnitsComboBox.DisplayMember = "unit_shortname";
            this.material_UnitsComboBox.ValueMember = "unit_id";
            this.material_UnitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialsBindingSource, "unit_id"));

            // Categories selector
            this.categoriesComboBox.DataSource = context.categories.ToList();
            this.categoriesComboBox.DisplayMember = "category_name";
            this.categoriesComboBox.ValueMember = "category_id";

            // DataGridView Collumns
            System.Windows.Forms.DataGridViewTextBoxColumn col_material_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_id.DataPropertyName = "material_id";
            col_material_id.HeaderText = "ID";
            col_material_id.Name = "col_material_id";
            dataGridViewMaterials.Columns.Add(col_material_id);

            System.Windows.Forms.DataGridViewComboBoxColumn col_category_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            col_category_id.DataSource = context.categories.ToList();
            col_category_id.DataPropertyName = "category_id";
            col_category_id.DisplayMember = "category_name";
            col_category_id.ValueMember = "category_id";
            col_category_id.HeaderText = "���";
            col_category_id.Name = "col_category_id";
            col_category_id.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridViewMaterials.Columns.Add(col_category_id);

            System.Windows.Forms.DataGridViewTextBoxColumn col_material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_name.DataPropertyName = "material_name";
            col_material_name.HeaderText = "�������� ���������";
            col_material_name.Name = "col_material_name";
            dataGridViewMaterials.Columns.Add(col_material_name);

            System.Windows.Forms.DataGridViewComboBoxColumn col_units_id = new DataGridViewComboBoxColumn();
            col_units_id.DataSource = context.units.ToList();
            col_units_id.DataPropertyName = "unit_id";
            col_units_id.DisplayMember = "unit_shortname";
            col_units_id.ValueMember = "unit_id";
            col_units_id.HeaderText = "��. ���.";
            col_units_id.Name = "col_units_id";
            col_units_id.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridViewMaterials.Columns.Add(col_units_id);

            System.Windows.Forms.DataGridViewTextBoxColumn col_material_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_size.Name = "material_size";
            col_material_size.HeaderText = "������";
            col_material_size.DataPropertyName = "col_material_size";
            dataGridViewMaterials.Columns.Add(col_material_size);

            System.Windows.Forms.DataGridViewTextBoxColumn col_material_rollwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_rollwidth.DataPropertyName = "material_rollwidth";
            col_material_rollwidth.HeaderText = "������ ������";
            col_material_rollwidth.Name = "maerial_rollwidth";
            dataGridViewMaterials.Columns.Add(col_material_rollwidth);

            System.Windows.Forms.DataGridViewTextBoxColumn col_material_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_description.Name = "col_material_description";
            col_material_description.HeaderText = "��������";
            col_material_description.DataPropertyName = "material_description";
            col_material_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMaterials.Columns.Add(col_material_description);

            System.Windows.Forms.DataGridViewTextBoxColumn col_material_createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_material_createtime.Name = "col_material_createtime";
            col_material_createtime.HeaderText = "���� ����������";
            col_material_createtime.DataPropertyName = "material_createtime";
            col_material_createtime.ReadOnly = true;
            dataGridViewMaterials.Columns.Add(col_material_createtime);

            this.dataGridViewMaterials.AutoGenerateColumns = false;
            this.dataGridViewMaterials.DataSource = this.materialsBindingSource;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            materialsBindingSource.EndEdit();
            context.SaveChanges();
            this.dataGridViewMaterials.Refresh();
        }

        private void frmmaterials_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        #region Validating

        private void category_id_comboBox_Validating(object sender, CancelEventArgs e)
        {
            int i = material_CategoryComboBox.SelectedIndex;
            e.Cancel = false;
            if (i == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(material_CategoryComboBox, "Must select a order_id");
            }
            if (!e.Cancel)
            {
                errorProvider1.SetError(material_CategoryComboBox, "");
            }
        }

        private void material_nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(material_nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(material_nameTextBox, "The field material_name is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(material_nameTextBox, ""); }
        }

        private void material_sizeTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(material_sizeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(material_sizeTextBox, "The field material_size is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(material_sizeTextBox, ""); }
        }

        private void material_rollwidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(material_rollwidthTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(material_rollwidthTextBox, "The field material_rollwidth is required");
            }
            int v;
            string s = material_rollwidthTextBox.Text;
            if (!int.TryParse(s, out v))
            {
                e.Cancel = true;
                errorProvider1.SetError(material_rollwidthTextBox, "The field material_rollwidth must be int.");
            }
            if (!e.Cancel) { errorProvider1.SetError(material_rollwidthTextBox, ""); }
        }

        private void material_descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(material_descriptionTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(material_descriptionTextBox, "The field material_description is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(material_descriptionTextBox, ""); }
        }
        #endregion
        private void AddNewItem_Click(object sender, EventArgs e)
        {
            categories category = categoriesComboBox.SelectedItem as categories;
            materials obj = new materials();
            obj.category_id = category.category_id;
            obj.unit_id = 1;
            obj.material_name = "";
            materialsBindingSource.Add(obj);
            materialsBindingSource.MoveLast();
        }

        private void material_UnitsComboBox_Validating(object sender, CancelEventArgs e)
        {
            int i = material_UnitsComboBox.SelectedIndex;
            e.Cancel = false;
            if (i == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(material_UnitsComboBox, "Must select a order_id");
            }
            if (!e.Cancel)
            {
                errorProvider1.SetError(material_UnitsComboBox, "");
            }
        }

        private void dataGridViewMaterials_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //MessageBox.Show("Error happened " + e.Context.ToString());

            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((e.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[e.RowIndex].ErrorText = "an error";
                view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

                e.ThrowException = false;
            }
            //e.ThrowException = true;
        }

        private void dataGridViewMaterials_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            //if (e.ColumnIndex == 0) // your combo column index
            //{
            //    e.Value = 1;
            //}
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categories category = categoriesComboBox.SelectedItem as categories;
            if (category == null)
                return;
            this.context.Dispose();
            this.context = new ModelEntities();
            this.context.materials.Where<materials>(b => b.category_id == category.category_id).Load();
            BindingList<materials> _materials = this.context.materials.Local.ToBindingList();
            materialsBindingSource.DataSource = _materials;
        }

    }
}
