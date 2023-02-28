namespace L3B
{
    public partial class Lift : Form
    {
        ManualResetEvent ElevatorArrived = new ManualResetEvent(false);
        ManualResetEvent ElevatorLeft = new ManualResetEvent(false);

        public Lift()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Action();
        }

        public void Action() 
        {
            Thread elevator = new Thread(new ThreadStart(Elevator));
            Thread people = new Thread(new ThreadStart(People));
            elevator.Start();
            people.Start();
            ElevatorLeft.Set();
        }

        public void Elevator()
        {
            while (true)
            {
                ElevatorArrived.WaitOne();
                switch (liftBar.Value)
                {
                    case 0: parter.Checked = false; break;
                    case 1: etaj1.Checked = false; break;
                    case 2: etaj2.Checked = false; break;
                    case 3: etaj3.Checked = false; break;
                    case 4: etaj4.Checked = false; break;
                }
                Thread.Sleep(1000);
                ElevatorLeft.Set();
            }
        }

        public void People()
        {
            while (true)
            {
                ElevatorLeft.WaitOne();
                if (parter.Checked)
                {
                    liftBar.Value = 0;
                    ElevatorArrived.Set();
                }
                else if (etaj1.Checked)
                {
                    liftBar.Value = 1;
                    ElevatorArrived.Set();
                }
                else if (etaj2.Checked)
                {
                    liftBar.Value = 2;
                    ElevatorArrived.Set();
                }
                else if (etaj3.Checked)
                {
                    liftBar.Value = 3;
                    ElevatorArrived.Set();
                }
                else if (etaj4.Checked)
                {
                    liftBar.Value = 4;
                    ElevatorArrived.Set();
                }
                Thread.Sleep(1000);
            }
        }
    }
}