using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunifuLoading
{
    public partial class myProgram : UserControl
    {
        public myProgram()
        {
            InitializeComponent();
        }

        int dir = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value == 90)
            {
                dir = -1;
                bunifuCircleProgressbar1.animationSpeed = 4;
            }
            else if(bunifuCircleProgressbar1.Value==10)
            {
                dir = +1;
                bunifuCircleProgressbar1.animationSpeed = 2;
            
        }
            bunifuCircleProgressbar1.Value += dir;
        }

        private void myProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
