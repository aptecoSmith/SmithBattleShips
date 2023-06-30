namespace SmithBattleShips
{
    public partial class Form1 : Form
    {
        private NavyAsset na = new NavyAsset();
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            AddButtonsToList();
            BlankTextButtons();
            ColourGrid();

            Position thisCell = new Position()
            {
                x = 1,
                y = 1
            };
            na.AllShipsPosition.Add(thisCell);
        }

        private void AddButtonsToList()
        {
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);
            buttons.Add(button21);
            buttons.Add(button22);
            buttons.Add(button23);
            buttons.Add(button24);
            buttons.Add(button25);
            buttons.Add(button26);
            buttons.Add(button27);
            buttons.Add(button28);
            buttons.Add(button29);
            buttons.Add(button30);
            buttons.Add(button31);
            buttons.Add(button32);
            buttons.Add(button33);
            buttons.Add(button34);
            buttons.Add(button35);
            buttons.Add(button36);
            buttons.Add(button37);
            buttons.Add(button38);
            buttons.Add(button39);
            buttons.Add(button40);
            buttons.Add(button41);
            buttons.Add(button42);
            buttons.Add(button43);
            buttons.Add(button44);
            buttons.Add(button45);
            buttons.Add(button46);
            buttons.Add(button47);
            buttons.Add(button48);
            buttons.Add(button49);
            buttons.Add(button50);
            buttons.Add(button51);
            buttons.Add(button52);
            buttons.Add(button53);
            buttons.Add(button54);
            buttons.Add(button55);
            buttons.Add(button56);
            buttons.Add(button57);
            buttons.Add(button58);
            buttons.Add(button59);
            buttons.Add(button60);
            buttons.Add(button61);
            buttons.Add(button62);
            buttons.Add(button63);
            buttons.Add(button64);
            buttons.Add(button65);
            buttons.Add(button66);
            buttons.Add(button67);
            buttons.Add(button68);
            buttons.Add(button69);
            buttons.Add(button70);
            buttons.Add(button71);
            buttons.Add(button72);
            buttons.Add(button73);
            buttons.Add(button74);
            buttons.Add(button75);
            buttons.Add(button76);
            buttons.Add(button77);
            buttons.Add(button78);
            buttons.Add(button79);
            buttons.Add(button80);
            buttons.Add(button81);
            buttons.Add(button82);
            buttons.Add(button83);
            buttons.Add(button84);
            buttons.Add(button85);
            buttons.Add(button86);
            buttons.Add(button87);
            buttons.Add(button88);
            buttons.Add(button89);
            buttons.Add(button90);
            buttons.Add(button91);
            buttons.Add(button92);
            buttons.Add(button93);
            buttons.Add(button94);
            buttons.Add(button95);
            buttons.Add(button96);
            buttons.Add(button97);
            buttons.Add(button98);
            buttons.Add(button99);
            buttons.Add(button100);
        }

        private void BlankTextButtons()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button28.Text = "";
            button29.Text = "";
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            button34.Text = "";
            button35.Text = "";
            button36.Text = "";
            button37.Text = "";
            button38.Text = "";
            button39.Text = "";
            button40.Text = "";
            button41.Text = "";
            button42.Text = "";
            button43.Text = "";
            button44.Text = "";
            button45.Text = "";
            button46.Text = "";
            button47.Text = "";
            button48.Text = "";
            button49.Text = "";
            button50.Text = "";
            button51.Text = "";
            button52.Text = "";
            button53.Text = "";
            button54.Text = "";
            button55.Text = "";
            button56.Text = "";
            button57.Text = "";
            button58.Text = "";
            button59.Text = "";
            button60.Text = "";
            button61.Text = "";
            button62.Text = "";
            button63.Text = "";
            button64.Text = "";
            button65.Text = "";
            button66.Text = "";
            button67.Text = "";
            button68.Text = "";
            button69.Text = "";
            button70.Text = "";
            button71.Text = "";
            button72.Text = "";
            button73.Text = "";
            button74.Text = "";
            button75.Text = "";
            button76.Text = "";
            button77.Text = "";
            button78.Text = "";
            button79.Text = "";
            button80.Text = "";
            button81.Text = "";
            button82.Text = "";
            button83.Text = "";
            button84.Text = "";
            button85.Text = "";
            button86.Text = "";
            button87.Text = "";
            button88.Text = "";
            button89.Text = "";
            button90.Text = "";
            button91.Text = "";
            button92.Text = "";
            button93.Text = "";
            button94.Text = "";
            button95.Text = "";
            button96.Text = "";
            button97.Text = "";
            button98.Text = "";
            button99.Text = "";
            button100.Text = "";
        }

        private void ColourGrid()
        {
            int x = 0;
            int y = 0;

            foreach (Button button in buttons)
            {
                x++;
                y++;

                Position thisCell = new Position() { x = x, y = x };
                if (na.AllShipsPosition.Contains(thisCell))
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.LightBlue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.Text = "X";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.Text = "X";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.Text = "X";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.Text = "X";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.Text = "X";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.Text = "X";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.Text = "X";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.Text = "X";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.Text = "X";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 1
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button10.BackColor = Color.Red;
            }
            else
            {
                button10.Text = "X";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button11.BackColor = Color.Red;
            }
            else
            {
                button11.Text = "X";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button12.BackColor = Color.Red;
            }
            else
            {
                button12.Text = "X";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button13.BackColor = Color.Red;
            }
            else
            {
                button13.Text = "X";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button14.BackColor = Color.Red;
            }
            else
            {
                button14.Text = "X";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button15.BackColor = Color.Red;
            }
            else
            {
                button15.Text = "X";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button16.BackColor = Color.Red;
            }
            else
            {
                button16.Text = "X";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button17.BackColor = Color.Red;
            }
            else
            {
                button17.Text = "X";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button18.BackColor = Color.Red;
            }
            else
            {
                button18.Text = "X";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button19.BackColor = Color.Red;
            }
            else
            {
                button19.Text = "X";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 2
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button20.BackColor = Color.Red;
            }
            else
            {
                button20.Text = "X";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button21.BackColor = Color.Red;
            }
            else
            {
                button21.Text = "X";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button22.BackColor = Color.Red;
            }
            else
            {
                button22.Text = "X";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button23.BackColor = Color.Red;
            }
            else
            {
                button23.Text = "X";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button24.BackColor = Color.Red;
            }
            else
            {
                button24.Text = "X";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button25.BackColor = Color.Red;
            }
            else
            {
                button25.Text = "X";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button26.BackColor = Color.Red;
            }
            else
            {
                button26.Text = "X";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button27.BackColor = Color.Red;
            }
            else
            {
                button27.Text = "X";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button28.BackColor = Color.Red;
            }
            else
            {
                button28.Text = "X";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button29.BackColor = Color.Red;
            }
            else
            {
                button29.Text = "X";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 3
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button30.BackColor = Color.Red;
            }
            else
            {
                button30.Text = "X";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button31.BackColor = Color.Red;
            }
            else
            {
                button31.Text = "X";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button32.BackColor = Color.Red;
            }
            else
            {
                button32.Text = "X";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button33.BackColor = Color.Red;
            }
            else
            {
                button33.Text = "X";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button34.BackColor = Color.Red;
            }
            else
            {
                button34.Text = "X";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button35.BackColor = Color.Red;
            }
            else
            {
                button35.Text = "X";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button36.BackColor = Color.Red;
            }
            else
            {
                button36.Text = "X";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button37.BackColor = Color.Red;
            }
            else
            {
                button37.Text = "X";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button38.BackColor = Color.Red;
            }
            else
            {
                button38.Text = "X";
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 4
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button39.BackColor = Color.Red;
            }
            else
            {
                button39.Text = "X";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button40.BackColor = Color.Red;
            }
            else
            {
                button40.Text = "X";
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button41.BackColor = Color.Red;
            }
            else
            {
                button41.Text = "X";
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button42.BackColor = Color.Red;
            }
            else
            {
                button42.Text = "X";
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button43.BackColor = Color.Red;
            }
            else
            {
                button43.Text = "X";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button44.BackColor = Color.Red;
            }
            else
            {
                button44.Text = "X";
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button45.BackColor = Color.Red;
            }
            else
            {
                button45.Text = "X";
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button46.BackColor = Color.Red;
            }
            else
            {
                button46.Text = "X";
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button47.BackColor = Color.Red;
            }
            else
            {
                button47.Text = "X";
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button48.BackColor = Color.Red;
            }
            else
            {
                button48.Text = "X";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 5
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button49.BackColor = Color.Red;
            }
            else
            {
                button49.Text = "X";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button50.BackColor = Color.Red;
            }
            else
            {
                button50.Text = "X";
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button51.BackColor = Color.Red;
            }
            else
            {
                button51.Text = "X";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button52.BackColor = Color.Red;
            }
            else
            {
                button52.Text = "X";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button53.BackColor = Color.Red;
            }
            else
            {
                button53.Text = "X";
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button54.BackColor = Color.Red;
            }
            else
            {
                button54.Text = "X";
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button55.BackColor = Color.Red;
            }
            else
            {
                button55.Text = "X";
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button56.BackColor = Color.Red;
            }
            else
            {
                button56.Text = "X";
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button57.BackColor = Color.Red;
            }
            else
            {
                button57.Text = "X";
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button58.BackColor = Color.Red;
            }
            else
            {
                button58.Text = "X";
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 6
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button59.BackColor = Color.Red;
            }
            else
            {
                button59.Text = "X";
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button60.BackColor = Color.Red;
            }
            else
            {
                button60.Text = "X";
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button61.BackColor = Color.Red;
            }
            else
            {
                button61.Text = "X";
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button62.BackColor = Color.Red;
            }
            else
            {
                button62.Text = "X";
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button63.BackColor = Color.Red;
            }
            else
            {
                button63.Text = "X";
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button64.BackColor = Color.Red;
            }
            else
            {
                button64.Text = "X";
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button65.BackColor = Color.Red;
            }
            else
            {
                button65.Text = "X";
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button66.BackColor = Color.Red;
            }
            else
            {
                button66.Text = "X";
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button67.BackColor = Color.Red;
            }
            else
            {
                button67.Text = "X";
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button68.BackColor = Color.Red;
            }
            else
            {
                button68.Text = "X";
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 7
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button69.BackColor = Color.Red;
            }
            else
            {
                button69.Text = "X";
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button70.BackColor = Color.Red;
            }
            else
            {
                button70.Text = "X";
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button71.BackColor = Color.Red;
            }
            else
            {
                button71.Text = "X";
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button72.BackColor = Color.Red;
            }
            else
            {
                button72.Text = "X";
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button73.BackColor = Color.Red;
            }
            else
            {
                button73.Text = "X";
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button74.BackColor = Color.Red;
            }
            else
            {
                button74.Text = "X";
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button75.BackColor = Color.Red;
            }
            else
            {
                button75.Text = "X";
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button76.BackColor = Color.Red;
            }
            else
            {
                button76.Text = "X";
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button77.BackColor = Color.Red;
            }
            else
            {
                button77.Text = "X";
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button78.BackColor = Color.Red;
            }
            else
            {
                button78.Text = "X";
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 8
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button79.BackColor = Color.Red;
            }
            else
            {
                button79.Text = "X";
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button80.BackColor = Color.Red;
            }
            else
            {
                button80.Text = "X";
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button81.BackColor = Color.Red;
            }
            else
            {
                button81.Text = "X";
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button82.BackColor = Color.Red;
            }
            else
            {
                button82.Text = "X";
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button83.BackColor = Color.Red;
            }
            else
            {
                button83.Text = "X";
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button84.BackColor = Color.Red;
            }
            else
            {
                button84.Text = "X";
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button85.BackColor = Color.Red;
            }
            else
            {
                button85.Text = "X";
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button86.BackColor = Color.Red;
            }
            else
            {
                button86.Text = "X";
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button87.BackColor = Color.Red;
            }
            else
            {
                button87.Text = "X";
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button88.BackColor = Color.Red;
            }
            else
            {
                button88.Text = "X";
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 9
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button89.BackColor = Color.Red;
            }
            else
            {
                button89.Text = "X";
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button90.BackColor = Color.Red;
            }
            else
            {
                button90.Text = "X";
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 1,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button91.BackColor = Color.Red;
            }
            else
            {
                button91.Text = "X";
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 2,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button92.BackColor = Color.Red;
            }
            else
            {
                button92.Text = "X";
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 3,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button93.BackColor = Color.Red;
            }
            else
            {
                button93.Text = "X";
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 4,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button94.BackColor = Color.Red;
            }
            else
            {
                button94.Text = "X";
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 5,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button95.BackColor = Color.Red;
            }
            else
            {
                button95.Text = "X";
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 6,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button96.BackColor = Color.Red;
            }
            else
            {
                button96.Text = "X";
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 7,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button97.BackColor = Color.Red;
            }
            else
            {
                button97.Text = "X";
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 8,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button98.BackColor = Color.Red;
            }
            else
            {
                button98.Text = "X";
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 9,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button99.BackColor = Color.Red;
            }
            else
            {
                button99.Text = "X";
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Position thisCell = new Position()
            {
                x = 10,
                y = 10
            };
            if (na.AllShipsPosition.Any(n => n.x == thisCell.x && n.y == thisCell.y))
            {
                button100.BackColor = Color.Red;
            }
            else
            {
                button100.Text = "X";
            }
        }
    }
}