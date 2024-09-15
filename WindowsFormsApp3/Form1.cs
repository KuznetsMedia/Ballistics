using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MoveGraph: Form
    {

        string UskorSvobPad, IzvZnach;
        Double x = 0.00001, y = 0.00001, v0 = 0, t = 0, angle = 0, h = 0, s = 0, g = 0, a = 0, shag = 0, size = 0, sinA = 0, tMAX = 0;
        int deg = 0;
        bool drob = false;
        public MoveGraph()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            //Проверка заполненности данных
            if ((Znach2_box.Text == "") || (Znach1_box.Text == "")/*||(x0_box.Text == "")||(y0_box.Text == "")*/)
            {
                MessageBox.Show("Внимание! Недостаточно данных! Заполните все необходимые поля данных для произведения расчёта", "Нехватка данных",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Проверка заполненности данных
            else
            {
                #region Ускорение свободного падения
                //Определение ускорения свободного падения
                for (int i = 0; i <= 9; i++)
                {
                    if (UskorSvobPad == Convert.ToString(znach_g.Items[i]))
                    {
                        switch (i)
                        {
                            case 0:
                                g = 9.80065;
                                break;
                            case 1:
                                g = 1.62;
                                break;
                            case 2:
                                g = 0.38;
                                break;
                            case 3:
                                g = 0.9;
                                break;
                            case 4:
                                g = 0.38;
                                break;
                            case 5:
                                g = 2.55;
                                break;
                            case 6:
                                g = 1.12;
                                break;
                            case 7:
                                g = 0.97;
                                break;
                            case 8:
                                g = 1.17;
                                break;
                            case 9:
                                g = 0.01;
                                break;
                        }
                    }

                }
                //Определение ускорения свободного падения
                #endregion

                #region Тип вычисления
                //Определение типа вычисления
                for (int i = 0; i <= 8; i++)
                {
                    if (IzvZnach == Convert.ToString(Izvest.Items[i]))
                    {
                        switch (i)
                        {
                            case 0:
                                v0 = Convert.ToDouble(this.Znach1_box.Text);
                                angle = Convert.ToDouble(this.Znach2_box.Text) * Math.PI / 180;
                                sinA = Math.Sin(angle);
                                s = (Math.Pow(v0, 2) * Math.Sin(angle * 2)) / g;
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2))/ (2 * g);
                                t = (2 * v0 * sinA) / (g);
                                break;
                            case 1:
                                v0 = Convert.ToDouble(this.Znach1_box.Text);
                                t = Convert.ToDouble(this.Znach2_box.Text);
                                sinA = (t * g) / (2 * v0);
                                angle = Math.Asin(sinA); // функция вида angle = Acos(sin(angle)), sin(angle)=(t*g)/(2*v0)
                                s = (Math.Pow(v0, 2) * Math.Sin(angle * 2)) / g;
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2)) / (2*g);
                                break;
                            case 2:
                                v0 = Convert.ToDouble(this.Znach1_box.Text);
                                s = Convert.ToDouble(this.Znach2_box.Text);
                                sinA = s * g / Math.Pow(v0, 2);
                                angle = Math.Asin(sinA) / 2;
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2)) / (2 * g);
                                t = (2 * v0 * sinA) / (g);
                                break;
                            case 3:
                                v0 = Convert.ToDouble(this.Znach1_box.Text);
                                h = Convert.ToDouble(this.Znach2_box.Text);
                                sinA = (Math.Sqrt(2 * g * h)) / (v0);
                                angle = Math.Asin(sinA);
                                s = (Math.Pow(v0, 2) * Math.Sin(angle * 2)) / g;
                                t = (2 * v0 * sinA) / (g);
                                break;
                            case 4:
                                angle = Convert.ToDouble(this.Znach1_box.Text) * Math.PI / 180;
                                sinA = Math.Sin(angle);
                                t = Convert.ToDouble(this.Znach2_box.Text);
                                v0 = (t * g) / (2 * Math.Round(Math.Sin(angle), 1));
                                s = (Math.Pow(v0, 2) * Math.Sin(angle * 2)) / g;
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2)) / (2 * g);
                                break;
                            case 5:
                                angle = Convert.ToDouble(this.Znach1_box.Text) * Math.PI / 180;
                                sinA = Math.Sin(angle);
                                s = Convert.ToDouble(this.Znach2_box.Text);
                                v0 = Math.Round(Math.Sqrt(s * g / (2 * Math.Sin(angle) * Math.Cos(angle))), 1);
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2)) / (2 * g);
                                t = (2 * v0 * sinA) / (g);
                                break;
                            case 6:
                                angle = Convert.ToDouble(this.Znach1_box.Text) * Math.PI / 180;
                                sinA = Math.Sin(angle);
                                h = Convert.ToDouble(this.Znach2_box.Text);
                                v0 = Math.Sqrt(2 * h * g) / Math.Round(Math.Sin(angle), 1);
                                s = (Math.Pow(v0, 2) * Math.Sin(angle * 2)) / g;
                                t = (2 * v0 * sinA) / (g);
                                break;
                            case 7:
                                t = Convert.ToDouble(this.Znach1_box.Text);
                                s = Convert.ToDouble(this.Znach2_box.Text);
                                v0 = Math.Sqrt(((4 * Math.Pow(s, 2)) + Math.Pow(t, 4) * Math.Pow(g, 2)) / (4 * Math.Pow(t, 2)));
                                sinA = (t * g) / (2 * v0);
                                angle = Math.Asin(sinA);
                                h = (Math.Pow(v0, 2) * Math.Pow(Math.Sin(angle), 2)) / (2 * g);
                                break;
                            case 8:
                                h = Convert.ToDouble(this.Znach1_box.Text);
                                s = Convert.ToDouble(this.Znach2_box.Text);
                                t = Math.Sqrt(8 * h / g);
                                v0 = Math.Sqrt(((4 * Math.Pow(s, 2)) + Math.Pow(t, 4) * Math.Pow(g, 2)) / (4 * Math.Pow(t, 2)));
                                sinA = (t * g) / (2 * v0);
                                angle = Math.Asin(sinA);
                                break;

                        }
                        tMAX = t;
                        t = 0;
                    }
                }
                //Определение типа вычисления
                #endregion

                #region Ошибки
                //Переизбыток скорости
                if (v0 > 299792458)
                {
                    MessageBox.Show("Внимание! Скорость тела в данном случае превышает скорость света в вакууме! Просьба ''сбавить скорость'' для корректной работы программы.", "Вот это скорость!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Переизбыток скорости
                else

                //Неверный угол
                if ((sinA < 0) || (sinA > 1))
                {
                    MessageBox.Show("Внимание! Данный случай не возможен! Перепроверьте правилность введённых данных", "Что-то тут не так",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Неверный угол
                else
                    #endregion

                #region Коэффициенты
                    //koef - некий коэффициент, который высчитывает шаг цикла при построении графика. Только лишь это.
                    //deg - число знаков после запятой у значений, выводимых на экран. На кол-во знаков числа в самой переменной никак не влияет.

                //Задание коэффициента deg
                    deg = PointBar.Value;
                //Задание коэффициента deg

                //Вычисление коэфициента shag
                    shag = Convert.ToString(Math.Round(v0, 0)).Length - 5;
                //Вычисление коэфициента shag
                #endregion

                #region Построение графика
                //x0 = Convert.ToInt32(x0_box.Text);
                //y0 = Convert.ToInt32(y0_box.Text);
                chart2.Series[0].Points.AddXY(0, 0);
                //Цикл построения графика
                while (t < tMAX)
                    {
                    
                    
                        //t = t + (Math.Pow(10, shag));
                        y = (v0 * t * Math.Sin(angle)) - (0.5 * g * Math.Pow(t, 2));
                        y = Math.Round(y, Convert.ToInt32(2));
                        x = v0 * t * Math.Cos(angle);//(Math.Sqrt(1) - Math.Sqrt(Math.Pow(Math.Sin(angle), 2)));
                        x = Math.Round(x, Convert.ToInt32(2));
                    chart1.Series[0].Points.AddXY(x, y);
                    chart2.Series[0].Points.AddXY(x, y);
                    t = t + 0.01*tMAX;
                }
                y = (v0 * t * Math.Sin(angle)) - (0.5 * g * Math.Pow(t, 2));
                y = Math.Round(y, Convert.ToInt32(2));
                x = v0 * t * Math.Cos(angle);//(Math.Sqrt(1) - Math.Sqrt(Math.Pow(Math.Sin(angle), 2)));
                x = Math.Round(x, Convert.ToInt32(2));
                chart1.Series[0].Points.AddXY(x, y);
                chart2.Series[0].Points.AddXY(x, y);
                t = tMAX;
                //Цикл построения графика
                #endregion

                #region Масштаб графика
                //Масштаб графика
                if (s > h) { size = s; }
                else { size = h; }
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Minimum = 0;

                chart2.ChartAreas[0].AxisX.Minimum = 0;
                chart2.ChartAreas[0].AxisY.Minimum = 0;
                chart2.ChartAreas[0].AxisX.Maximum = Math.Round(size + size * 0.1, Convert.ToInt32(-shag+3));
                chart2.ChartAreas[0].AxisY.Maximum = Math.Round(size + size * 0.1, Convert.ToInt32(-shag+3));
                chart2.ChartAreas[0].AxisX.Interval = Math.Pow(size, shag);
                chart2.ChartAreas[0].AxisY.Interval = Math.Pow(size, shag);
                //Масштаб графика
                #endregion
                
                #region Заполнение данных
                //Заполнение недостающих значений
                s_box.Text = Convert.ToString(Math.Round(s, deg));
                h_box.Text = Convert.ToString(Math.Round(h, deg));
                t_box.Text = Convert.ToString(Math.Round(tMAX, deg));
                angle_box.Text = Convert.ToString(Math.Round(angle * 180 / Math.PI, deg));
                v0_box.Text = Convert.ToString(Math.Round(v0, deg));
                //Заполнение недостающих значений
                #endregion
            }
        }
    
        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void x0_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void PointBar_Scroll(object sender, EventArgs e)
        {

        }
        private void angle_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void v0_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void t_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void h_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            //Обнуление графика
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            //Обнуление графика
            x = 0;
            y = 0;
            v0 = 0;
            t = 0;
            angle = 0;
            h = 0;
            s = 0;
            g = 0;
            a = 0;
            deg = 0;
            angle_box.Text = "";
            v0_box.Text = "";
            s_box.Text = "";
            t_box.Text = "";
            h_box.Text = "";
            Znach1_box.Text = "";
            Znach2_box.Text = "";

        }
        private void s_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void angle_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void v0_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void t_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void h_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void s_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Parabola_Load(object sender, EventArgs e)
        {
            znach_g.Items.AddRange(new string[] { "9,80665 (Земля)", "1,62 (Луна)", "0,38 (Меркурий)", "0,9 (Венера)", "0,38 (Марс)", "2,55 (Юпитер)", "1,12 (Сатурн)", "0,97 (Уран)", "1,17 (Нептун)", "0,01 (Плутон)" });
            Izvest.Items.AddRange(new string[] {"Начальная скорость и угол", "Начальная скорость и время полёта", "Начальная скорость и дальность полёта", "Начальная скорость и высота полёта",
                "Угол и время полёта", "Угол и дальность полёта", "Угол и высота полёта", "Время и дальность полёта", "Дальность полёта и высота полёта" });

        }
        private void Izvest_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzvZnach = Izvest.SelectedItem.ToString();
            for (int i = 0; i <= 8; i++)
            {
                if (IzvZnach == Convert.ToString(Izvest.Items[i]))
                {
                    switch (i)
                    {
                        case 0:
                            Znach1_text.Text = "Начальная скорость";
                            Znach2_text.Text = "Угол броска";


                            break;
                        case 1:
                            Znach1_text.Text = "Начальная скорость";
                            Znach2_text.Text = "Длительность полёта";

                            break;
                        case 2:
                            Znach1_text.Text = "Начальная скорость";
                            Znach2_text.Text = "Дальность полёта";


                            break;
                        case 3:
                            Znach1_text.Text = "Начальная скорость";
                            Znach2_text.Text = "Максимальная высота";

                            break;
                        case 4:
                            Znach1_text.Text = "Угол броска";
                            Znach2_text.Text = "Длительность полёта";

                            t = 0;
                            break;
                        case 5:
                            Znach1_text.Text = "Угол броска";
                            Znach2_text.Text = "Дальность полёта";

                            break;
                        case 6:
                            Znach1_text.Text = "Угол броска";
                            Znach2_text.Text = "Максимальная высота";

                            break;
                        case 7:
                            Znach1_text.Text = "Длительность полёта";
                            Znach2_text.Text = "Дальность полёта";

                            t = 0;
                            break;
                        case 8:
                            Znach1_text.Text = "Максимальная высота";
                            Znach2_text.Text = "Дальность полёта";

                            break;

                    }
                }
            }
        }
        private void znach_g_SelectedIndexChanged(object sender, EventArgs e)
        {
            UskorSvobPad = znach_g.SelectedItem.ToString();
        }
    }
}

