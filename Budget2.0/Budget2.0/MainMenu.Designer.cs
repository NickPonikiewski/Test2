namespace Budget2._0
{
    partial class MainMenu
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
            this.Transactionbutton = new System.Windows.Forms.Button();
            this.Budgetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Transactionbutton
            // 
            this.Transactionbutton.Location = new System.Drawing.Point(72, 37);
            this.Transactionbutton.Name = "Transactionbutton";
            this.Transactionbutton.Size = new System.Drawing.Size(75, 23);
            this.Transactionbutton.TabIndex = 0;
            this.Transactionbutton.Text = "Transaction";
            this.Transactionbutton.UseVisualStyleBackColor = true;
            this.Transactionbutton.Click += new System.EventHandler(this.Transactionbutton_Click);
            // 
            // Budgetbutton
            // 
            this.Budgetbutton.Location = new System.Drawing.Point(72, 79);
            this.Budgetbutton.Name = "Budgetbutton";
            this.Budgetbutton.Size = new System.Drawing.Size(75, 23);
            this.Budgetbutton.TabIndex = 1;
            this.Budgetbutton.Text = "Budget";
            this.Budgetbutton.UseVisualStyleBackColor = true;
            this.Budgetbutton.Click += new System.EventHandler(this.Budgetbutton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 204);
            this.Controls.Add(this.Budgetbutton);
            this.Controls.Add(this.Transactionbutton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Transactionbutton;
        private System.Windows.Forms.Button Budgetbutton;
    }
}