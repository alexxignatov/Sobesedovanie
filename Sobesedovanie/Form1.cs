using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmallLibrary;
using SmallLibrary.Interface;

namespace Sobesedovanie
{
    public partial class Form1 : Form
    {
        IEasyTask task = new EasyTask();

        public Form1()
        {
            InitializeComponent();

            var intArr = new [] {1 };
            Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[]{3, 2, 2, 5};
            
            task.Sort(numbers);
        }
    }
}
