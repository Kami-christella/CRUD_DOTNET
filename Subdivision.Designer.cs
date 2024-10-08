namespace SHEILLA
{
    partial class Subdivision
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.plotnoTXT = new System.Windows.Forms.TextBox();
            this.plotsTXT = new System.Windows.Forms.TextBox();
            this.sizeTXT = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.registerBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.searchBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.landcombo = new System.Windows.Forms.ComboBox();
            this.dgviewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subdivision Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plot No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Land";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size Of Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total No Of Plots";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // plotnoTXT
            // 
            this.plotnoTXT.Location = new System.Drawing.Point(25, 150);
            this.plotnoTXT.Name = "plotnoTXT";
            this.plotnoTXT.Size = new System.Drawing.Size(314, 26);
            this.plotnoTXT.TabIndex = 6;
            // 
            // plotsTXT
            // 
            this.plotsTXT.Location = new System.Drawing.Point(25, 313);
            this.plotsTXT.Name = "plotsTXT";
            this.plotsTXT.Size = new System.Drawing.Size(314, 26);
            this.plotsTXT.TabIndex = 8;
            this.plotsTXT.TextChanged += new System.EventHandler(this.plotsTXT_TextChanged);
            // 
            // sizeTXT
            // 
            this.sizeTXT.Location = new System.Drawing.Point(25, 395);
            this.sizeTXT.Name = "sizeTXT";
            this.sizeTXT.Size = new System.Drawing.Size(314, 26);
            this.sizeTXT.TabIndex = 9;
            this.sizeTXT.TextChanged += new System.EventHandler(this.sizeTXT_TextChanged);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(25, 484);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(314, 26);
            this.pricetxt.TabIndex = 10;
            this.pricetxt.TextChanged += new System.EventHandler(this.pricetxt_TextChanged);
            // 
            // registerBTN
            // 
            this.registerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBTN.Location = new System.Drawing.Point(391, 359);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(164, 48);
            this.registerBTN.TabIndex = 11;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Location = new System.Drawing.Point(391, 439);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(164, 48);
            this.updateBTN.TabIndex = 12;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Location = new System.Drawing.Point(391, 520);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(164, 48);
            this.deleteBTN.TabIndex = 13;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBTN.Location = new System.Drawing.Point(391, 233);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(164, 48);
            this.searchBTN.TabIndex = 14;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(386, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter Plot No";
            // 
            // searchTXT
            // 
            this.searchTXT.Location = new System.Drawing.Point(391, 180);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(178, 26);
            this.searchTXT.TabIndex = 17;
            // 
            // landcombo
            // 
            this.landcombo.FormattingEnabled = true;
            this.landcombo.Items.AddRange(new object[] {
            "Rusororo",
            "Kicukiro",
            "Gatenga"});
            this.landcombo.Location = new System.Drawing.Point(25, 251);
            this.landcombo.Name = "landcombo";
            this.landcombo.Size = new System.Drawing.Size(305, 28);
            this.landcombo.TabIndex = 18;
            // 
            // dgviewData
            // 
            this.dgviewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewData.Location = new System.Drawing.Point(575, 100);
            this.dgviewData.Name = "dgviewData";
            this.dgviewData.RowHeadersWidth = 62;
            this.dgviewData.RowTemplate.Height = 28;
            this.dgviewData.Size = new System.Drawing.Size(823, 505);
            this.dgviewData.TabIndex = 19;
            // 
            // Subdivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 611);
            this.Controls.Add(this.dgviewData);
            this.Controls.Add(this.landcombo);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.sizeTXT);
            this.Controls.Add(this.plotsTXT);
            this.Controls.Add(this.plotnoTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Subdivision";
            this.Text = "Subdivision";
            this.Load += new System.EventHandler(this.Subdivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox plotnoTXT;
        private System.Windows.Forms.TextBox plotsTXT;
        private System.Windows.Forms.TextBox sizeTXT;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.ComboBox landcombo;
        private System.Windows.Forms.DataGridView dgviewData;
    }
}