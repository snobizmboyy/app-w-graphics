namespace CounterApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCounter = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // labelCounter
            this.labelCounter.Font = new System.Drawing.Font("Arial", 24F);
            this.labelCounter.Location = new System.Drawing.Point(130, 30);
            this.labelCounter.Size = new System.Drawing.Size(100, 40);
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnPlus
            this.btnPlus.Text = "+";
            this.btnPlus.Location = new System.Drawing.Point(80, 100);
            this.btnPlus.Size = new System.Drawing.Size(60, 40);
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);

            // btnMinus
            this.btnMinus.Text = "-";
            this.btnMinus.Location = new System.Drawing.Point(180, 100);
            this.btnMinus.Size = new System.Drawing.Size(60, 40);
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Text = "Counter App";

            this.ResumeLayout(false);
        }
    }
}