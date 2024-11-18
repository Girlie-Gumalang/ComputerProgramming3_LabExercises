using System;
using System.Threading;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        // Declaring 4 threads
        private Thread threadA, threadB, threadC, threadD;   
        public frmTrackThread()
        {
            InitializeComponent();
            // Initialize threads with methods to run and assign names
            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread2);
            threadC = new Thread(MyThreadClass.Thread1);
            threadD = new Thread(MyThreadClass.Thread2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display starting message in label and console
            label1.Text = "- Thread Starts -";
            Console.WriteLine("- Thread Starts-");

            // Assign names to the threads for better identification
            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            // Set thread priorities
            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            // Start threads
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            // Wait for all threads to complete
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            // Indicate threads have finished
            label1.Text = "- End Of Thread -";
            Console.WriteLine("-End of Thread-");
        }
    }
}