namespace MultiSprite
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutPut = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputAtlas = new System.Windows.Forms.TextBox();
            this.btnInputAtlas = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(736, 248);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Browser";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Location = new System.Drawing.Point(736, 344);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(75, 23);
            this.btnOutPut.TabIndex = 2;
            this.btnOutPut.Text = "Browser";
            this.btnOutPut.UseVisualStyleBackColor = true;
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(141, 251);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(537, 20);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(141, 347);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(475, 20);
            this.txtOutPut.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "InPut Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OutPut";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(361, 373);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(169, 59);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Splist";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInputAtlas
            // 
            this.txtInputAtlas.Location = new System.Drawing.Point(141, 302);
            this.txtInputAtlas.Name = "txtInputAtlas";
            this.txtInputAtlas.Size = new System.Drawing.Size(537, 20);
            this.txtInputAtlas.TabIndex = 9;
            // 
            // btnInputAtlas
            // 
            this.btnInputAtlas.Location = new System.Drawing.Point(736, 299);
            this.btnInputAtlas.Name = "btnInputAtlas";
            this.btnInputAtlas.Size = new System.Drawing.Size(75, 23);
            this.btnInputAtlas.TabIndex = 8;
            this.btnInputAtlas.Text = "Browser";
            this.btnInputAtlas.UseVisualStyleBackColor = true;
            this.btnInputAtlas.Click += new System.EventHandler(this.btnInputAtlas_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(644, 344);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 11;
            this.btnClearOutput.Text = "Clear ouput";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 420);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputAtlas);
            this.Controls.Add(this.btnInputAtlas);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOutPut);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutPut;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputAtlas;
        private System.Windows.Forms.Button btnInputAtlas;
        private System.Windows.Forms.Button btnClearOutput;
    }
}

