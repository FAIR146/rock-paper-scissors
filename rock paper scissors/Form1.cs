using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        GameChoice choiceUser = 0;
        GameChoice choiceBot = 0;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            choiceBot = (GameChoice)random.Next(0, 3);
            labelBotChoice.Text = GetGameName(choiceBot);


            choiceUser = (GameChoice)random.Next(0, 3);
            labelMyChoice.Text = GetGameName(choiceUser);

            if (choiceBot == GameChoice.Paper)
            {
                switch (choiceUser)
                {
                    case GameChoice.Rock:
                        MessageBox.Show("Вы проиграли!");
                        break;
                    case GameChoice.Paper:
                        MessageBox.Show("Ничья!");
                        break;
                    case GameChoice.Scissors:
                        MessageBox.Show("Вы выиграли!");
                        break;
                    default:
                        break;
                }
            }
            if (choiceBot == GameChoice.Rock)
            {
                switch (choiceUser)
                {
                    case GameChoice.Rock:
                        MessageBox.Show("Ничья!");
                        break;
                    case GameChoice.Paper:
                        MessageBox.Show("Вы выиграли!");
                        break;
                    case GameChoice.Scissors:
                        MessageBox.Show("Вы проиграли!");
                        break;
                    default:
                        break;
                }
            }
            if (choiceBot == GameChoice.Scissors)
            {
                switch (choiceUser)
                {
                    case GameChoice.Rock:
                        MessageBox.Show("Вы выиграли!");
                        break;
                    case GameChoice.Paper:
                        MessageBox.Show("Вы проиграли!");
                        break;
                    case GameChoice.Scissors:
                        MessageBox.Show("Ничья!");
                        break;
                    default:
                        break;
                }
            }
        }
        private string GetGameName(GameChoice choice)
        {
            switch (choice)
            {
                case GameChoice.Rock:
                    return "Камень";
                    break;
                case GameChoice.Paper:
                    return "Бумага";
                    break;
                case GameChoice.Scissors:
                    return "Ножницы";
                    break;
                default:
                    return "";
                    break;
            }

        }
    }

    public enum GameChoice
    {
        Rock,
        Paper,
        Scissors,
    }
}
