///Name: Syed Ahmed
///ID: 100766016
/// Date: 15th July, 2022

namespace AverarageUnitShippedByEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        // variables
      public  int[,] employeeUnitShipped = new int[3, 7];
        public int index = 0;
        public int runningTotal = 0;
        public double averageE1;
        public double averageE2;
        public double averageE3;
        public double totalAverage;
        public int outterLoop=0;
        public int innerLoop = 0;
        public bool validation = true;


        /// <summary>
        /// Enter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //int[,] employeeUnitShipped[2, 6];
            // int[,] employeeUnitShipped = new int[2, 6];

            validation = Int32.TryParse(tb_units.Text, out employeeUnitShipped[outterLoop, innerLoop]);
           // validation = Int32.TryParse{tb_units.Text, employeeUnitShipped[0, 1]{ });

            if(validation)
            {
                if (employeeUnitShipped[outterLoop,innerLoop] <= 1000 && employeeUnitShipped[outterLoop,innerLoop] >= 0)
                {
                    runningTotal += employeeUnitShipped[outterLoop, innerLoop];

                    if (outterLoop <= 0 && innerLoop <= 6)
                    {
                        mtb_employee1units.Text += employeeUnitShipped[outterLoop, innerLoop].ToString() + "\r\n";

                        innerLoop++;
                        index++;
                        lbl_days.Text = "Day " + (innerLoop + 1).ToString();
                        tb_units.Clear();

                        if (index >= 7)
                        {
                            averageE1 = runningTotal / 7;

                            tb_AvOfEmployee1.Text = "Average is: " + Math.Round(averageE1, 2).ToString();
                            totalAverage += averageE1;
                            label1.Font = new Font(label1.Font, FontStyle.Regular);
                            runningTotal = 0;
                            outterLoop++;
                            innerLoop = 0;
                            index = 0;
                            lbl_days.Text = "Day " + (innerLoop + 1).ToString();
                            label3.Font = new Font(label3.Font, FontStyle.Bold);

                        }

                    }

                    else if (outterLoop <= 1 && innerLoop <= 6)
                    {
                        mtb_employee2units.Text += employeeUnitShipped[outterLoop, innerLoop].ToString() + "\r\n";
                        innerLoop++;
                        index++;
                        lbl_days.Text = "Day " + (innerLoop + 1).ToString();
                        tb_units.Clear();

                        if (index >= 7)
                        {
                            averageE2 = runningTotal / 7;
                            tb_AvOfEmployee2.Text = "Average is: " + Math.Round(averageE2, 2).ToString();
                            totalAverage += averageE2;
                            runningTotal = 0;
                            outterLoop += 1;
                            innerLoop = 0;
                            index = 0;
                            lbl_days.Text = "Day " + (innerLoop + 1).ToString();
                            label3.Font = new Font(label3.Font, FontStyle.Regular);
                            label4.Font = new Font(label4.Font, FontStyle.Bold);

                        }

                    }

                    else if (outterLoop <= 2 && innerLoop <= 6)
                    {
                        mtb_employee3units.Text += employeeUnitShipped[outterLoop, innerLoop].ToString() + "\r\n";
                        innerLoop++;
                        index++;
                        lbl_days.Text = "Day " + (innerLoop + 1).ToString();
                        tb_units.Clear();
                        if (index >= 7)
                        {
                            averageE3 = runningTotal / 7;
                            tb_AvOfEmployee3.Text = "Average is: " + Math.Round(averageE3, 2).ToString();
                            runningTotal = 0;
                            lbl_days.Text = "Done";
                            totalAverage = (averageE1 + averageE2 + averageE3) / 3;
                            tb_AvOfEmployees.Text = "Average per day: " + Math.Round(totalAverage, 2).ToString();

                            btn_Enter.Enabled = false;
                            tb_units.ReadOnly = true;
                            innerLoop = 0;

                        }


                    }


                   
                }
                else
                {
                    MessageBox.Show("Units must be between 0 and 1000!");
                    tb_units.Clear();

                }
            }
            else
            {
                MessageBox.Show("PLease Enter a valid number!");
            }

        }
        /// <summary>
        /// Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_units.ReadOnly = false;
            btn_Enter.Enabled = true;

            mtb_employee1units.Clear();
            mtb_employee2units.Clear();
            mtb_employee3units.Clear();

            outterLoop = 0;
            innerLoop = 0;
            averageE1 = 0;
            averageE2 = 0;
            averageE3 = 0;

            lbl_days.Text = "Day " + (innerLoop + 1).ToString();
            tb_AvOfEmployee1.Clear();
            tb_AvOfEmployee2.Clear();
            tb_AvOfEmployee3.Clear();

            index = 0;
            totalAverage = 0;
            tb_AvOfEmployees.Clear();
            runningTotal = 0;

            label3.Font = new Font(label3.Font, FontStyle.Regular);
            label4.Font = new Font(label4.Font, FontStyle.Regular);
            label1.Font = new Font(label1.Font, FontStyle.Bold);

        }
    }
}