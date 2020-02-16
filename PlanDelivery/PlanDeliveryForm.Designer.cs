namespace PlanDelivery
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMyOrders = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCurrentClient = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSlot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTimeslot = new System.Windows.Forms.DataGridView();
            this.comboBoxPickupPoint = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewVacation = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeslot)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(13, 8);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(402, 583);
            this.propertyGrid1.TabIndex = 3;
            // 
            // monthCalendarHoliday
            // 
            this.monthCalendarHoliday.Location = new System.Drawing.Point(825, 360);
            this.monthCalendarHoliday.Margin = new System.Windows.Forms.Padding(13);
            this.monthCalendarHoliday.MinDate = new System.DateTime(2019, 10, 2, 0, 0, 0, 0);
            this.monthCalendarHoliday.Name = "monthCalendarHoliday";
            this.monthCalendarHoliday.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 360);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AllowUserToAddRows = false;
            this.dataGridViewBooking.AllowUserToDeleteRows = false;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooking.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.ReadOnly = true;
            this.dataGridViewBooking.RowHeadersWidth = 51;
            this.dataGridViewBooking.RowTemplate.Height = 24;
            this.dataGridViewBooking.Size = new System.Drawing.Size(720, 490);
            this.dataGridViewBooking.TabIndex = 8;
            this.dataGridViewBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 674);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel4);
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1153, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UserView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.comboBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(541, 12);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(264, 40);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pickup";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewMyOrders);
            this.groupBox2.Location = new System.Drawing.Point(751, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 515);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My orders";
            // 
            // dataGridViewMyOrders
            // 
            this.dataGridViewMyOrders.AllowUserToAddRows = false;
            this.dataGridViewMyOrders.AllowUserToDeleteRows = false;
            this.dataGridViewMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMyOrders.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewMyOrders.Name = "dataGridViewMyOrders";
            this.dataGridViewMyOrders.ReadOnly = true;
            this.dataGridViewMyOrders.RowHeadersWidth = 51;
            this.dataGridViewMyOrders.RowTemplate.Height = 24;
            this.dataGridViewMyOrders.Size = new System.Drawing.Size(270, 490);
            this.dataGridViewMyOrders.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxCurrentClient);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(258, 40);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer";
            // 
            // comboBoxCurrentClient
            // 
            this.comboBoxCurrentClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentClient.FormattingEnabled = true;
            this.comboBoxCurrentClient.Location = new System.Drawing.Point(87, 3);
            this.comboBoxCurrentClient.Name = "comboBoxCurrentClient";
            this.comboBoxCurrentClient.Size = new System.Drawing.Size(136, 28);
            this.comboBoxCurrentClient.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSlot);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(810, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 40);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Timeslot";
            // 
            // textBoxSlot
            // 
            this.textBoxSlot.Location = new System.Drawing.Point(77, 3);
            this.textBoxSlot.Name = "textBoxSlot";
            this.textBoxSlot.ReadOnly = true;
            this.textBoxSlot.Size = new System.Drawing.Size(155, 26);
            this.textBoxSlot.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBooking);
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 515);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a timeslot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dataGridTimeslot);
            this.tabPage2.Controls.Add(this.comboBoxPickupPoint);
            this.tabPage2.Controls.Add(this.GenerateButton);
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Controls.Add(this.monthCalendarHoliday);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1153, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Market Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTimeslot
            // 
            this.dataGridTimeslot.AllowUserToAddRows = false;
            this.dataGridTimeslot.AllowUserToDeleteRows = false;
            this.dataGridTimeslot.AllowUserToOrderColumns = true;
            this.dataGridTimeslot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimeslot.Location = new System.Drawing.Point(424, 52);
            this.dataGridTimeslot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridTimeslot.Name = "dataGridTimeslot";
            this.dataGridTimeslot.RowHeadersWidth = 51;
            this.dataGridTimeslot.RowTemplate.Height = 24;
            this.dataGridTimeslot.Size = new System.Drawing.Size(731, 293);
            this.dataGridTimeslot.TabIndex = 10;
            // 
            // comboBoxPickupPoint
            // 
            this.comboBoxPickupPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPickupPoint.FormattingEnabled = true;
            this.comboBoxPickupPoint.Location = new System.Drawing.Point(424, 8);
            this.comboBoxPickupPoint.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxPickupPoint.Name = "comboBoxPickupPoint";
            this.comboBoxPickupPoint.Size = new System.Drawing.Size(343, 28);
            this.comboBoxPickupPoint.TabIndex = 8;
            this.comboBoxPickupPoint.SelectedIndexChanged += new System.EventHandler(this.comboBoxPickupPoint_SelectedIndexChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(776, 8);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(5);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(113, 35);
            this.GenerateButton.TabIndex = 9;
            this.GenerateButton.Text = "Generate Timeslots";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.monthCalendar1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.dataGridViewVacation);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1153, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Market Holiday";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(836, 233);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove Holiday";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Holiday";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(836, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 142);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewVacation
            // 
            this.dataGridViewVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacation.Location = new System.Drawing.Point(836, 288);
            this.dataGridViewVacation.Name = "dataGridViewVacation";
            this.dataGridViewVacation.RowHeadersWidth = 51;
            this.dataGridViewVacation.RowTemplate.Height = 24;
            this.dataGridViewVacation.Size = new System.Drawing.Size(304, 268);
            this.dataGridViewVacation.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1153, 641);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "AdminView Orders";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.comboBox2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(273, 12);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(264, 40);
            this.flowLayoutPanel4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(433, 371);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 242);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Extended Pickup = Market\n-Opening hours\n-Book baskets for pickup\n-Baskets can be " +
    "delivered within 500m\n\n";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // PlanDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 755);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlanDeliveryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimeslot)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridTimeslot;
        private System.Windows.Forms.DataGridView dataGridViewVacation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSlot;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMyOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCurrentClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

