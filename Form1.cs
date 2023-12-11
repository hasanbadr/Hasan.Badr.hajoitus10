namespace Hasan.Badr.hajoitus10
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painaTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double BMI = Math.Round(paino / (pituus * pituus), 2);
            if (BMI < 18.5)
            {
                VastusLB.Text = " painondeksisi on: " + BMI;
                VastusLB.ForeColor = Color.Red;
                KuvausLB.Text = " Alipaino ";
                KuvausLB.ForeColor = Color.Red;
                KuvausLB.Visible = true;
                VastusLB.Visible = true;
            }
            else if (BMI < 25)
            {
                VastusLB.Text = " painondeksisi on: " + BMI;
                VastusLB.ForeColor = Color.Green;
                KuvausLB.Text = " Normaalipaino ";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
                VastusLB.Visible = true;

            }
            else if (BMI < 40)
            {
                VastusLB.Text = " painondeksisi on: " + BMI;
                VastusLB.ForeColor = Color.Blue;
                KuvausLB.Text = " Ylipaino ";
                KuvausLB.ForeColor = Color.Blue;
                KuvausLB.Visible = true;
                VastusLB.Visible = true;

            }
            else 
            {
                VastusLB.Text = " painoindeksisi on: " + BMI;
                VastusLB.ForeColor = Color.Gold;
                KuvausLB.Text = " Huomattava ylipaino ";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
                VastusLB.Visible = true;

            }
        }
    }
}