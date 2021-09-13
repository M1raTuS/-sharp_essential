using System;
using System.Windows.Threading;

//Presenter

namespace Lesson_12._3
{

    class Presenter
    {
        DispatcherTimer timer = new DispatcherTimer();
        private readonly Model model;
        private readonly MainWindow view;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;

            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;

            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        void ViewReset(object sender, EventArgs e)
        {
            timer.Stop();
            view.textBox1.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void ViewStart(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.textBox1.Text = model.Tick();
        }
    }
}
