namespace RecapProject1
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
            this.gbxkategori = new System.Windows.Forms.GroupBox();
            this.lblkategori = new System.Windows.Forms.Label();
            this.cbxkategori = new System.Windows.Forms.ComboBox();
            this.gbxisim = new System.Windows.Forms.GroupBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgwproduct = new System.Windows.Forms.DataGridView();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.gbxkategori.SuspendLayout();
            this.gbxisim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxkategori
            // 
            this.gbxkategori.Controls.Add(this.lblkategori);
            this.gbxkategori.Controls.Add(this.cbxkategori);
            this.gbxkategori.Location = new System.Drawing.Point(52, 14);
            this.gbxkategori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxkategori.Name = "gbxkategori";
            this.gbxkategori.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxkategori.Size = new System.Drawing.Size(713, 115);
            this.gbxkategori.TabIndex = 0;
            this.gbxkategori.TabStop = false;
            this.gbxkategori.Text = "Kategoriye Göre Ara";
            // 
            // lblkategori
            // 
            this.lblkategori.AutoSize = true;
            this.lblkategori.Location = new System.Drawing.Point(49, 50);
            this.lblkategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(61, 15);
            this.lblkategori.TabIndex = 2;
            this.lblkategori.Text = "Kategori";
            // 
            // cbxkategori
            // 
            this.cbxkategori.FormattingEnabled = true;
            this.cbxkategori.Location = new System.Drawing.Point(178, 42);
            this.cbxkategori.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxkategori.Name = "cbxkategori";
            this.cbxkategori.Size = new System.Drawing.Size(513, 23);
            this.cbxkategori.TabIndex = 0;
            this.cbxkategori.SelectedIndexChanged += new System.EventHandler(this.cbxkategori_SelectedIndexChanged);
            // 
            // gbxisim
            // 
            this.gbxisim.Controls.Add(this.tbxsearch);
            this.gbxisim.Controls.Add(this.lblsearch);
            this.gbxisim.Location = new System.Drawing.Point(52, 164);
            this.gbxisim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxisim.Name = "gbxisim";
            this.gbxisim.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxisim.Size = new System.Drawing.Size(713, 115);
            this.gbxisim.TabIndex = 0;
            this.gbxisim.TabStop = false;
            this.gbxisim.Text = "Ürün İsmine Göre Ara";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(49, 53);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(28, 15);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Ara";
            // 
            // dgwproduct
            // 
            this.dgwproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwproduct.Location = new System.Drawing.Point(52, 294);
            this.dgwproduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwproduct.Name = "dgwproduct";
            this.dgwproduct.Size = new System.Drawing.Size(712, 173);
            this.dgwproduct.TabIndex = 3;
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(178, 53);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(513, 21);
            this.tbxsearch.TabIndex = 3;
            this.tbxsearch.TextChanged += new System.EventHandler(this.tbxsearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 519);
            this.Controls.Add(this.dgwproduct);
            this.Controls.Add(this.gbxisim);
            this.Controls.Add(this.gbxkategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxkategori.ResumeLayout(false);
            this.gbxkategori.PerformLayout();
            this.gbxisim.ResumeLayout(false);
            this.gbxisim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxkategori;
        private System.Windows.Forms.Label lblkategori;
        private System.Windows.Forms.ComboBox cbxkategori;
        private System.Windows.Forms.GroupBox gbxisim;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgwproduct;
        private System.Windows.Forms.TextBox tbxsearch;
    }
}

