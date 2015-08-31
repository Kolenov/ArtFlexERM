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
	partial class frmclients
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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.client_nameLabel = new System.Windows.Forms.Label();
            this.client_nameTextBox = new System.Windows.Forms.TextBox();
            this.client_emailLabel = new System.Windows.Forms.Label();
            this.client_emailTextBox = new System.Windows.Forms.TextBox();
            this.client_wphoneLabel = new System.Windows.Forms.Label();
            this.client_wphoneTextBox = new System.Windows.Forms.TextBox();
            this.client_faxLabel = new System.Windows.Forms.Label();
            this.client_faxTextBox = new System.Windows.Forms.TextBox();
            this.client_skipeLabel = new System.Windows.Forms.Label();
            this.client_skipeTextBox = new System.Windows.Forms.TextBox();
            this.client_addressLabel = new System.Windows.Forms.Label();
            this.client_addressTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.client_descriptionLabel = new System.Windows.Forms.Label();
            this.client_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // client_nameLabel
            // 
            this.client_nameLabel.AutoSize = true;
            this.client_nameLabel.Location = new System.Drawing.Point(9, 9);
            this.client_nameLabel.Name = "client_nameLabel";
            this.client_nameLabel.Size = new System.Drawing.Size(163, 17);
            this.client_nameLabel.TabIndex = 9;
            this.client_nameLabel.Text = "�������� �����������";
            // 
            // client_nameTextBox
            // 
            this.client_nameTextBox.Location = new System.Drawing.Point(12, 29);
            this.client_nameTextBox.Name = "client_nameTextBox";
            this.client_nameTextBox.Size = new System.Drawing.Size(511, 23);
            this.client_nameTextBox.TabIndex = 10;
            this.client_nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.client_nameTextBox_Validating);
            // 
            // client_emailLabel
            // 
            this.client_emailLabel.AutoSize = true;
            this.client_emailLabel.Location = new System.Drawing.Point(754, 9);
            this.client_emailLabel.Name = "client_emailLabel";
            this.client_emailLabel.Size = new System.Drawing.Size(47, 17);
            this.client_emailLabel.TabIndex = 11;
            this.client_emailLabel.Text = "E-mail";
            // 
            // client_emailTextBox
            // 
            this.client_emailTextBox.Location = new System.Drawing.Point(755, 29);
            this.client_emailTextBox.Name = "client_emailTextBox";
            this.client_emailTextBox.Size = new System.Drawing.Size(220, 23);
            this.client_emailTextBox.TabIndex = 12;
            this.client_emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.client_emailTextBox_Validating);
            // 
            // client_wphoneLabel
            // 
            this.client_wphoneLabel.AutoSize = true;
            this.client_wphoneLabel.Location = new System.Drawing.Point(526, 9);
            this.client_wphoneLabel.Name = "client_wphoneLabel";
            this.client_wphoneLabel.Size = new System.Drawing.Size(68, 17);
            this.client_wphoneLabel.TabIndex = 13;
            this.client_wphoneLabel.Text = "�������";
            // 
            // client_wphoneTextBox
            // 
            this.client_wphoneTextBox.Location = new System.Drawing.Point(529, 29);
            this.client_wphoneTextBox.Name = "client_wphoneTextBox";
            this.client_wphoneTextBox.Size = new System.Drawing.Size(220, 23);
            this.client_wphoneTextBox.TabIndex = 14;
            this.client_wphoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.client_wphoneTextBox_Validating);
            // 
            // client_faxLabel
            // 
            this.client_faxLabel.AutoSize = true;
            this.client_faxLabel.Location = new System.Drawing.Point(526, 58);
            this.client_faxLabel.Name = "client_faxLabel";
            this.client_faxLabel.Size = new System.Drawing.Size(43, 17);
            this.client_faxLabel.TabIndex = 15;
            this.client_faxLabel.Text = "����";
            // 
            // client_faxTextBox
            // 
            this.client_faxTextBox.Location = new System.Drawing.Point(529, 78);
            this.client_faxTextBox.Name = "client_faxTextBox";
            this.client_faxTextBox.Size = new System.Drawing.Size(220, 23);
            this.client_faxTextBox.TabIndex = 16;
            this.client_faxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.client_faxTextBox_Validating);
            // 
            // client_skipeLabel
            // 
            this.client_skipeLabel.AutoSize = true;
            this.client_skipeLabel.Location = new System.Drawing.Point(754, 58);
            this.client_skipeLabel.Name = "client_skipeLabel";
            this.client_skipeLabel.Size = new System.Drawing.Size(47, 17);
            this.client_skipeLabel.TabIndex = 17;
            this.client_skipeLabel.Text = "Skype";
            // 
            // client_skipeTextBox
            // 
            this.client_skipeTextBox.Location = new System.Drawing.Point(755, 78);
            this.client_skipeTextBox.Name = "client_skipeTextBox";
            this.client_skipeTextBox.Size = new System.Drawing.Size(220, 23);
            this.client_skipeTextBox.TabIndex = 18;
            // 
            // client_addressLabel
            // 
            this.client_addressLabel.AutoSize = true;
            this.client_addressLabel.Location = new System.Drawing.Point(12, 55);
            this.client_addressLabel.Name = "client_addressLabel";
            this.client_addressLabel.Size = new System.Drawing.Size(48, 17);
            this.client_addressLabel.TabIndex = 19;
            this.client_addressLabel.Text = "�����";
            // 
            // client_addressTextBox
            // 
            this.client_addressTextBox.Location = new System.Drawing.Point(12, 77);
            this.client_addressTextBox.Name = "client_addressTextBox";
            this.client_addressTextBox.Size = new System.Drawing.Size(511, 23);
            this.client_addressTextBox.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.client_addressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_skipeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_addressTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_emailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_skipeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_emailTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_wphoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_wphoneTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_faxLabel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel1.Controls.Add(this.client_faxTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_nameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.client_descriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.client_descriptionTextBox);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewClients);
            this.splitContainer1.Size = new System.Drawing.Size(1450, 643);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(1289, 65);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 36);
            this.buttonCancel.TabIndex = 38;
            this.buttonCancel.Text = "��������";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // client_descriptionLabel
            // 
            this.client_descriptionLabel.AutoSize = true;
            this.client_descriptionLabel.Location = new System.Drawing.Point(978, 9);
            this.client_descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.client_descriptionLabel.Name = "client_descriptionLabel";
            this.client_descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.client_descriptionLabel.TabIndex = 30;
            this.client_descriptionLabel.Text = "��������";
            // 
            // client_descriptionTextBox
            // 
            this.client_descriptionTextBox.Location = new System.Drawing.Point(981, 29);
            this.client_descriptionTextBox.Multiline = true;
            this.client_descriptionTextBox.Name = "client_descriptionTextBox";
            this.client_descriptionTextBox.Size = new System.Drawing.Size(301, 72);
            this.client_descriptionTextBox.TabIndex = 31;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.Location = new System.Drawing.Point(1198, 4);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(120, 36);
            this.buttonAddNew.TabIndex = 37;
            this.buttonAddNew.Text = "��������";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(1326, 4);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 36);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "���������";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.buttonAddNew);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 643);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 44);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(1450, 522);
            this.dataGridViewClients.TabIndex = 24;
            // 
            // frmclients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1450, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmclients";
            this.Text = "Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmclients_FormClosing);
            this.Load += new System.EventHandler(this.frmclients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

		}
		
		#endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
		private System.Windows.Forms.TextBox client_nameTextBox;
		private System.Windows.Forms.Label client_nameLabel;
		private System.Windows.Forms.TextBox client_emailTextBox;
		private System.Windows.Forms.Label client_emailLabel;
		private System.Windows.Forms.TextBox client_wphoneTextBox;
		private System.Windows.Forms.Label client_wphoneLabel;
		private System.Windows.Forms.TextBox client_faxTextBox;
		private System.Windows.Forms.Label client_faxLabel;
		private System.Windows.Forms.TextBox client_skipeTextBox;
		private System.Windows.Forms.Label client_skipeLabel;
		private System.Windows.Forms.TextBox client_addressTextBox;
        private System.Windows.Forms.Label client_addressLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label client_descriptionLabel;
        private System.Windows.Forms.TextBox client_descriptionTextBox;
        private System.Windows.Forms.DataGridView dataGridViewClients;
		
	}
}

