using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lin_struct
{
    public partial class Progressbar : Form
    {
        int number; // переменная для заполнения прогрессбара
        int max = 100; // Максимальне значение
        public Progressbar() // запуск формы 
        {
            InitializeComponent();

            timer1.Interval = 1000; // таймер добавляет по единице каждую секунду
            timer1.Enabled = true; // включаем таймер
            timer1.Tick += timer1_Tick; // создаётся действие, что у нас каждый раз добавляется по элементу через таймер
            progressBar1.Maximum = max; // приравниваем заполнение прогресс бара к 100 (максимальному значению)
        }

        private void timer1_Tick(object sender, EventArgs e) // функция таймера
        {
            progressBar1.Value = number; // приравнивание одного процента прогресс бара к значению переменной
            number++; //добавляем одно значение каждый раз
            if (number >= max) // указываем условие, при котором у нас достигается наша цель
            {
                timer1.Stop(); // останавливаем таймер, в тот момент, когда прогрессбар заполняется
                button1.Enabled = true; //включаем кнопочку перехода на следующую форму
                button1.Visible = true; //делаем её видимой
            }
           
        }
        private void Progressbar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // функция на кнопку
        {
            Finish finish = new Finish(); // создаём ссылку на следующую форму в контексте данной формы
            this.Hide(); // скрываем текущую форму
            finish.Visible = true; //отображаем следующую форму
        }
    }
}
