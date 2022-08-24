namespace CS223lab
{
    partial class FormAddRemove
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.tbInventoryNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioAvailabilityYes = new System.Windows.Forms.RadioButton();
            this.radioAvailabilityNo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.checkAdditionalDelivery = new System.Windows.Forms.CheckBox();
            this.checkAdditionalInstallation = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(27, 43);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(110, 27);
            this.tbProductNo.TabIndex = 3;
            // 
            // tbInventoryNo
            // 
            this.tbInventoryNo.Location = new System.Drawing.Point(193, 43);
            this.tbInventoryNo.Name = "tbInventoryNo";
            this.tbInventoryNo.Size = new System.Drawing.Size(110, 27);
            this.tbInventoryNo.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(27, 178);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(178, 27);
            this.tbProductName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(226, 178);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(77, 27);
            this.tbCount.TabIndex = 11;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(334, 178);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(77, 27);
            this.tbPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Availability";
            // 
            // radioAvailabilityYes
            // 
            this.radioAvailabilityYes.AutoSize = true;
            this.radioAvailabilityYes.Location = new System.Drawing.Point(32, 247);
            this.radioAvailabilityYes.Name = "radioAvailabilityYes";
            this.radioAvailabilityYes.Size = new System.Drawing.Size(51, 24);
            this.radioAvailabilityYes.TabIndex = 14;
            this.radioAvailabilityYes.TabStop = true;
            this.radioAvailabilityYes.Text = "Yes";
            this.radioAvailabilityYes.UseVisualStyleBackColor = true;
            // 
            // radioAvailabilityNo
            // 
            this.radioAvailabilityNo.AutoSize = true;
            this.radioAvailabilityNo.Location = new System.Drawing.Point(99, 247);
            this.radioAvailabilityNo.Name = "radioAvailabilityNo";
            this.radioAvailabilityNo.Size = new System.Drawing.Size(50, 24);
            this.radioAvailabilityNo.TabIndex = 15;
            this.radioAvailabilityNo.TabStop = true;
            this.radioAvailabilityNo.Text = "No";
            this.radioAvailabilityNo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Additional Services";
            // 
            // checkAdditionalDelivery
            // 
            this.checkAdditionalDelivery.AutoSize = true;
            this.checkAdditionalDelivery.Location = new System.Drawing.Point(31, 315);
            this.checkAdditionalDelivery.Name = "checkAdditionalDelivery";
            this.checkAdditionalDelivery.Size = new System.Drawing.Size(85, 24);
            this.checkAdditionalDelivery.TabIndex = 17;
            this.checkAdditionalDelivery.Text = "Delivery";
            this.checkAdditionalDelivery.UseVisualStyleBackColor = true;
            // 
            // checkAdditionalInstallation
            // 
            this.checkAdditionalInstallation.AutoSize = true;
            this.checkAdditionalInstallation.Location = new System.Drawing.Point(31, 345);
            this.checkAdditionalInstallation.Name = "checkAdditionalInstallation";
            this.checkAdditionalInstallation.Size = new System.Drawing.Size(104, 24);
            this.checkAdditionalInstallation.TabIndex = 18;
            this.checkAdditionalInstallation.Text = "Installation";
            this.checkAdditionalInstallation.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(410, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(549, 345);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsList.Location = new System.Drawing.Point(12, 408);
            this.dgvProductsList.MultiSelect = false;
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.RowHeadersWidth = 51;
            this.dgvProductsList.RowTemplate.Height = 29;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(805, 259);
            this.dgvProductsList.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormAddRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 679);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvProductsList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkAdditionalInstallation);
            this.Controls.Add(this.checkAdditionalDelivery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioAvailabilityNo);
            this.Controls.Add(this.radioAvailabilityYes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbInventoryNo);
            this.Controls.Add(this.tbProductNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddRemove";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbProductNo;
        private TextBox tbInventoryNo;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox tbProductName;
        private Label label5;
        private Label label6;
        private TextBox tbCount;
        private TextBox tbPrice;
        private Label label7;
        private RadioButton radioAvailabilityYes;
        private RadioButton radioAvailabilityNo;
        private Label label8;
        private CheckBox checkAdditionalDelivery;
        private CheckBox checkAdditionalInstallation;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dgvProductsList;
        private ErrorProvider errorProvider1;
        private Button btnClear;
    }
}