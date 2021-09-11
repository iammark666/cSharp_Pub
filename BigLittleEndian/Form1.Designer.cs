namespace BigLittleEndian
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
            this.BigEndian = new System.Windows.Forms.TextBox();
            this.LittleEndian = new System.Windows.Forms.TextBox();
            this.Label_BigEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Big2Lit = new System.Windows.Forms.Button();
            this.Lit2Big = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BigEndian
            // 
            this.BigEndian.Location = new System.Drawing.Point(97, 95);
            this.BigEndian.Multiline = true;
            this.BigEndian.Name = "BigEndian";
            this.BigEndian.Size = new System.Drawing.Size(213, 238);
            this.BigEndian.TabIndex = 0;
            this.BigEndian.TextChanged += new System.EventHandler(this.BigEndian_TextChanged);
            // 
            // LittleEndian
            // 
            this.LittleEndian.Location = new System.Drawing.Point(485, 95);
            this.LittleEndian.Multiline = true;
            this.LittleEndian.Name = "LittleEndian";
            this.LittleEndian.Size = new System.Drawing.Size(210, 238);
            this.LittleEndian.TabIndex = 0;
            this.LittleEndian.TextChanged += new System.EventHandler(this.LittleEndian_TextChanged);
            // 
            // Label_BigEnd
            // 
            this.Label_BigEnd.AutoSize = true;
            this.Label_BigEnd.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_BigEnd.Location = new System.Drawing.Point(170, 62);
            this.Label_BigEnd.Name = "Label_BigEnd";
            this.Label_BigEnd.Size = new System.Drawing.Size(80, 16);
            this.Label_BigEnd.TabIndex = 1;
            this.Label_BigEnd.Text = "BigEndian";
            this.Label_BigEnd.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(533, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LittleEndian";
            // 
            // Big2Lit
            // 
            this.Big2Lit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Big2Lit.Location = new System.Drawing.Point(357, 135);
            this.Big2Lit.Name = "Big2Lit";
            this.Big2Lit.Size = new System.Drawing.Size(75, 45);
            this.Big2Lit.TabIndex = 2;
            this.Big2Lit.Text = "Big2Lit";
            this.Big2Lit.UseVisualStyleBackColor = true;
            this.Big2Lit.Click += new System.EventHandler(this.Big2Lit_Click);
            // 
            // Lit2Big
            // 
            this.Lit2Big.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lit2Big.Location = new System.Drawing.Point(357, 224);
            this.Lit2Big.Name = "Lit2Big";
            this.Lit2Big.Size = new System.Drawing.Size(75, 41);
            this.Lit2Big.TabIndex = 2;
            this.Lit2Big.Text = "Lit2Big";
            this.Lit2Big.UseVisualStyleBackColor = true;
            this.Lit2Big.Click += new System.EventHandler(this.Lit2Big_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 435);
            this.Controls.Add(this.Lit2Big);
            this.Controls.Add(this.Big2Lit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label_BigEnd);
            this.Controls.Add(this.LittleEndian);
            this.Controls.Add(this.BigEndian);
            this.Name = "Form1";
            this.Text = "BigLitEndianTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BigEndian;
        private System.Windows.Forms.TextBox LittleEndian;
        private System.Windows.Forms.Label Label_BigEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Big2Lit;
        private System.Windows.Forms.Button Lit2Big;
    }
}

