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

namespace ArtFlex
{
	partial class frmmaterials
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		#region Windows Form Designer generated code
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.categoriesbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.material_UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.material_CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.unit_idLabel = new System.Windows.Forms.Label();
            this.material_descriptionLabel = new System.Windows.Forms.Label();
            this.material_idLabel = new System.Windows.Forms.Label();
            this.material_rollwidthLabel = new System.Windows.Forms.Label();
            this.material_idTextBox = new System.Windows.Forms.TextBox();
            this.material_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.category_idLabel = new System.Windows.Forms.Label();
            this.material_sizeTextBox = new System.Windows.Forms.TextBox();
            this.material_nameLabel = new System.Windows.Forms.Label();
            this.material_createtimeLabel = new System.Windows.Forms.Label();
            this.material_rollwidthTextBox = new System.Windows.Forms.TextBox();
            this.material_sizeLabel = new System.Windows.Forms.Label();
            this.material_nameTextBox = new System.Windows.Forms.TextBox();
            this.material_createtimeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // categoriesbindingSource
            // 
            this.categoriesbindingSource.DataSource = this.materialsBindingSource;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddNew);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.material_UnitsComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.material_CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.unit_idLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_descriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_idLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_rollwidthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_idTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.material_descriptionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.category_idLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_sizeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.material_nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_createtimeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_rollwidthTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.material_sizeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.material_nameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.material_createtimeTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMaterials);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 625);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(916, 54);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 37;
            this.buttonAddNew.Text = "Add";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(916, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // material_UnitsComboBox
            // 
            this.material_UnitsComboBox.FormattingEnabled = true;
            this.material_UnitsComboBox.Location = new System.Drawing.Point(608, 24);
            this.material_UnitsComboBox.MaxDropDownItems = 10;
            this.material_UnitsComboBox.Name = "material_UnitsComboBox";
            this.material_UnitsComboBox.Size = new System.Drawing.Size(84, 21);
            this.material_UnitsComboBox.TabIndex = 35;
            this.material_UnitsComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.material_UnitsComboBox_Validating);
            // 
            // material_CategoryComboBox
            // 
            this.material_CategoryComboBox.FormattingEnabled = true;
            this.material_CategoryComboBox.Location = new System.Drawing.Point(10, 24);
            this.material_CategoryComboBox.Name = "material_CategoryComboBox";
            this.material_CategoryComboBox.Size = new System.Drawing.Size(151, 21);
            this.material_CategoryComboBox.TabIndex = 34;
            this.material_CategoryComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.category_id_comboBox_Validating);
            // 
            // unit_idLabel
            // 
            this.unit_idLabel.AutoSize = true;
            this.unit_idLabel.Location = new System.Drawing.Point(606, 7);
            this.unit_idLabel.Name = "unit_idLabel";
            this.unit_idLabel.Size = new System.Drawing.Size(84, 13);
            this.unit_idLabel.TabIndex = 29;
            this.unit_idLabel.Text = "��. ���������";
            // 
            // material_descriptionLabel
            // 
            this.material_descriptionLabel.AutoSize = true;
            this.material_descriptionLabel.Location = new System.Drawing.Point(10, 47);
            this.material_descriptionLabel.Name = "material_descriptionLabel";
            this.material_descriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.material_descriptionLabel.TabIndex = 30;
            this.material_descriptionLabel.Text = "��������";
            // 
            // material_idLabel
            // 
            this.material_idLabel.AutoSize = true;
            this.material_idLabel.Location = new System.Drawing.Point(718, 64);
            this.material_idLabel.Name = "material_idLabel";
            this.material_idLabel.Size = new System.Drawing.Size(57, 13);
            this.material_idLabel.TabIndex = 19;
            this.material_idLabel.Text = "material_id";
            // 
            // material_rollwidthLabel
            // 
            this.material_rollwidthLabel.AutoSize = true;
            this.material_rollwidthLabel.Location = new System.Drawing.Point(776, 8);
            this.material_rollwidthLabel.Name = "material_rollwidthLabel";
            this.material_rollwidthLabel.Size = new System.Drawing.Size(84, 13);
            this.material_rollwidthLabel.TabIndex = 27;
            this.material_rollwidthLabel.Text = "������ ������";
            // 
            // material_idTextBox
            // 
            this.material_idTextBox.Location = new System.Drawing.Point(779, 62);
            this.material_idTextBox.Name = "material_idTextBox";
            this.material_idTextBox.Size = new System.Drawing.Size(84, 20);
            this.material_idTextBox.TabIndex = 20;
            // 
            // material_descriptionTextBox
            // 
            this.material_descriptionTextBox.Location = new System.Drawing.Point(10, 63);
            this.material_descriptionTextBox.Multiline = true;
            this.material_descriptionTextBox.Name = "material_descriptionTextBox";
            this.material_descriptionTextBox.Size = new System.Drawing.Size(596, 36);
            this.material_descriptionTextBox.TabIndex = 31;
            // 
            // category_idLabel
            // 
            this.category_idLabel.AutoSize = true;
            this.category_idLabel.Location = new System.Drawing.Point(8, 6);
            this.category_idLabel.Name = "category_idLabel";
            this.category_idLabel.Size = new System.Drawing.Size(84, 13);
            this.category_idLabel.TabIndex = 21;
            this.category_idLabel.Text = "��� ���������";
            // 
            // material_sizeTextBox
            // 
            this.material_sizeTextBox.Location = new System.Drawing.Point(694, 24);
            this.material_sizeTextBox.Name = "material_sizeTextBox";
            this.material_sizeTextBox.Size = new System.Drawing.Size(84, 20);
            this.material_sizeTextBox.TabIndex = 26;
            this.material_sizeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.material_sizeTextBox_Validating);
            // 
            // material_nameLabel
            // 
            this.material_nameLabel.AutoSize = true;
            this.material_nameLabel.Location = new System.Drawing.Point(160, 6);
            this.material_nameLabel.Name = "material_nameLabel";
            this.material_nameLabel.Size = new System.Drawing.Size(115, 13);
            this.material_nameLabel.TabIndex = 22;
            this.material_nameLabel.Text = "�������� ���������";
            // 
            // material_createtimeLabel
            // 
            this.material_createtimeLabel.AutoSize = true;
            this.material_createtimeLabel.Location = new System.Drawing.Point(682, 84);
            this.material_createtimeLabel.Name = "material_createtimeLabel";
            this.material_createtimeLabel.Size = new System.Drawing.Size(98, 13);
            this.material_createtimeLabel.TabIndex = 32;
            this.material_createtimeLabel.Text = "material_createtime";
            // 
            // material_rollwidthTextBox
            // 
            this.material_rollwidthTextBox.Location = new System.Drawing.Point(779, 24);
            this.material_rollwidthTextBox.Name = "material_rollwidthTextBox";
            this.material_rollwidthTextBox.Size = new System.Drawing.Size(84, 20);
            this.material_rollwidthTextBox.TabIndex = 28;
            this.material_rollwidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.material_rollwidthTextBox_Validating);
            // 
            // material_sizeLabel
            // 
            this.material_sizeLabel.AutoSize = true;
            this.material_sizeLabel.Location = new System.Drawing.Point(692, 7);
            this.material_sizeLabel.Name = "material_sizeLabel";
            this.material_sizeLabel.Size = new System.Drawing.Size(46, 13);
            this.material_sizeLabel.TabIndex = 25;
            this.material_sizeLabel.Text = "������";
            // 
            // material_nameTextBox
            // 
            this.material_nameTextBox.Location = new System.Drawing.Point(163, 24);
            this.material_nameTextBox.Name = "material_nameTextBox";
            this.material_nameTextBox.Size = new System.Drawing.Size(444, 20);
            this.material_nameTextBox.TabIndex = 23;
            this.material_nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.material_nameTextBox_Validating);
            // 
            // material_createtimeTextBox
            // 
            this.material_createtimeTextBox.Enabled = false;
            this.material_createtimeTextBox.Location = new System.Drawing.Point(779, 81);
            this.material_createtimeTextBox.Name = "material_createtimeTextBox";
            this.material_createtimeTextBox.Size = new System.Drawing.Size(84, 20);
            this.material_createtimeTextBox.TabIndex = 33;
            // 
            // dataGridViewMaterials
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMaterials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMaterials.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.Size = new System.Drawing.Size(1229, 504);
            this.dataGridViewMaterials.TabIndex = 24;
            this.dataGridViewMaterials.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewMaterials_DataError);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(314, 0);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(184, 21);
            this.categoriesComboBox.TabIndex = 3;
            // 
            // frmmaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1229, 625);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmmaterials";
            this.Text = "Materials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmaterials_FormClosing);
            this.Load += new System.EventHandler(this.frmmaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesbindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private System.Windows.Forms.BindingSource categoriesbindingSource;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox material_UnitsComboBox;
        private System.Windows.Forms.ComboBox material_CategoryComboBox;
        private System.Windows.Forms.Label unit_idLabel;
        private System.Windows.Forms.Label material_descriptionLabel;
        private System.Windows.Forms.Label material_idLabel;
        private System.Windows.Forms.Label material_rollwidthLabel;
        private System.Windows.Forms.TextBox material_idTextBox;
        private System.Windows.Forms.TextBox material_descriptionTextBox;
        private System.Windows.Forms.Label category_idLabel;
        private System.Windows.Forms.TextBox material_sizeTextBox;
        private System.Windows.Forms.Label material_nameLabel;
        private System.Windows.Forms.Label material_createtimeLabel;
        private System.Windows.Forms.TextBox material_rollwidthTextBox;
        private System.Windows.Forms.Label material_sizeLabel;
        private System.Windows.Forms.TextBox material_nameTextBox;
        private System.Windows.Forms.TextBox material_createtimeTextBox;
        private System.Windows.Forms.DataGridView dataGridViewMaterials;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddNew;
		
	}
}

