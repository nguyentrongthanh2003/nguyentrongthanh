﻿namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    partial class TimKiemChucVuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemChucVuForm));
            this.confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idPositionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.NamePositonTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(372, 208);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(108, 31);
            this.confirm.TabIndex = 9;
            this.confirm.Text = "Xác nhận";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Phòng ban:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên chức vụ:";
            // 
            // idPositionTextBox
            // 
            this.idPositionTextBox.Location = new System.Drawing.Point(177, 33);
            this.idPositionTextBox.Name = "idPositionTextBox";
            this.idPositionTextBox.Size = new System.Drawing.Size(281, 22);
            this.idPositionTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã chức vụ:";
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(177, 149);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(281, 24);
            this.DepartmentComboBox.TabIndex = 12;
            // 
            // NamePositonTextBox
            // 
            this.NamePositonTextBox.Location = new System.Drawing.Point(177, 94);
            this.NamePositonTextBox.Name = "NamePositonTextBox";
            this.NamePositonTextBox.Size = new System.Drawing.Size(281, 22);
            this.NamePositonTextBox.TabIndex = 7;
            // 
            // TimKiemChucVuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 251);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.idPositionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.NamePositonTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemChucVuForm";
            this.Text = "TimKiemChucVuForm";
            this.Load += new System.EventHandler(this.TimKiemChucVuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idPositionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TextBox NamePositonTextBox;
    }
}