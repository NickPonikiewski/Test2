namespace Budget2._0
{
    partial class LogIn
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
            this.components = new System.ComponentModel.Container();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNameBox = new System.Windows.Forms.TextBox();
            this.AccountIDBox = new System.Windows.Forms.TextBox();
            this.budgetDatabaseDataSet = new Budget2._0.BudgetDatabaseDataSet();
            this.budgetDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInbutton
            // 
            this.LogInbutton.Location = new System.Drawing.Point(178, 69);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 23);
            this.LogInbutton.TabIndex = 0;
            this.LogInbutton.Text = "Login";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account ID: ";
            // 
            // AccountNameBox
            // 
            this.AccountNameBox.Location = new System.Drawing.Point(103, 13);
            this.AccountNameBox.Name = "AccountNameBox";
            this.AccountNameBox.Size = new System.Drawing.Size(150, 20);
            this.AccountNameBox.TabIndex = 3;
            // 
            // AccountIDBox
            // 
            this.AccountIDBox.Location = new System.Drawing.Point(103, 43);
            this.AccountIDBox.Name = "AccountIDBox";
            this.AccountIDBox.Size = new System.Drawing.Size(150, 20);
            this.AccountIDBox.TabIndex = 4;
            // 
            // budgetDatabaseDataSet
            // 
            this.budgetDatabaseDataSet.DataSetName = "BudgetDatabaseDataSet";
            this.budgetDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetDatabaseDataSetBindingSource
            // 
            this.budgetDatabaseDataSetBindingSource.DataSource = this.budgetDatabaseDataSet;
            this.budgetDatabaseDataSetBindingSource.Position = 0;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 122);
            this.Controls.Add(this.AccountIDBox);
            this.Controls.Add(this.AccountNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInbutton);
            this.Name = "LogIn";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountNameBox;
        private System.Windows.Forms.TextBox AccountIDBox;
        private System.Windows.Forms.BindingSource budgetDatabaseDataSetBindingSource;
        private BudgetDatabaseDataSet budgetDatabaseDataSet;
    }
}

