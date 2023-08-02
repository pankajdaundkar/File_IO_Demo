namespace FileIO_Demo
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
            this.butcreatefolder = new System.Windows.Forms.Button();
            this.butcreatefile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproid = new System.Windows.Forms.TextBox();
            this.txtpropri = new System.Windows.Forms.TextBox();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.btnwritefile = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butcreatefolder
            // 
            this.butcreatefolder.Location = new System.Drawing.Point(40, 34);
            this.butcreatefolder.Name = "butcreatefolder";
            this.butcreatefolder.Size = new System.Drawing.Size(173, 41);
            this.butcreatefolder.TabIndex = 0;
            this.butcreatefolder.Text = "Create Folder";
            this.butcreatefolder.UseVisualStyleBackColor = true;
            this.butcreatefolder.Click += new System.EventHandler(this.butcreatefolder_Click);
            // 
            // butcreatefile
            // 
            this.butcreatefile.Location = new System.Drawing.Point(250, 34);
            this.butcreatefile.Name = "butcreatefile";
            this.butcreatefile.Size = new System.Drawing.Size(170, 41);
            this.butcreatefile.TabIndex = 1;
            this.butcreatefile.Text = "Create File";
            this.butcreatefile.UseVisualStyleBackColor = true;
            this.butcreatefile.Click += new System.EventHandler(this.butcreatefile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name";
            // 
            // txtproid
            // 
            this.txtproid.Location = new System.Drawing.Point(297, 127);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(165, 20);
            this.txtproid.TabIndex = 5;
            // 
            // txtpropri
            // 
            this.txtpropri.Location = new System.Drawing.Point(297, 244);
            this.txtpropri.Name = "txtpropri";
            this.txtpropri.Size = new System.Drawing.Size(165, 20);
            this.txtpropri.TabIndex = 6;
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(297, 178);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(165, 20);
            this.txtproname.TabIndex = 7;
            // 
            // btnwritefile
            // 
            this.btnwritefile.Location = new System.Drawing.Point(198, 322);
            this.btnwritefile.Name = "btnwritefile";
            this.btnwritefile.Size = new System.Drawing.Size(93, 37);
            this.btnwritefile.TabIndex = 8;
            this.btnwritefile.Text = "Write to File";
            this.btnwritefile.UseVisualStyleBackColor = true;
            this.btnwritefile.Click += new System.EventHandler(this.btnwritefile_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(386, 322);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(87, 37);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwritefile);
            this.Controls.Add(this.txtproname);
            this.Controls.Add(this.txtpropri);
            this.Controls.Add(this.txtproid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butcreatefile);
            this.Controls.Add(this.butcreatefolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butcreatefolder;
        private System.Windows.Forms.Button butcreatefile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.TextBox txtpropri;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.Button btnwritefile;
        private System.Windows.Forms.Button btnread;
    }
}

