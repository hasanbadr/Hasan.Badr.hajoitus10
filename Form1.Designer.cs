namespace Hasan.Badr.hajoitus10
{
    partial class BMIForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            painaTB = new TextBox();
            pituusTB = new TextBox();
            LaskeBT = new Button();
            VastusLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // painaTB
            // 
            painaTB.Location = new Point(131, 9);
            painaTB.Name = "painaTB";
            painaTB.Size = new Size(100, 33);
            painaTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(131, 47);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(100, 33);
            pituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(12, 88);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(219, 43);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VastusLB
            // 
            VastusLB.AutoSize = true;
            VastusLB.Location = new Point(10, 134);
            VastusLB.Name = "VastusLB";
            VastusLB.Size = new Size(76, 25);
            VastusLB.TabIndex = 5;
            VastusLB.Text = "Vastaus";
            VastusLB.Visible = false;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(12, 168);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(72, 25);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "Kuvaus";
            KuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 218);
            Controls.Add(KuvausLB);
            Controls.Add(VastusLB);
            Controls.Add(LaskeBT);
            Controls.Add(pituusTB);
            Controls.Add(painaTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "BMIForm";
            Text = "BMI-laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painaTB;
        private TextBox pituusTB;
        private Button LaskeBT;
        private Label VastusLB;
        private Label KuvausLB;
    }
}