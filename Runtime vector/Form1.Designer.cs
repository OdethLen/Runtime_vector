namespace Runtime_vector
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
            btnCreatevector = new Button();
            txtSize = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNumber = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnCreatevector
            // 
            btnCreatevector.Location = new Point(117, 103);
            btnCreatevector.Name = "btnCreatevector";
            btnCreatevector.Size = new Size(75, 23);
            btnCreatevector.TabIndex = 0;
            btnCreatevector.Text = "Create";
            btnCreatevector.UseVisualStyleBackColor = true;
            btnCreatevector.Click += btnCreatevector_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(152, 63);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 66);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Vector size ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 149);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(152, 146);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(117, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 291);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSize);
            Controls.Add(btnCreatevector);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreatevector;
        private TextBox txtSize;
        private Label label1;
        private Label label2;
        private TextBox txtNumber;
        private Button btnAdd;
    }
}
