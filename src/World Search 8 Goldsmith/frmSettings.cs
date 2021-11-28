using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavigationMenu;

namespace World_Search_8_Goldsmith
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void navigtionMenu1_OnItemSelected(object sender, string path, EventArgs e)
        {
            switch (path)
            {
                case "Search Engain":
                    tabControl1.SelectedTab = tabSearch;
                    break;
                case "Homepage":
                    tabControl1.SelectedTab = tabHomepage;
                    break;
            }
        }

        private void tabSearch_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Homepage = bunifuTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void radGoogle_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radGoogle.Checked == true)
            {
                Properties.Settings.Default.Search = "https://www.google.com/search?q=";
                Properties.Settings.Default.SelectedSearch = "Google";
            }
        }

        private void radBing_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radBing.Checked == true)
            {
                Properties.Settings.Default.Search = "https://www.bing.com/search?q=";
                Properties.Settings.Default.SelectedSearch = "Bing";
            }
        }

        private void radBaidu_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radBaidu.Checked == true)
            {
                Properties.Settings.Default.Search = "https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=";
                Properties.Settings.Default.SelectedSearch = "Baidu";
            }
        }

        private void radYahoo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radYahoo.Checked == true)
            {
                Properties.Settings.Default.Search = "https://search.yahoo.com/search?p=";
                Properties.Settings.Default.SelectedSearch = "Yahoo";
            }
        }

        private void radYandex_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radYandex.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "Yandex";
                Properties.Settings.Default.Search = "https://yandex.com/search/?text=";
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void radAsk_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radAsk.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "Ask";
                Properties.Settings.Default.Search = "https://www.ask.com/web?q=";
            }
        }

        private void radDuckDuckGo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radDuckDuckGo.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "DuckDuckGo";
                Properties.Settings.Default.Search = "https://duckduckgo.com/?q=";
            }
        }

        private void radNaver_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radNaver.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "Naver";
                Properties.Settings.Default.Search = "https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=0&ie=utf8&query=";
            }
        }

        private void radAOL_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radAOL.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "AOL";
                Properties.Settings.Default.Search = "https://search.aol.com/aol/search?q=";
            }
        }

        private void radEcosia_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radEcosia.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "Ecosia";
                Properties.Settings.Default.Search = "https://www.ecosia.org/search?q=";
            }
        }

        private void radKiddle_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radKiddle.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "Kiddle";
                Properties.Settings.Default.Search = "https://www.kiddle.co/s.php?q=";
            }
        }

        private void radKidRex_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radKidRex.Checked == true)
            {
                Properties.Settings.Default.SelectedSearch = "KidRex";
                Properties.Settings.Default.Search = "https://cse.google.com/cse?cx=004805094470466704532:yjrgzqordo8&q=";
            }
        }

        private void radCustom_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radCustom.Checked == true)
            {
                txtCustom.Enabled = true;
                Properties.Settings.Default.SelectedSearch = "Custom";
                Properties.Settings.Default.Search = txtCustom.Text;
                button2.Enabled = true;
            }
            else
            {
                txtCustom.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            // Search Engain
            if (Properties.Settings.Default.SelectedSearch == "Bing")
            {
                radBing.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Google")
            {
                radGoogle.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Baidu")
            {
                radBaidu.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Yahoo")
            {
                radYahoo.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Yandex")
            {
                radYandex.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Ask")
            {
                radAsk.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "DuckDuckGo")
            {
                radDuckDuckGo.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Naver")
            {
                radNaver.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "AOL")
            {
                radAOL.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Ecosia")
            {
                radEcosia.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Kiddle")
            {
                radKiddle.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "KidRex")
            {
                radKidRex.Checked = true;
            }
            else if (Properties.Settings.Default.SelectedSearch == "Custom")
            {
                radCustom.Checked = true;
            }

            // Homepage
            bunifuTextBox1.Text = Properties.Settings.Default.Homepage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = bunifuTextBox1.Text;
        }
    }
}