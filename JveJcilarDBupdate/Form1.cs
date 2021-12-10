﻿using JavaVeJavacilar.Forms;
using JveJcilarDBupdate.Forms;
using KafeAdisyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JveJcilarDBupdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private frmKatlar frmKatlar;

        private void katAyarlaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmKatlar == null || frmKatlar.IsDisposed)
            {
                frmKatlar = new frmKatlar();
            }
            frmKatlar.MdiParent = this;
            frmKatlar.WindowState = FormWindowState.Maximized;
            frmKatlar.Show();
        }
        frmKafeBilgi frmKafeBilgi;
        private void kafeBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKafeBilgi == null || frmKafeBilgi.IsDisposed)
            {
                frmKafeBilgi = new frmKafeBilgi();
            }
            frmKafeBilgi.MdiParent = this;
            frmKafeBilgi.WindowState = FormWindowState.Maximized;
            frmKafeBilgi.Show();
        }
        frmMenu frmMenu;
        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMenu == null || frmMenu.IsDisposed)
            {
                frmMenu = new frmMenu();
            }
            frmMenu.MdiParent = this;
            frmMenu.WindowState = FormWindowState.Maximized;
            frmMenu.Show();
        }
        KafeGorunumForm frmKafeGorunum;
        private void kafeGörünümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKafeGorunum == null || frmKafeGorunum.IsDisposed)
            {
                frmKafeGorunum = new KafeGorunumForm();
            }
            frmKafeGorunum.MdiParent = this;
            frmKafeGorunum.WindowState = FormWindowState.Maximized;
            frmKafeGorunum.Show();
        }
    }
}
