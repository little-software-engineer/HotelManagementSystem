namespace HotelManagementSystem
{
    partial class GuestForm
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
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_guest = new System.Windows.Forms.DataGridView();
            this.panel_button.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 497);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(1029, 117);
            this.panel_button.TabIndex = 0;
            // 
            // button_clean
            // 
            this.button_clean.FlatAppearance.BorderSize = 0;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.White;
            this.button_clean.Image = global::HotelManagementSystem.Properties.Resources.eraser;
            this.button_clean.Location = new System.Drawing.Point(618, 15);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(113, 97);
            this.button_clean.TabIndex = 5;
            this.button_clean.Text = "Clean";
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Image = global::HotelManagementSystem.Properties.Resources.delete;
            this.button_delete.Location = new System.Drawing.Point(508, 17);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(117, 102);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Image = global::HotelManagementSystem.Properties.Resources.refresh;
            this.button_update.Location = new System.Drawing.Point(403, 15);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(112, 99);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_save
            // 
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Image = global::HotelManagementSystem.Properties.Resources.diskette;
            this.button_save.Location = new System.Drawing.Point(311, 15);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(98, 102);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Add";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click_1);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(360, 336);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(118, 30);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_fName
            // 
            this.textBox_fName.Location = new System.Drawing.Point(361, 384);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(154, 30);
            this.textBox_fName.TabIndex = 3;
            this.textBox_fName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_lName
            // 
            this.textBox_lName.Location = new System.Drawing.Point(361, 432);
            this.textBox_lName.Name = "textBox_lName";
            this.textBox_lName.Size = new System.Drawing.Size(154, 30);
            this.textBox_lName.TabIndex = 5;
            this.textBox_lName.TextChanged += new System.EventHandler(this.textBox_lName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(666, 359);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(153, 30);
            this.textBox_phone.TabIndex = 7;
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_phone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "City:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(666, 409);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(153, 30);
            this.textBox_city.TabIndex = 9;
            this.textBox_city.TextChanged += new System.EventHandler(this.textBox_city_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 79);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(355, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Guests - Tequila Sunrise";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 224);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_guest);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 224);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView_guest
            // 
            this.dataGridView_guest.ColumnHeadersHeight = 29;
            this.dataGridView_guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_guest.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_guest.Name = "dataGridView_guest";
            this.dataGridView_guest.RowHeadersWidth = 51;
            this.dataGridView_guest.RowTemplate.Height = 24;
            this.dataGridView_guest.Size = new System.Drawing.Size(1023, 224);
            this.dataGridView_guest.TabIndex = 0;
            this.dataGridView_guest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_guest_CellContentClick);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1029, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_fName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panel_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_guest;
    }
}