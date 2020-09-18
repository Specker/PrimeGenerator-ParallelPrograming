using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PrimeGenerator_ParallelPrograming
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LengthStartNUD.Maximum = (int)LengthEndNUD.Value - 1;
            PrimeGenerator primeGenerator = new PrimeGenerator();
            label1.Text = "List size: " + 0;
            
            
        }

        private void SequencialBTN_Click(object sender, EventArgs e)
        {
            var uictx = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {   
                return PrimeGenerator.GetPrimesSequential((long)LengthStartNUD.Value, (long)LengthEndNUD.Value, this); 
            }
            ).ContinueWith((antecedent) =>
            {
                label1.Text = "List size: " + antecedent.Result.Count;
                listBox1.DataSource = antecedent.Result;
            },
            uictx);
            
        }
        private void ParallelBTN_Click(object sender, EventArgs e)
        {
            var uictx = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Factory.StartNew(() =>
            {
                return PrimeGenerator.GetPrimesParallel((long)LengthStartNUD.Value, (long)LengthEndNUD.Value, this);
                
            }
            ).ContinueWith((antecedent) =>
            {
                label1.Text = "List size: " + antecedent.Result.Count;
                listBox1.DataSource = antecedent.Result;
            },
            uictx);
        }

        private void LengthNUD_ValueChanged(object sender, EventArgs e)
        {
            LengthStartNUD.Maximum = (int)LengthEndNUD.Value - 1;
        }

        public void TimeStampsTXTUpdate(long start, long end,string processType,long timestamp)
        {
            if (TimeStampsTXT.InvokeRequired)
            {
                TimeStampsTXT.Invoke(new MethodInvoker(delegate 
                { 
                    TimeStampsTXT.Text = TimeStampsTXT.Text + Environment.NewLine + start + "-" + end + " " + processType + " took " + ": " + TimeSpan.FromMilliseconds(timestamp).TotalSeconds + " sec"; }
                ));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
