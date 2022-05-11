namespace SQLMARKET_V2.APMenu.Menus
{
    partial class Urun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dGW_Klist = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.cmb_Marka = new System.Windows.Forms.ComboBox();
            this.lbl_UID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Klist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.btn_delete.ImageKey = "user (1).png";
            this.btn_delete.Location = new System.Drawing.Point(494, 177);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delete.Size = new System.Drawing.Size(175, 50);
            this.btn_delete.TabIndex = 37;
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
            this.btn_add.Location = new System.Drawing.Point(494, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(175, 50);
            this.btn_add.TabIndex = 36;
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
            this.btn_update.Location = new System.Drawing.Point(494, 109);
            this.btn_update.Name = "btn_update";
            this.btn_update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update.Size = new System.Drawing.Size(175, 50);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dGW_Klist
            // 
            this.dGW_Klist.AllowUserToAddRows = false;
            this.dGW_Klist.AllowUserToDeleteRows = false;
            this.dGW_Klist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGW_Klist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dGW_Klist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGW_Klist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGW_Klist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_Klist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dGW_Klist.Location = new System.Drawing.Point(12, 261);
            this.dGW_Klist.Name = "dGW_Klist";
            this.dGW_Klist.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dGW_Klist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGW_Klist.Size = new System.Drawing.Size(701, 194);
            this.dGW_Klist.TabIndex = 23;
            this.dGW_Klist.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGW_Klist_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ürün Adı :";
            // 
            // txt_UName
            // 
            this.txt_UName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_UName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UName.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_UName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_UName.Location = new System.Drawing.Point(33, 60);
            this.txt_UName.Multiline = true;
            this.txt_UName.Name = "txt_UName";
            this.txt_UName.Size = new System.Drawing.Size(140, 26);
            this.txt_UName.TabIndex = 24;
            this.txt_UName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(30, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kategori Seçiniz :";
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cmb_Kategori.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Bold);
            this.cmb_Kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.ItemHeight = 17;
            this.cmb_Kategori.Location = new System.Drawing.Point(33, 130);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(140, 25);
            this.cmb_Kategori.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(30, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Marka Seçiniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(269, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ürün Asgari Stok :";
            // 
            // txt_AStok
            // 
            this.txt_AStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_AStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AStok.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_AStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_AStok.Location = new System.Drawing.Point(272, 60);
            this.txt_AStok.Multiline = true;
            this.txt_AStok.Name = "txt_AStok";
            this.txt_AStok.Size = new System.Drawing.Size(140, 26);
            this.txt_AStok.TabIndex = 42;
            this.txt_AStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(269, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ürün Miktari :";
            // 
            // txt_UStok
            // 
            this.txt_UStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_UStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UStok.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_UStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_UStok.Location = new System.Drawing.Point(272, 130);
            this.txt_UStok.Multiline = true;
            this.txt_UStok.Name = "txt_UStok";
            this.txt_UStok.Size = new System.Drawing.Size(140, 26);
            this.txt_UStok.TabIndex = 44;
            this.txt_UStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(269, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ürün Fiyatı :";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.txt_Fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Fiyat.Font = new System.Drawing.Font("Bahnschrift", 10.5F);
            this.txt_Fiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.txt_Fiyat.Location = new System.Drawing.Point(272, 198);
            this.txt_Fiyat.Multiline = true;
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(140, 26);
            this.txt_Fiyat.TabIndex = 46;
            this.txt_Fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_Marka
            // 
            this.cmb_Marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cmb_Marka.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Bold);
            this.cmb_Marka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.cmb_Marka.FormattingEnabled = true;
            this.cmb_Marka.ItemHeight = 17;
            this.cmb_Marka.Location = new System.Drawing.Point(33, 201);
            this.cmb_Marka.Name = "cmb_Marka";
            this.cmb_Marka.Size = new System.Drawing.Size(140, 25);
            this.cmb_Marka.TabIndex = 48;
            // 
            // lbl_UID
            // 
            this.lbl_UID.AutoSize = true;
            this.lbl_UID.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_UID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lbl_UID.Location = new System.Drawing.Point(586, 231);
            this.lbl_UID.Name = "lbl_UID";
            this.lbl_UID.Size = new System.Drawing.Size(0, 18);
            this.lbl_UID.TabIndex = 49;
            this.lbl_UID.Visible = false;
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(125)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(727, 467);
            this.Controls.Add(this.lbl_UID);
            this.Controls.Add(this.cmb_Marka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_UStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_AStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dGW_Klist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Urun";
            this.Text = "Urun";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGW_Klist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dGW_Klist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.ComboBox cmb_Marka;
        private System.Windows.Forms.Label lbl_UID;
    }
}