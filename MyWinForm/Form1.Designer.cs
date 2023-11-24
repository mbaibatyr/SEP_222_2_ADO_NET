namespace MyWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.gvInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 411);
            this.panel1.TabIndex = 0;
            // 
            // gvInfo
            // 
            this.gvInfo.AllowUserToAddRows = false;
            this.gvInfo.AllowUserToDeleteRows = false;
            this.gvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInfo.Location = new System.Drawing.Point(12, 7);
            this.gvInfo.Name = "gvInfo";
            this.gvInfo.ReadOnly = true;
            this.gvInfo.RowTemplate.Height = 25;
            this.gvInfo.Size = new System.Drawing.Size(929, 392);
            this.gvInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btFind);
            this.panel2.Controls.Add(this.tbCompany);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 136);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Компания";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(159, 84);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(77, 32);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Найти";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(44, 42);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(192, 23);
            this.tbCompany.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btDelete);
            this.panel3.Controls.Add(this.btEdit);
            this.panel3.Controls.Add(this.btAdd);
            this.panel3.Location = new System.Drawing.Point(295, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 136);
            this.panel3.TabIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(188, 93);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(98, 64);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Изменить";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(20, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(591, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 135);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView gvInfo;
        private Panel panel2;
        private Label label1;
        private Button btFind;
        private TextBox tbCompany;
        private Panel panel3;
        private Panel panel4;
        private Button btDelete;
        private Button btEdit;
        private Button btAdd;
    }
}