namespace Pricing
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_strikePrice = new System.Windows.Forms.TextBox();
            this.tb_timeToMaturity = new System.Windows.Forms.TextBox();
            this.tb_standardDeviation = new System.Windows.Forms.TextBox();
            this.tb_risk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.l_d1 = new System.Windows.Forms.Label();
            this.l_d2 = new System.Windows.Forms.Label();
            this.l_call = new System.Windows.Forms.Label();
            this.l_put = new System.Windows.Forms.Label();
            this.tb_stockPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_strikePrice
            // 
            this.tb_strikePrice.Location = new System.Drawing.Point(321, 126);
            this.tb_strikePrice.Name = "tb_strikePrice";
            this.tb_strikePrice.Size = new System.Drawing.Size(158, 31);
            this.tb_strikePrice.TabIndex = 1;
            this.tb_strikePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_strikePrice_KeyPress);
            // 
            // tb_timeToMaturity
            // 
            this.tb_timeToMaturity.Location = new System.Drawing.Point(321, 180);
            this.tb_timeToMaturity.Name = "tb_timeToMaturity";
            this.tb_timeToMaturity.Size = new System.Drawing.Size(158, 31);
            this.tb_timeToMaturity.TabIndex = 2;
            this.tb_timeToMaturity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_timeToMaturity_KeyPress);
            // 
            // tb_standardDeviation
            // 
            this.tb_standardDeviation.Location = new System.Drawing.Point(321, 232);
            this.tb_standardDeviation.Name = "tb_standardDeviation";
            this.tb_standardDeviation.Size = new System.Drawing.Size(158, 31);
            this.tb_standardDeviation.TabIndex = 3;
            this.tb_standardDeviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_standardDeviation_KeyPress);
            // 
            // tb_risk
            // 
            this.tb_risk.Location = new System.Drawing.Point(321, 292);
            this.tb_risk.Name = "tb_risk";
            this.tb_risk.Size = new System.Drawing.Size(158, 31);
            this.tb_risk.TabIndex = 4;
            this.tb_risk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_risk_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stock Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Strike Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time to maturity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Standard Deviation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Risk";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Option Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_d1
            // 
            this.l_d1.AutoSize = true;
            this.l_d1.Location = new System.Drawing.Point(64, 463);
            this.l_d1.Name = "l_d1";
            this.l_d1.Size = new System.Drawing.Size(54, 25);
            this.l_d1.TabIndex = 11;
            this.l_d1.Text = "d1 : ";
            // 
            // l_d2
            // 
            this.l_d2.AutoSize = true;
            this.l_d2.Location = new System.Drawing.Point(64, 500);
            this.l_d2.Name = "l_d2";
            this.l_d2.Size = new System.Drawing.Size(54, 25);
            this.l_d2.TabIndex = 12;
            this.l_d2.Text = "d2 : ";
            // 
            // l_call
            // 
            this.l_call.AutoSize = true;
            this.l_call.Location = new System.Drawing.Point(64, 541);
            this.l_call.Name = "l_call";
            this.l_call.Size = new System.Drawing.Size(57, 25);
            this.l_call.TabIndex = 13;
            this.l_call.Text = "call :";
            // 
            // l_put
            // 
            this.l_put.AutoSize = true;
            this.l_put.Location = new System.Drawing.Point(59, 582);
            this.l_put.Name = "l_put";
            this.l_put.Size = new System.Drawing.Size(54, 25);
            this.l_put.TabIndex = 14;
            this.l_put.Text = "put :";
            // 
            // tb_stockPrice
            // 
            this.tb_stockPrice.Location = new System.Drawing.Point(321, 75);
            this.tb_stockPrice.Name = "tb_stockPrice";
            this.tb_stockPrice.Size = new System.Drawing.Size(158, 31);
            this.tb_stockPrice.TabIndex = 15;
            this.tb_stockPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stockPrice_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 628);
            this.Controls.Add(this.tb_stockPrice);
            this.Controls.Add(this.l_put);
            this.Controls.Add(this.l_call);
            this.Controls.Add(this.l_d2);
            this.Controls.Add(this.l_d1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_risk);
            this.Controls.Add(this.tb_standardDeviation);
            this.Controls.Add(this.tb_timeToMaturity);
            this.Controls.Add(this.tb_strikePrice);
            this.Name = "Form1";
            this.Text = "Option Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_strikePrice;
        private System.Windows.Forms.TextBox tb_timeToMaturity;
        private System.Windows.Forms.TextBox tb_standardDeviation;
        private System.Windows.Forms.TextBox tb_risk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_d1;
        private System.Windows.Forms.Label l_d2;
        private System.Windows.Forms.Label l_call;
        private System.Windows.Forms.Label l_put;
        private System.Windows.Forms.TextBox tb_stockPrice;
    }
}

