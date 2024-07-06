namespace HotelManagementSystem
{
    partial class RoomForm
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
            this.dataGridView_room = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel_button = new System.Windows.Forms.Panel();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.radioButton_free = new System.Windows.Forms.RadioButton();
            this.radioButton_busy = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_room
            // 
            this.dataGridView_room.ColumnHeadersHeight = 29;
            this.dataGridView_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_room.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_room.Name = "dataGridView_room";
            this.dataGridView_room.RowHeadersWidth = 51;
            this.dataGridView_room.RowTemplate.Height = 24;
            this.dataGridView_room.Size = new System.Drawing.Size(1023, 224);
            this.dataGridView_room.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 224);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_room);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 224);
            this.panel2.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 79);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Room Phone:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(361, 432);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(154, 30);
            this.textBox_phone.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Room Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room No:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(360, 336);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(118, 30);
            this.textBox_id.TabIndex = 15;
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
            this.panel_button.TabIndex = 14;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(361, 386);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(121, 33);
            this.comboBox_roomType.TabIndex = 27;
            // 
            // radioButton_free
            // 
            this.radioButton_free.AutoSize = true;
            this.radioButton_free.Location = new System.Drawing.Point(656, 394);
            this.radioButton_free.Name = "radioButton_free";
            this.radioButton_free.Size = new System.Drawing.Size(73, 29);
            this.radioButton_free.TabIndex = 28;
            this.radioButton_free.TabStop = true;
            this.radioButton_free.Text = "Free";
            this.radioButton_free.UseVisualStyleBackColor = true;
            // 
            // radioButton_busy
            // 
            this.radioButton_busy.AutoSize = true;
            this.radioButton_busy.Location = new System.Drawing.Point(735, 394);
            this.radioButton_busy.Name = "radioButton_busy";
            this.radioButton_busy.Size = new System.Drawing.Size(77, 29);
            this.radioButton_busy.TabIndex = 29;
            this.radioButton_busy.TabStop = true;
            this.radioButton_busy.Text = "Busy";
            this.radioButton_busy.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1029, 614);
            this.Controls.Add(this.radioButton_busy);
            this.Controls.Add(this.radioButton_free);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_room;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.RadioButton radioButton_free;
        private System.Windows.Forms.RadioButton radioButton_busy;
    }
}