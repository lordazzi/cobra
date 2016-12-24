using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobra
{
    public partial class Form2 : Form
    {
        int[] ANTposTOP = new int[100], ANTposLEFT = new int[100];
        int x = 0, y = 0, RATrand, ponto = 0, ANTpos, indo, NumPodVolta = 0, vel = 0, LoL = 0;
        int A = 30, B = 56, C = 82, D = 108, E = 134, F = 160, G = 186, H = 212, I = 238, J = 264;
        public Form2()
        {
            InitializeComponent();
        }

        private void Grow()
        {
            if (SNAKE.Top == ANTposTOP[indo] && SNAKE.Left == ANTposLEFT[indo])
            {
                this.Close();
            }
            else
            {
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (NumPodVolta == 1 && x == 2)
                {
                    this.Close();
                }
                x = 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (NumPodVolta == 1 && x == 1)
                {
                    this.Close();
                }
                x = 2;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (NumPodVolta == 1 && x == 4)
                {
                    this.Close();
                }
                x = 3;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (NumPodVolta == 1 && x == 3)
                {
                    this.Close();
                }
                x = 4;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            #region MarkPOS
            ANTpos = 99;
            for (int MarkPOSI = 0; MarkPOSI <= 98; MarkPOSI++)
            {
                ANTposLEFT[ANTpos] = ANTposLEFT[ANTpos - 1];
                ANTposTOP[ANTpos] = ANTposTOP[ANTpos - 1];
                ANTpos = ANTpos - 1;
            }
            ANTposTOP[0] = SNAKE.Top;
            ANTposLEFT[0] = SNAKE.Left;
            #endregion
            #region NovaPOS
            if (x == 1)
            {
                if (SNAKE.Left <= 30)
                {
                    SNAKE.Left = 264;
                }
                else
                {
                    SNAKE.Left = SNAKE.Left - 26;
                }
            }
            else if (x == 2)
            {
                if (SNAKE.Left >= 264)
                {
                    SNAKE.Left = 30;
                }
                else
                {
                    SNAKE.Left = SNAKE.Left + 26;
                }
            }
            else if (x == 3)
            {
                if (SNAKE.Top <= 31)
                {
                    SNAKE.Top = 264;
                }
                else
                {
                    SNAKE.Top = SNAKE.Top - 26;
                }
            }
            else if (x == 4)
            {
                if (SNAKE.Top >= 264)
                {
                    SNAKE.Top = 30;
                }
                else
                {
                    SNAKE.Top = SNAKE.Top + 26;
                }
            }

            if (SNAKE.Top == RAT.Top && SNAKE.Left == RAT.Left)
            {
                y = 0;
                ponto++;
                if (ponto < 10)
                {
                    label1.Text = ("PONTOS: 0" + ponto);
                }
                else
                {
                    label1.Text = ("PONTOS: " + ponto);
                }
            }
            else
            {
            }
            #endregion
            #region MaisVELO
            if (ponto == 5 && vel == 0)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 10 && vel == 1)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 15 && vel == 2)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 20 && vel == 3)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 25 && vel == 4)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 30 && vel == 5)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 35 && vel == 6)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 40 && vel == 7)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 45 && vel == 8)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 50 && vel == 9)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 55 && vel == 10)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 60 && vel == 11)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 65 && vel == 12)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 70 && vel == 13)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 75 && vel == 14)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 80 && vel == 15)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 85 && vel == 16)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            else if (ponto == 90 && vel == 17)
            {
                timer1.Interval = timer1.Interval - Z;
                vel++;
            }
            #endregion
            #region Crescendo
            indo = 0;
            if (ponto >= indo + 1)
            {
                NumPodVolta = 1;
                pictureBox3.Visible = true;
                pictureBox3.Top = ANTposTOP[indo];
                pictureBox3.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                NumPodVolta = 1;
                pictureBox4.Visible = true;
                pictureBox4.Top = ANTposTOP[indo];
                pictureBox4.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox5.Visible = true;
                pictureBox5.Top = ANTposTOP[indo];
                pictureBox5.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox6.Visible = true;
                pictureBox6.Top = ANTposTOP[indo];
                pictureBox6.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox7.Visible = true;
                pictureBox7.Top = ANTposTOP[indo];
                pictureBox7.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox8.Visible = true;
                pictureBox8.Top = ANTposTOP[indo];
                pictureBox8.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox9.Visible = true;
                pictureBox9.Top = ANTposTOP[indo];
                pictureBox9.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox10.Visible = true;
                pictureBox10.Top = ANTposTOP[indo];
                pictureBox10.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox11.Visible = true;
                pictureBox11.Top = ANTposTOP[indo];
                pictureBox11.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox12.Visible = true;
                pictureBox12.Top = ANTposTOP[indo];
                pictureBox12.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox13.Visible = true;
                pictureBox13.Top = ANTposTOP[indo];
                pictureBox13.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox14.Visible = true;
                pictureBox14.Top = ANTposTOP[indo];
                pictureBox14.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox15.Visible = true;
                pictureBox15.Top = ANTposTOP[indo];
                pictureBox15.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox16.Visible = true;
                pictureBox16.Top = ANTposTOP[indo];
                pictureBox16.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox17.Visible = true;
                pictureBox17.Top = ANTposTOP[indo];
                pictureBox17.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox18.Visible = true;
                pictureBox18.Top = ANTposTOP[indo];
                pictureBox18.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox19.Visible = true;
                pictureBox19.Top = ANTposTOP[indo];
                pictureBox19.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox20.Visible = true;
                pictureBox20.Top = ANTposTOP[indo];
                pictureBox20.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox21.Visible = true;
                pictureBox21.Top = ANTposTOP[indo];
                pictureBox21.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox22.Visible = true;
                pictureBox22.Top = ANTposTOP[indo];
                pictureBox22.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox23.Visible = true;
                pictureBox23.Top = ANTposTOP[indo];
                pictureBox23.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox24.Visible = true;
                pictureBox24.Top = ANTposTOP[indo];
                pictureBox24.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox25.Visible = true;
                pictureBox25.Top = ANTposTOP[indo];
                pictureBox25.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox26.Visible = true;
                pictureBox26.Top = ANTposTOP[indo];
                pictureBox26.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox27.Visible = true;
                pictureBox27.Top = ANTposTOP[indo];
                pictureBox27.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox28.Visible = true;
                pictureBox28.Top = ANTposTOP[indo];
                pictureBox28.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox29.Visible = true;
                pictureBox29.Top = ANTposTOP[indo];
                pictureBox29.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox30.Visible = true;
                pictureBox30.Top = ANTposTOP[indo];
                pictureBox30.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox31.Visible = true;
                pictureBox31.Top = ANTposTOP[indo];
                pictureBox31.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox32.Visible = true;
                pictureBox32.Top = ANTposTOP[indo];
                pictureBox32.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox33.Visible = true;
                pictureBox33.Top = ANTposTOP[indo];
                pictureBox33.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox34.Visible = true;
                pictureBox34.Top = ANTposTOP[indo];
                pictureBox34.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox35.Visible = true;
                pictureBox35.Top = ANTposTOP[indo];
                pictureBox35.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox36.Visible = true;
                pictureBox36.Top = ANTposTOP[indo];
                pictureBox36.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox37.Visible = true;
                pictureBox37.Top = ANTposTOP[indo];
                pictureBox37.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox38.Visible = true;
                pictureBox38.Top = ANTposTOP[indo];
                pictureBox38.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox39.Visible = true;
                pictureBox39.Top = ANTposTOP[indo];
                pictureBox39.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox40.Visible = true;
                pictureBox40.Top = ANTposTOP[indo];
                pictureBox40.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox41.Visible = true;
                pictureBox41.Top = ANTposTOP[indo];
                pictureBox41.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox42.Visible = true;
                pictureBox42.Top = ANTposTOP[indo];
                pictureBox42.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox43.Visible = true;
                pictureBox43.Top = ANTposTOP[indo];
                pictureBox43.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox44.Visible = true;
                pictureBox44.Top = ANTposTOP[indo];
                pictureBox44.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox45.Visible = true;
                pictureBox45.Top = ANTposTOP[indo];
                pictureBox45.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox46.Visible = true;
                pictureBox46.Top = ANTposTOP[indo];
                pictureBox46.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox47.Visible = true;
                pictureBox47.Top = ANTposTOP[indo];
                pictureBox47.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox48.Visible = true;
                pictureBox48.Top = ANTposTOP[indo];
                pictureBox48.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox49.Visible = true;
                pictureBox49.Top = ANTposTOP[indo];
                pictureBox49.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox50.Visible = true;
                pictureBox50.Top = ANTposTOP[indo];
                pictureBox50.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox51.Visible = true;
                pictureBox51.Top = ANTposTOP[indo];
                pictureBox51.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox52.Visible = true;
                pictureBox52.Top = ANTposTOP[indo];
                pictureBox52.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox53.Visible = true;
                pictureBox53.Top = ANTposTOP[indo];
                pictureBox53.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox54.Visible = true;
                pictureBox54.Top = ANTposTOP[indo];
                pictureBox54.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox55.Visible = true;
                pictureBox55.Top = ANTposTOP[indo];
                pictureBox55.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox56.Visible = true;
                pictureBox56.Top = ANTposTOP[indo];
                pictureBox56.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox57.Visible = true;
                pictureBox57.Top = ANTposTOP[indo];
                pictureBox57.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox58.Visible = true;
                pictureBox58.Top = ANTposTOP[indo];
                pictureBox58.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox59.Visible = true;
                pictureBox59.Top = ANTposTOP[indo];
                pictureBox59.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox60.Visible = true;
                pictureBox60.Top = ANTposTOP[indo];
                pictureBox60.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox61.Visible = true;
                pictureBox61.Top = ANTposTOP[indo];
                pictureBox61.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox62.Visible = true;
                pictureBox62.Top = ANTposTOP[indo];
                pictureBox62.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox63.Visible = true;
                pictureBox63.Top = ANTposTOP[indo];
                pictureBox63.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox64.Visible = true;
                pictureBox64.Top = ANTposTOP[indo];
                pictureBox64.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox65.Visible = true;
                pictureBox65.Top = ANTposTOP[indo];
                pictureBox65.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox66.Visible = true;
                pictureBox66.Top = ANTposTOP[indo];
                pictureBox66.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox67.Visible = true;
                pictureBox67.Top = ANTposTOP[indo];
                pictureBox67.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox68.Visible = true;
                pictureBox68.Top = ANTposTOP[indo];
                pictureBox68.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox69.Visible = true;
                pictureBox69.Top = ANTposTOP[indo];
                pictureBox69.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox70.Visible = true;
                pictureBox70.Top = ANTposTOP[indo];
                pictureBox70.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox71.Visible = true;
                pictureBox71.Top = ANTposTOP[indo];
                pictureBox71.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox72.Visible = true;
                pictureBox72.Top = ANTposTOP[indo];
                pictureBox72.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox73.Visible = true;
                pictureBox73.Top = ANTposTOP[indo];
                pictureBox73.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox74.Visible = true;
                pictureBox74.Top = ANTposTOP[indo];
                pictureBox74.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox75.Visible = true;
                pictureBox75.Top = ANTposTOP[indo];
                pictureBox75.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox76.Visible = true;
                pictureBox76.Top = ANTposTOP[indo];
                pictureBox76.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox77.Visible = true;
                pictureBox77.Top = ANTposTOP[indo];
                pictureBox77.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox78.Visible = true;
                pictureBox78.Top = ANTposTOP[indo];
                pictureBox78.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox79.Visible = true;
                pictureBox79.Top = ANTposTOP[indo];
                pictureBox79.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox80.Visible = true;
                pictureBox80.Top = ANTposTOP[indo];
                pictureBox80.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox81.Visible = true;
                pictureBox81.Top = ANTposTOP[indo];
                pictureBox81.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox82.Visible = true;
                pictureBox82.Top = ANTposTOP[indo];
                pictureBox82.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox83.Visible = true;
                pictureBox83.Top = ANTposTOP[indo];
                pictureBox83.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox84.Visible = true;
                pictureBox84.Top = ANTposTOP[indo];
                pictureBox84.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox85.Visible = true;
                pictureBox85.Top = ANTposTOP[indo];
                pictureBox85.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox86.Visible = true;
                pictureBox86.Top = ANTposTOP[indo];
                pictureBox86.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox87.Visible = true;
                pictureBox87.Top = ANTposTOP[indo];
                pictureBox87.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox88.Visible = true;
                pictureBox88.Top = ANTposTOP[indo];
                pictureBox88.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox89.Visible = true;
                pictureBox89.Top = ANTposTOP[indo];
                pictureBox89.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox90.Visible = true;
                pictureBox90.Top = ANTposTOP[indo];
                pictureBox90.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox91.Visible = true;
                pictureBox91.Top = ANTposTOP[indo];
                pictureBox91.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox92.Visible = true;
                pictureBox92.Top = ANTposTOP[indo];
                pictureBox92.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            if (ponto >= indo + 1)
            {
                pictureBox93.Visible = true;
                pictureBox93.Top = ANTposTOP[indo];
                pictureBox93.Left = ANTposLEFT[indo];
                Grow();
            }
            indo++;
            #endregion
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y == 0)
            {
                Random POS1 = new Random();
                RATrand = POS1.Next(9);

                if (RATrand == 0)
                {
                    RAT.Left = A;
                }
                else if (RATrand == 1)
                {
                    RAT.Left = B;
                }
                else if (RATrand == 2)
                {
                    RAT.Left = C;
                }
                else if (RATrand == 3)
                {
                    RAT.Left = D;
                }
                else if (RATrand == 4)
                {
                    RAT.Left = E;
                }
                else if (RATrand == 5)
                {
                    RAT.Left = F;
                }
                else if (RATrand == 6)
                {
                    RAT.Left = G;
                }
                else if (RATrand == 7)
                {
                    RAT.Left = H;
                }
                else if (RATrand == 8)
                {
                    RAT.Left = I;
                }
                else if (RATrand == 9)
                {
                    RAT.Left = J;
                }
                y = 1;
            }
            else if (y == 1)
            {
                Random POS2 = new Random();
                RATrand = POS2.Next(9);

                if (RATrand == 0)
                {
                    RAT.Top = A;
                }
                else if (RATrand == 1)
                {
                    RAT.Top = B;
                }
                else if (RATrand == 2)
                {
                    RAT.Top = C;
                }
                else if (RATrand == 3)
                {
                    RAT.Top = D;
                }
                else if (RATrand == 4)
                {
                    RAT.Top = E;
                }
                else if (RATrand == 5)
                {
                    RAT.Top = F;
                }
                else if (RATrand == 6)
                {
                    RAT.Top = G;
                }
                else if (RATrand == 7)
                {
                    RAT.Top = H;
                }
                else if (RATrand == 8)
                {
                    RAT.Top = I;
                }
                else if (RATrand == 9)
                {
                    RAT.Top = J;
                }
                y = 2;
            }
            else if (y == 2)
            {
                LoL = 0;
                foreach (object CALDA in this.Controls)
                {
                    if (CALDA is PictureBox)
                    {
                        if (((PictureBox)(CALDA)).Visible == true && RAT.Location == ((PictureBox)(CALDA)).Location && ((PictureBox)(CALDA)).BackColor == Color.Black)
                        {
                            y = 0;
                            LoL = 1;
                        }
                    }
                }
                if (LoL == 0)
                {
                    if (SNAKE.Top == RAT.Top && SNAKE.Left == RAT.Left)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = 3;
                    }
                }
            }
        }
    }
}