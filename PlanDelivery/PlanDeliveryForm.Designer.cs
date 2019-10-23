﻿namespace PlanDelivery
{
    partial class PlanDeliveryForm
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
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.monthCalendarHoliday = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridSlots = new System.Windows.Forms.DataGridView();
            this.comboBoxPickupPoint = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewVacation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlots)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(12, 7);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(357, 467);
            this.propertyGrid1.TabIndex = 3;
            // 
            // monthCalendarHoliday
            // 
            this.monthCalendarHoliday.Location = new System.Drawing.Point(12, 480);
            this.monthCalendarHoliday.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarHoliday.MinDate = new System.DateTime(2019, 10, 2, 0, 0, 0, 0);
            this.monthCalendarHoliday.Name = "monthCalendarHoliday";
            this.monthCalendarHoliday.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 288);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBooking.AllowUserToAddRows = false;
            this.dataGridViewBooking.AllowUserToDeleteRows = false;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(21, 22);
            this.dataGridViewBooking.Name = "dataGridViewBookings";
            this.dataGridViewBooking.ReadOnly = true;
            this.dataGridViewBooking.RowHeadersWidth = 51;
            this.dataGridViewBooking.RowTemplate.Height = 24;
            this.dataGridViewBooking.Size = new System.Drawing.Size(633, 477);
            this.dataGridViewBooking.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 727);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewBooking);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridSlots);
            this.tabPage2.Controls.Add(this.comboBoxPickupPoint);
            this.tabPage2.Controls.Add(this.GenerateButton);
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Controls.Add(this.monthCalendarHoliday);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1134, 698);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin View Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridSlots
            // 
            this.dataGridSlots.AllowUserToAddRows = false;
            this.dataGridSlots.AllowUserToDeleteRows = false;
            this.dataGridSlots.AllowUserToOrderColumns = true;
            this.dataGridSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSlots.Location = new System.Drawing.Point(377, 41);
            this.dataGridSlots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridSlots.Name = "dataGridSlots";
            this.dataGridSlots.RowHeadersWidth = 51;
            this.dataGridSlots.RowTemplate.Height = 24;
            this.dataGridSlots.Size = new System.Drawing.Size(691, 416);
            this.dataGridSlots.TabIndex = 10;
            // 
            // comboBoxPickupPoint
            // 
            this.comboBoxPickupPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPickupPoint.FormattingEnabled = true;
            this.comboBoxPickupPoint.Location = new System.Drawing.Point(377, 7);
            this.comboBoxPickupPoint.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPickupPoint.Name = "comboBoxPickupPoint";
            this.comboBoxPickupPoint.Size = new System.Drawing.Size(305, 24);
            this.comboBoxPickupPoint.TabIndex = 8;
            this.comboBoxPickupPoint.SelectedIndexChanged += new System.EventHandler(this.comboBoxPickupPoint_SelectedIndexChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(690, 7);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 28);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate Timeslots";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewVacation);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1134, 698);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin View Holiday";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHoliday
            // 
            this.dataGridViewVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacation.Location = new System.Drawing.Point(20, 27);
            this.dataGridViewVacation.Name = "dataGridViewHoliday";
            this.dataGridViewVacation.RowHeadersWidth = 51;
            this.dataGridViewVacation.RowTemplate.Height = 24;
            this.dataGridViewVacation.Size = new System.Drawing.Size(1078, 647);
            this.dataGridViewVacation.TabIndex = 0;
            // 
            // PlanDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlanDeliveryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSlots)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.MonthCalendar monthCalendarHoliday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxPickupPoint;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.DataGridView dataGridSlots;
        private System.Windows.Forms.DataGridView dataGridViewVacation;
    }
}
