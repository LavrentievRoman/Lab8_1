﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void answerButton_Click(object sender, EventArgs e)
        {
            double a = rnd.NextDouble();

            if (a < 0.5) answerLabel.Text = "Да";
            else answerLabel.Text = "Нет";
        }
    }
}
