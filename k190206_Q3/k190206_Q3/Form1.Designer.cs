
namespace k190206_Q3
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
            this.Category_Label = new System.Windows.Forms.Label();
            this.Category_Combo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Location = new System.Drawing.Point(61, 34);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(82, 13);
            this.Category_Label.TabIndex = 0;
            this.Category_Label.Text = "Select Category";
            this.Category_Label.Click += new System.EventHandler(this.Category_Label_Click);
            // 
            // Category_Combo
            // 
            this.Category_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_Combo.FormattingEnabled = true;
            this.Category_Combo.Location = new System.Drawing.Point(165, 31);
            this.Category_Combo.Name = "Category_Combo";
            this.Category_Combo.Size = new System.Drawing.Size(121, 21);
            this.Category_Combo.TabIndex = 1;
            this.Category_Combo.SelectedIndexChanged += new System.EventHandler(this.Category_Combo_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 283);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(399, 29);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(75, 23);
            this.btn_reload.TabIndex = 3;
            this.btn_reload.Text = "Reload";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Category_Combo);
            this.Controls.Add(this.Category_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.ComboBox Category_Combo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reload;
    }
}

