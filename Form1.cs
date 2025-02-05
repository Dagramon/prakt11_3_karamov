using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot_karamov
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RobotClass robot1 = new RobotClass();
            RobotClass robot2 = new RobotClass();
            RobotClass robot3 = new RobotClass();
            Random rng = new Random();
            int b = rng.Next(0, 100);
            robot1.Min(b);
            robot1.life = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = $"Количество жизней 1 робота в начале игры - {robot1.life}";
            robot2.life = Convert.ToInt32(numericUpDown2.Value);
            label3.Text = $"Количество жизней 2 робота в начале игры - {robot2.life}";
            robot3.life = Convert.ToInt32(numericUpDown3.Value);
            label5.Text = $"Количество жизней 3 робота в начале игры - {robot3.life}";
            int a = robot1.life;
            robot1.Min(robot1.life);
            label2.Text = $"Количество жизней 1 робота после игры - {robot1.GetLife()}";
            robot2.Kol(a, robot1.life);
            label4.Text = $"Количество жизней 2 робота после игры - {robot2.GetLife()}";
            robot3.Kol(a, robot1.life);
            label6.Text = $"Количество жизней 3 робота после игры - {robot3.GetLife()}";
        }
    }
}
