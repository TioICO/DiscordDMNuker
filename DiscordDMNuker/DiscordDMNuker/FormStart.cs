﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordDMNuker
{
    public partial class FormStart : Form
    {
        public bool Start = false;
        public ulong UserId;
        public string Token;
        public int Delay;
        public bool SavePicsNVids;
        public bool SaveMessages;
        public bool Delete;
        public bool IsGroupChat;
        public FormStart()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            Delay = (int)numericUpDown1.Value;
            UserId = Convert.ToUInt64(textBox1.Text.Trim());
            Token = textBox2.Text.Trim();
            SavePicsNVids = checkBox1.Checked;
            SaveMessages = checkBox2.Checked;
            Delete = checkBox3.Checked;
            IsGroupChat = checkBox4.Checked;
            this.Close();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }
    }
}
