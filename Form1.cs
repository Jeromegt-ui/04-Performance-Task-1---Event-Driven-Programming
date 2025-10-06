namespace _04TaskPerformance1_100625
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            Console.WriteLine("-Thread Starts-");

            lblThread.Text = "Status: Running...";
            Thread[] threads = { threadA, threadB, threadC, threadD };
            foreach (var t in threads) t.Start();

            Task.Run(() =>
            {
                foreach (var t in threads) t.Join();

                Console.WriteLine("-End of Thread-");

                this.BeginInvoke((Action)(() =>
                {
                    lblThread.Text = "-End Of Thread-";
                }));
            });
        }

    }
}

