namespace CoffeePointOfSale.Forms
{
    partial class FormOrderDrink
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
            this.bReturnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bReturnToMain
            // 
            this.bReturnToMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bReturnToMain.Location = new System.Drawing.Point(1180, 643);
            this.bReturnToMain.Name = "bReturnToMain";
            this.bReturnToMain.Size = new System.Drawing.Size(115, 38);
            this.bReturnToMain.TabIndex = 1;
            this.bReturnToMain.Text = "Exit";
            this.bReturnToMain.UseVisualStyleBackColor = false;
            this.bReturnToMain.Click += new System.EventHandler(this.bReturnToMain_Click);
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.bReturnToMain);
            this.Name = "FormOrderDrink";
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToMain;
    }
}