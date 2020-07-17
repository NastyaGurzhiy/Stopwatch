using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            new Presenter(this);
        }


        event EventHandler start;
        event EventHandler reset;
        event EventHandler stop;

        public event EventHandler Start
        {
            add
            {
                start += value;
            }
            remove
            {
                start -= value;
            }
        }
        public event EventHandler Reset
        {
            add
            {
                reset += value;
            }
            remove
            {
                reset -= value;
            }
        }
        public event EventHandler Stop
        {
            add
            {
                stop += value;
            }
            remove
            {
                stop -= value;
            }
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }
    }
}
