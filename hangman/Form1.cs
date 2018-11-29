using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace hangman
{
    public partial class Form1 : Form
    {

        string[] words;                         //Набор слов
        string sstring;             //переменная хранит выбранное слово
        Random _Random = new Random();                              //Класс рандома для выбора слова из набора
        private string _string;                                            //Слово, которое отгадываем в процессе меняется на *
        string trace = "img/Hangman-";
        int life = 0;

        public Form1()
        {
            InitializeComponent();
            StreamReader ReadFile = new StreamReader(@"word.txt");
            words = ReadFile.ReadToEnd().Split('\n');
        }

        // Данный метод возвращает строку длинной строки string _string в набор символов *
        private string stringAsterisk(string _string)
        {
            for (int i = 0; i < _string.Length; i++)
                _string = _string.Replace(_string[i], '*');
            return _string;
        }

        //Данный метод заменяет все включения в строке на вводимый символ
        public bool ReplaceToSymbol( 
            char inputString)
        {
            bool Control = false;
            int index;
            index = _string.IndexOf(inputString);

            while (index >= 0)
            {
                word.Text = word.Text.Remove(index, 1).Insert(index, inputString.ToString());
                _string = _string.Remove(index, 1).Insert(index, '*'.ToString());
                index = _string.IndexOf(inputString);
                Control = true;
            }
            if(_string == stringAsterisk(_string))
            {
                MessageBox.Show("Ты выйграл, но в следующий раз я отомщу!");
                word.BackColor = Color.Green;
                groupBox1.Enabled = false;
            }
            return Control;
        }

        private void gamemode()
        {
            life++;
            pictureBox.Load(trace + Convert.ToString(life) + ".png");
            if (life == 6)
            {
                MessageBox.Show("Ты пройграл, человек!");
                word.Text = sstring;
                word.BackColor = Color.Red;
                groupBox1.Enabled = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
            word.Left = this.Width / 6 - word.Width / 2;    

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _string = words[_Random.Next(0, words.Length)].ToUpper();
            _string = _string.Remove(_string.Length-1, 1);
            sstring = _string;
            word.Text = stringAsterisk(_string);
            life = 0;
            pictureBox.Load(trace + Convert.ToString(life) + ".png");
            //Ращблокируем и красим кнопки по дефолту
            { 
                button0.Enabled = true; button0.BackColor = DefaultBackColor;
                button1.Enabled = true; button1.BackColor = DefaultBackColor;
                button2.Enabled = true; button2.BackColor = DefaultBackColor;
                button3.Enabled = true; button3.BackColor = DefaultBackColor;
                button4.Enabled = true; button4.BackColor = DefaultBackColor;
                button5.Enabled = true; button5.BackColor = DefaultBackColor;
                button6.Enabled = true; button6.BackColor = DefaultBackColor;
                button7.Enabled = true; button7.BackColor = DefaultBackColor;
                button8.Enabled = true; button8.BackColor = DefaultBackColor;
                button9.Enabled = true; button9.BackColor = DefaultBackColor;
                button10.Enabled = true; button10.BackColor = DefaultBackColor;
                button11.Enabled = true; button11.BackColor = DefaultBackColor;
                button12.Enabled = true; button12.BackColor = DefaultBackColor;
                button13.Enabled = true; button13.BackColor = DefaultBackColor;
                button14.Enabled = true; button14.BackColor = DefaultBackColor;
                button15.Enabled = true; button15.BackColor = DefaultBackColor;
                button16.Enabled = true; button16.BackColor = DefaultBackColor;
                button17.Enabled = true; button17.BackColor = DefaultBackColor;
                button18.Enabled = true; button18.BackColor = DefaultBackColor;
                button19.Enabled = true; button19.BackColor = DefaultBackColor;
                button20.Enabled = true; button20.BackColor = DefaultBackColor;
                button21.Enabled = true; button21.BackColor = DefaultBackColor;
                button22.Enabled = true; button22.BackColor = DefaultBackColor;
                button23.Enabled = true; button23.BackColor = DefaultBackColor;
                button24.Enabled = true; button24.BackColor = DefaultBackColor;
                button25.Enabled = true; button25.BackColor = DefaultBackColor;
                button26.Enabled = true; button26.BackColor = DefaultBackColor;
                button27.Enabled = true; button27.BackColor = DefaultBackColor;
                button28.Enabled = true; button28.BackColor = DefaultBackColor;
                button29.Enabled = true; button29.BackColor = DefaultBackColor;
                button30.Enabled = true; button30.BackColor = DefaultBackColor;
                button31.Enabled = true; button31.BackColor = DefaultBackColor;
                button32.Enabled = true; button32.BackColor = DefaultBackColor;
            }
            groupBox1.Enabled = true;
            ////////////////////////////////////////
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button0.Text)))
            {
                button0.BackColor = Color.Green;
                button0.Enabled = false;
            }
            else
            {
                button0.BackColor = Color.Red;
                button0.Enabled = false;
                gamemode();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button1.Text)))
            {
                button1.BackColor = Color.Green;
                button1.Enabled = false;
            }
            else
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
                gamemode();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button2.Text)))
            {
                button2.BackColor = Color.Green;
                button2.Enabled = false;
            }
            else
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
                gamemode();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button3.Text)))
            {
                button3.BackColor = Color.Green;
                button3.Enabled = false;
            }
            else
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
                gamemode();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button4.Text)))
            {
                button4.BackColor = Color.Green;
                button4.Enabled = false;
            }
            else
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
                gamemode();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button5.Text)))
            {
                button5.BackColor = Color.Green;
                button5.Enabled = false;
            }
            else
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
                gamemode();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button6.Text)))
            {
                button6.BackColor = Color.Green;
                button6.Enabled = false;
            }
            else
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
                gamemode();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button7.Text)))
            {
                button7.BackColor = Color.Green;
                button7.Enabled = false;
            }
            else
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
                gamemode();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button8.Text)))
            {
                button8.BackColor = Color.Green;
                button8.Enabled = false;
            }
            else
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
                gamemode();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button9.Text)))
            {
                button9.BackColor = Color.Green;
                button9.Enabled = false;
            }
            else
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
                gamemode();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button10.Text)))
            {
                button10.BackColor = Color.Green;
                button10.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
                gamemode();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button11.Text)))
            {
                button11.BackColor = Color.Green;
                button11.Enabled = false;
            }
            else
            {
                button11.BackColor = Color.Red;
                button11.Enabled = false;
                gamemode();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button12.Text)))
            {
                button12.BackColor = Color.Green;
                button12.Enabled = false;
            }
            else
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
                gamemode();
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button13.Text)))
            {
                button13.BackColor = Color.Green;
                button13.Enabled = false;
            }
            else
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
                gamemode();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button14.Text)))
            {
                button14.BackColor = Color.Green;
                button14.Enabled = false;
            }
            else
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
                gamemode();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button15.Text)))
            {
                button15.BackColor = Color.Green;
                button15.Enabled = false;
            }
            else
            {
                button15.BackColor = Color.Red;
                button15.Enabled = false;
                gamemode();
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button16.Text)))
            {
                button16.BackColor = Color.Green;
                button16.Enabled = false;
            }
            else
            {
                button16.BackColor = Color.Red;
                button16.Enabled = false;
                gamemode();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button17.Text)))
            {
                button17.BackColor = Color.Green;
                button17.Enabled = false;
            }
            else
            {
                button17.BackColor = Color.Red;
                button17.Enabled = false;
                gamemode();
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button18.Text)))
            {
                button18.BackColor = Color.Green;
                button18.Enabled = false;
            }
            else
            {
                button18.BackColor = Color.Red;
                button18.Enabled = false;
                gamemode();
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button19.Text)))
            {
                button19.BackColor = Color.Green;
                button19.Enabled = false;
            }
            else
            {
                button19.BackColor = Color.Red;
                button19.Enabled = false;
                gamemode();
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button20.Text)))
            {
                button20.BackColor = Color.Green;
                button20.Enabled = false;
            }
            else
            {
                button20.BackColor = Color.Red;
                button20.Enabled = false;
                gamemode();
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button21.Text)))
            {
                button21.BackColor = Color.Green;
                button21.Enabled = false;
            }
            else
            {
                button21.BackColor = Color.Red;
                button21.Enabled = false;
                gamemode();
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button22.Text)))
            {
                button22.BackColor = Color.Green;
                button22.Enabled = false;
            }
            else
            {
                button22.BackColor = Color.Red;
                button22.Enabled = false;
                gamemode();
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button23.Text)))
            {
                button23.BackColor = Color.Green;
                button23.Enabled = false;
            }
            else
            {
                button23.BackColor = Color.Red;
                button23.Enabled = false;
                gamemode();
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button24.Text)))
            {
                button24.BackColor = Color.Green;
                button24.Enabled = false;
            }
            else
            {
                button24.BackColor = Color.Red;
                button24.Enabled = false;
                gamemode();
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button25.Text)))
            {
                button25.BackColor = Color.Green;
                button25.Enabled = false;
            }
            else
            {
                button25.BackColor = Color.Red;
                button25.Enabled = false;
                gamemode();
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button26.Text)))
            {
                button26.BackColor = Color.Green;
                button26.Enabled = false;
            }
            else
            {
                button26.BackColor = Color.Red;
                button26.Enabled = false;
                gamemode();
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button27.Text)))
            {
                button27.BackColor = Color.Green;
                button27.Enabled = false;
            }
            else
            {
                button27.BackColor = Color.Red;
                button27.Enabled = false;
                gamemode();
            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button28.Text)))
            {
                button28.BackColor = Color.Green;
                button28.Enabled = false;
            }
            else
            {
                button28.BackColor = Color.Red;
                button28.Enabled = false;
                gamemode();
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button29.Text)))
            {
                button29.BackColor = Color.Green;
                button29.Enabled = false;
            }
            else
            {
                button29.BackColor = Color.Red;
                button29.Enabled = false;
                gamemode();
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button30.Text)))
            {
                button30.BackColor = Color.Green;
                button30.Enabled = false;
            }
            else
            {
                button30.BackColor = Color.Red;
                button30.Enabled = false;
                gamemode();
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button31.Text)))
            {
                button31.BackColor = Color.Green;
                button31.Enabled = false;
            }
            else
            {
                button31.BackColor = Color.Red;
                button31.Enabled = false;
                gamemode();
            }
        }
        private void button32_Click(object sender, EventArgs e)
        {
            if (ReplaceToSymbol(Convert.ToChar(button32.Text)))
            {
                button32.BackColor = Color.Green;
                button32.Enabled = false;
            }
            else
            {
                button32.BackColor = Color.Red;
                button32.Enabled = false;
                gamemode();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int index;
            do
            {
                index = _Random.Next(0, _string.Length);
            }
            while (_string.ElementAt(index) == '*');
            ReplaceToSymbol(_string.ElementAt(index));
            button33.BackColor = Color.DarkGray;
            button33.Enabled = false;
            

        }
    }
}