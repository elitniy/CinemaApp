using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int topPosition = 70;
        int leftPositin = 90;
        int price = 0;
        int NumbeOfSeats = 0;
        List<Button> list = new List<Button>();
        private void Form3_Load(object sender, EventArgs e)
        {
            Button display = new Button();
            display.Width = 450;
            display.Height = 20;
            display.Top = 20;
            display.Left = 90;
            display.BackColor = Color.Gray;
            this.Controls.Add(display);
            for (int j = 0; j < 8; j++)
            {
                leftPositin = 90;
                topPosition += 40;
                for (int i = 0; i < 11; i++)
                {
                    Button button = new Button();
                    button.Width = 32;
                    button.Height = 25;
                    button.Top = topPosition;
                    button.BackColor = Color.LightGray;
                    button.Left = leftPositin;
                    leftPositin += button.Width + 10;
                    button.Text = Convert.ToString(i + 1);
                    this.Controls.Add(button);
                    button.Click += new EventHandler(this.GreetingBtn_Click);
                }
            }
        }
        public void GreetingBtn_Click(Object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;
            list.Add(clickedButton);
            NumbeOfSeats++;
            NumberOfSeats.Text = Convert.ToString(NumbeOfSeats);
            price += 5;
            LblPrice.Text = Convert.ToString(price) + " AZN";

        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                if (item.BackColor == Color.Green)
                {
                    item.BackColor = Color.LightGray;
                }
                price = 0;
                NumbeOfSeats = 0;
                NumberOfSeats.Text = Convert.ToString(" ");
                LblPrice.Text = Convert.ToString(" ");
            }
        }

        private void Select_Click_1(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                if (item.BackColor == Color.Green)
                {
                    item.BackColor = Color.Red;
                }
                NumberOfSeats.Text = Convert.ToString(" ");
                price = 0;
                NumbeOfSeats = 0;
                LblPrice.Text = Convert.ToString(" ");
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
