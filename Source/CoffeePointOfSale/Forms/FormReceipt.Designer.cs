namespace CoffeePointOfSale.Forms
{
    partial class FormReceipt
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
            this.bReturnToFormMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bReturnToFormMain
            // 
            this.bReturnToFormMain.Location = new System.Drawing.Point(1181, 650);
            this.bReturnToFormMain.Name = "bReturnToFormMain";
            this.bReturnToFormMain.Size = new System.Drawing.Size(115, 38);
            this.bReturnToFormMain.TabIndex = 0;
            this.bReturnToFormMain.Text = "Exit";
            this.bReturnToFormMain.UseVisualStyleBackColor = true;
            this.bReturnToFormMain.Click += new System.EventHandler(this.bReturnToFormMain_Click);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.bReturnToFormMain);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToFormMain;
    }
}