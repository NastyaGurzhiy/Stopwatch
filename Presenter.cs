using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Presenter
    {
        private Model model;
        private MainView view;

        public Presenter(MainView view)
        {
            model = new Model();
            this.view = view;
            view.Start += ViewStart;
            view.Reset += ViewReset;
            view.Stop += ViewStop;
            view.Timer.Tick += Timer_Tick;
            view.Timer.Start();
            view.Timer.Enabled = false;
        }

        private void ViewStop(object sender, EventArgs e)
        {
            view.Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            view.textBox1.Text= model.AddSec();
        }

        private void ViewReset(object sender, EventArgs e)
        {
            view.Timer.Stop();
            view.textBox1.Clear();
            model.Reset();
        }

        private void ViewStart(object sender, EventArgs e)
        {
            view.Timer.Enabled = true;
        }
    }
}
