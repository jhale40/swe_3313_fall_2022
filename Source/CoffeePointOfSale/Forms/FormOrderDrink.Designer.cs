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
            this.bCoffee = new System.Windows.Forms.Button();
            this.bEspresso = new System.Windows.Forms.Button();
            this.bIcedLatte = new System.Windows.Forms.Button();
            this.bGreenTea = new System.Windows.Forms.Button();
            this.b_IcedWater = new System.Windows.Forms.Button();
            this.bLatte = new System.Windows.Forms.Button();
            this.bAddToOrder = new System.Windows.Forms.Button();
            this.bPay = new System.Windows.Forms.Button();
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
            // bCoffee
            // 
            this.bCoffee.Location = new System.Drawing.Point(22, 48);
            this.bCoffee.Name = "bCoffee";
            this.bCoffee.Size = new System.Drawing.Size(283, 73);
            this.bCoffee.TabIndex = 2;
            this.bCoffee.Text = "Coffee";
            this.bCoffee.UseVisualStyleBackColor = true;
            // 
            // bEspresso
            // 
            this.bEspresso.Location = new System.Drawing.Point(22, 162);
            this.bEspresso.Name = "bEspresso";
            this.bEspresso.Size = new System.Drawing.Size(283, 73);
            this.bEspresso.TabIndex = 3;
            this.bEspresso.Text = "Espresso";
            this.bEspresso.UseVisualStyleBackColor = true;
            // 
            // bIcedLatte
            // 
            this.bIcedLatte.Location = new System.Drawing.Point(22, 268);
            this.bIcedLatte.Name = "bIcedLatte";
            this.bIcedLatte.Size = new System.Drawing.Size(283, 73);
            this.bIcedLatte.TabIndex = 4;
            this.bIcedLatte.Text = "Iced Latte";
            this.bIcedLatte.UseVisualStyleBackColor = true;
            // 
            // bGreenTea
            // 
            this.bGreenTea.Location = new System.Drawing.Point(22, 375);
            this.bGreenTea.Name = "bGreenTea";
            this.bGreenTea.Size = new System.Drawing.Size(283, 73);
            this.bGreenTea.TabIndex = 5;
            this.bGreenTea.Text = "Iced Matcha Green Tea Latte";
            this.bGreenTea.UseVisualStyleBackColor = true;
            // 
            // b_IcedWater
            // 
            this.b_IcedWater.Location = new System.Drawing.Point(22, 494);
            this.b_IcedWater.Name = "b_IcedWater";
            this.b_IcedWater.Size = new System.Drawing.Size(283, 73);
            this.b_IcedWater.TabIndex = 6;
            this.b_IcedWater.Text = "Iced Water";
            this.b_IcedWater.UseVisualStyleBackColor = true;
            // 
            // bLatte
            // 
            this.bLatte.Location = new System.Drawing.Point(22, 596);
            this.bLatte.Name = "bLatte";
            this.bLatte.Size = new System.Drawing.Size(283, 73);
            this.bLatte.TabIndex = 7;
            this.bLatte.Text = "Latte";
            this.bLatte.UseVisualStyleBackColor = true;
            // 
            // bAddToOrder
            // 
            this.bAddToOrder.Location = new System.Drawing.Point(426, 610);
            this.bAddToOrder.Name = "bAddToOrder";
            this.bAddToOrder.Size = new System.Drawing.Size(219, 59);
            this.bAddToOrder.TabIndex = 8;
            this.bAddToOrder.Text = "Add";
            this.bAddToOrder.UseVisualStyleBackColor = true;
            // 
            // bPay
            // 
            this.bPay.Location = new System.Drawing.Point(1023, 643);
            this.bPay.Name = "bPay";
            this.bPay.Size = new System.Drawing.Size(121, 38);
            this.bPay.TabIndex = 9;
            this.bPay.Text = "Pay";
            this.bPay.UseVisualStyleBackColor = true;
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.bPay);
            this.Controls.Add(this.bAddToOrder);
            this.Controls.Add(this.bLatte);
            this.Controls.Add(this.b_IcedWater);
            this.Controls.Add(this.bGreenTea);
            this.Controls.Add(this.bIcedLatte);
            this.Controls.Add(this.bEspresso);
            this.Controls.Add(this.bCoffee);
            this.Controls.Add(this.bReturnToMain);
            this.Name = "FormOrderDrink";
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bReturnToMain;
        private Button bCoffee;
        private Button bEspresso;
        private Button bIcedLatte;
        private Button bGreenTea;
        private Button b_IcedWater;
        private Button bLatte;
        private Button bAddToOrder;
        private Button bPay;
    }
}