namespace SQLMARKET_V2.APMenu.Menus
{
    partial class YetkiliDüzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.LID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGW_Klist = new System.Windows.Forms.DataGridView();
            this.txt_KPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Klist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.btn_delete.ImageKey = "user (1).png";
            this.btn_delete.Location = new System.Drawing.Point(429, 182);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delete.Size = new System.Drawing.Size(175, 50);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btn_add.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.btn_add.ImageKey = "user (1).png";
            this.btn_add.Location = new System.Drawing.Point(429, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(175, 50);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "Ekle";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btn_update.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.btn_update.ImageKey = "user (1).png";
            this.btn_update.Location = new System.Drawing.Point(429, 114);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update.Size = new System.Drawing.Size(175, 50);
            this.btn_update.TabIndex = 29;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.LID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LID.Location = new System.Drawing.Point(355, 175);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(0, 18);
            this.LID.TabIndex = 28;
            this.LID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(141, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şifre :";
            // 
            // dGW_Klist
            // 
            this.dGW_Klist.AllowUserToAddRows = false;
            this.dGW_Klist.AllowUserToDeleteRows = false;
            this.dGW_Klist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGW_Klist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dGW_Klist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGW_Klist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGW_Klist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_Klist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dGW_Klist.Location = new System.Drawing.Point(12, 261);
            this.dGW_Klist.Name = "dGW_Klist";
            this.dGW_Klist.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGW_Klist.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGW_Klist.Size = new System.Drawing.Size(701, 194);
            this.dGW_Klist.TabIndex = 23;
            this.dGW_Klist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW_Klist_CellContentDoubleClick);
            // 
            // txt_KPass
            // 
            this.txt_KPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_KPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KPass.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_KPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_KPass.Location = new System.Drawing.Point(144, 167);
            this.txt_KPass.Multiline = true;
            this.txt_KPass.Name = "txt_KPass";
            this.txt_KPass.Size = new System.Drawing.Size(140, 26);
            this.txt_KPass.TabIndex = 26;
            this.txt_KPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(141, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // txt_KID
            // 
            this.txt_KID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_KID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KID.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_KID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_KID.Location = new System.Drawing.Point(144, 97);
            this.txt_KID.Multiline = true;
            this.txt_KID.Name = "txt_KID";
            this.txt_KID.Size = new System.Drawing.Size(140, 26);
            this.txt_KID.TabIndex = 24;
            this.txt_KID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YetkiliDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(727, 467);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGW_Klist);
            this.Controls.Add(this.txt_KPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YetkiliDüzenle";
            this.Text = "YetkiliDüzenle";
            this.Load += new System.EventHandler(this.YetkiliDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Klist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGW_Klist;
        private System.Windows.Forms.TextBox txt_KPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KID;
    }
}