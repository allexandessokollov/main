using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2._16_WF
{
    public partial class GetAnswer : Form
    {
        public GetAnswer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void outSizeOfArr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int arrSize =  Convert.ToInt32(outSizeOfArr.Text);
            int[] arr = new int[arrSize];
            randIntArr(arr, -100, 100);

            outAnswr.Text = task(arr).ToString();

        }

        static void randIntArr(int[] array, int st, int end)
        {
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(st, end);
                while (array[i] == 0)
                {
                    array[i] = rand.Next(st, end);
                }
            }
        }

        static int task(int[] array)
        {

            int ctr;

            for (ctr = 0; ctr < (array.Length - 1); ctr++)
            {
                if (array[ctr] > 0 && array[ctr + 1] < 0)
                {
                    continue;
                }
                else if (array[ctr] < 0 && array[ctr + 1] > 0)
                {
                    continue;
                }
                else
                {               
                    return ctr + 1;
                }
            }

            return 0;
        }

    }
}
