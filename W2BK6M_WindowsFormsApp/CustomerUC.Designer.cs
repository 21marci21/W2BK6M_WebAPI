namespace W2BK6M_WindowsFormsApp
{
    partial class CustomerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.szűrésTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(63, 203);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add new customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.CausesValidation = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(482, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 589);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(63, 262);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(190, 23);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            this.emailTextBox.Validated += new System.EventHandler(this.emailTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(63, 329);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(190, 23);
            this.cityTextBox.TabIndex = 1;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityTextBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(63, 398);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(190, 23);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressTextBox_Validating);
            this.addressTextBox.Validated += new System.EventHandler(this.addressTextBox_Validated);
            // 
            // szűrésTextBox
            // 
            this.szűrésTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.szűrésTextBox.CausesValidation = false;
            this.szűrésTextBox.Location = new System.Drawing.Point(482, 73);
            this.szűrésTextBox.Name = "szűrésTextBox";
            this.szűrésTextBox.Size = new System.Drawing.Size(488, 23);
            this.szűrésTextBox.TabIndex = 1;
            this.szűrésTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.CausesValidation = false;
            this.buttonDelete.Location = new System.Drawing.Point(299, 73);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(175, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete current Customer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.szűrésTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1000, 700);
            this.Load += new System.EventHandler(this.CustomerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Button button1;
        private ListBox listBox1;
        private Label label2;
        private TextBox emailTextBox;
        private Label label3;
        private TextBox cityTextBox;
        private Label label4;
        private TextBox addressTextBox;
        private TextBox szűrésTextBox;
        private Button buttonDelete;
        private ErrorProvider errorProvider1;
    }
}
