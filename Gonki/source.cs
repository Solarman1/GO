using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Gonki
{
    // helper for manipulation to obj in diferent thread
    public delegate void CallHelper(Button btn);
    public partial class source : Form
    {
        
        Thread t1; // thread for first button moving 
        Thread t2;// thread for second button moving greg
        Thread t3;// thread for third button moving 

        Random r;
        CallHelper helper;
        Button_Compare[] button;//buttons array
        public source()
        {
            InitializeComponent();
            button = new Button_Compare[] {firstbutton, secondbutton, thirdbutton };
            helper = new CallHelper(Motion);
            r = new Random();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            pause_button.Enabled = stop_button.Enabled = true;
            ((Button)sender).Enabled = false;
            if (t1 != null) // if threads created -> buttons start to moving
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                return;
            }


            t1 = new Thread(Movement);
            t2 = new Thread(Movement2);
            t3 = new Thread(Movement3);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
        }
        /// <summary>
        /// определяет метод для движения кнопки, так же содержит метод Finish
        /// </summary>
        /// <param name="button"></param>
        void Motion(Button button)
        {
            button.Location = new Point(button.Location.X + r.Next(3), button.Location.Y);
            Lider();

            Finish(button);
        }

        private void Finish(Button button)
        {
            if (button.Location.X > pictureBox1.Location.X - button.Width)
               pause_button_Click(new object(), new EventArgs());
            start_button.Enabled = false;
        }

        private void Lider()
        {
            Array.Sort(button);
            button[0].BackColor = Color.Yellow;

            for (int i = 1; i < button.Length; i++)
                button[i].BackColor = SystemColors.Control;
        }
        
        void Movement()
        {
            while(true)
            {
                Thread.Sleep(r.Next(5,10));
                Invoke(helper, firstbutton);
            }
        }

        void Movement2()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 10));
                Invoke(helper, secondbutton);
            }
        }
        void Movement3()
        {
            while (true)
            {
                Thread.Sleep(r.Next(5, 10));
                Invoke(helper, thirdbutton);
            }
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            pause_button.Enabled = false;
            start_button.Enabled = true;
            
                 t1.Suspend();
                 t2.Suspend();
                 t3.Suspend();
            
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            pause_button.Enabled = stop_button.Enabled = false;
            pause_button_Click(sender, e);
            Reset();
        }

        private void Reset()
        {
            firstbutton.Location = new Point(13, firstbutton.Location.Y);
            secondbutton.Location = new Point(13, secondbutton.Location.Y);
            thirdbutton.Location = new Point(13, thirdbutton.Location.Y);

            foreach (Button_Compare btn in button)
                btn.BackColor = SystemColors.Control;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_button_Click(sender, new EventArgs());
        }
    }
}
