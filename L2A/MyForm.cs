namespace L2A
{
    public partial class MyForm : Form
    {
        Ball ball = null;
        Ball ball2 = null;
        Ball ball3 = null;
        Bitmap[] bitmaps = new Bitmap[10];
        Thread add = null;

        public MyForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.BackColor = Color.White;
            Bitmap A = new Bitmap($@"..\..\..\res\A.bmp");
            Bitmap B = new Bitmap($@"..\..\..\res\B.bmp");
            Bitmap C = new Bitmap($@"..\..\..\res\C.bmp");
            pictureBox.Image = A;
            for(int i = 0; i < 10; i++) 
            {
                if (i < 5)
                {
                    bitmaps[i] = A;
                }
                else if (i < 8)
                {
                    bitmaps[i] = B;
                }
                else if (i < 10) 
                {
                    bitmaps[i] = C;
                }
            }
            ball = new Ball(this, 0, 50, 20, Color.Red);
            ball2 = new Ball(this, 20, 50, 20, Color.Yellow);
            ball3 = new Ball(this, 40, 50, 20, Color.Blue);
            add = new Thread(new ThreadStart(addRun));
            add.Start();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 300);
            this.Name = "Balls";
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, 0, 0, Size.Width, Size.Height);

            brush = new SolidBrush(ball.getColor());
            e.Graphics.FillEllipse(brush, ball.getPX(), ball.getPY(), ball.getSize(), ball.getSize());

            brush = new SolidBrush(ball2.getColor());
            e.Graphics.FillEllipse(brush, ball2.getPX(), ball2.getPY(), ball2.getSize(), ball2.getSize());

            brush = new SolidBrush(ball3.getColor());
            e.Graphics.FillEllipse(brush, ball3.getPX(), ball3.getPY(), ball3.getSize(), ball3.getSize());

            brush.Dispose();
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ball.terminateBallThread();
            ball2.terminateBallThread();
            ball3.terminateBallThread();
            add.Abort();
        }

        private void addRun() 
        {
            var random = new Random();
            while (true) 
            {
                int index = random.Next(bitmaps.Length);
                pictureBox.Image = bitmaps[index];
                Thread.Sleep(1000);
            }
        }
    }
}