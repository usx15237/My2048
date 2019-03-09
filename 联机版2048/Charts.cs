using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048Game
{
    public partial class Charts : Form
    {
        List<Player> players = OverForm.players;

        public Charts()
        {
            InitializeComponent();


            if (players.Count >= 2)
            {
                Sort();
            }
            ListView();
        }

        public void ListView()
        {


            if (players.Count <= 5)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    this.listView1.Items.Add((i + 1).ToString());
                    this.listView1.Items.Add(players[i].Name.ToString());
                    this.listView1.Items.Add(players[i].Score.ToString());
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    this.listView1.Items.Add((i + 1).ToString());
                    this.listView1.Items.Add(players[i].Name.ToString());
                    this.listView1.Items.Add(players[i].Score.ToString());
                }
            }


        }
        public void Sort()
        {
            for (int i = 0; i <= players.Count - 2; i++)
            {
                for (int j = 1; j <= players.Count - 1; j++)
                {
                    if (players[i].Score < players[j].Score)
                    {
                        Player p = players[j];
                        players[j] = players[i];
                        players[i] = p;
                    }
                }
            }
        }
    }
}
