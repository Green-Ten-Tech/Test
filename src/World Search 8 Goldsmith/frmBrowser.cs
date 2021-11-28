using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Utils;
using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using Bunifu.UI.WinForms;
namespace World_Search_8_Goldsmith
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void InitializeChromium()
        {
            if (!Cef.IsInitialized)
            {
                CefSettings setting = new CefSettings();
                Cef.Initialize(setting);
            }
            //Loads your Homepage
            chromiumWebBrowser1.Load(Properties.Settings.Default.Homepage);

            //Events
            chromiumWebBrowser1.LoadingStateChanged += ChromiumWebBrowser1_LoadingStateChanged;
        }

        private void ChromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (e.IsLoading)
                    {
                        bunifuLoader1.Visible = true;
                    }
                    else
                    {
                        bunifuLoader1.Visible = false;
                    }
                }));
            }
        }
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Visible = true;
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text.Contains("."))
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else
            {
                chromiumWebBrowser1.Load(Properties.Settings.Default.Search + bunifuTextBox1.Text);
            }
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // e.KeyChar == (char)Keys.Enter
            {
                if (bunifuTextBox1.Text.Contains("."))
                {
                    chromiumWebBrowser1.Load(bunifuTextBox1.Text);
                }
                else
                {
                    chromiumWebBrowser1.Load(Properties.Settings.Default.Search + bunifuTextBox1.Text);
                }
            }
        }

        private void navigateSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text.Contains(".")) // e.KeyChar == (char)Keys.Enter
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else
            {
                chromiumWebBrowser1.Load(Properties.Settings.Default.Search + bunifuTextBox1.Text);
            }
        }

        private void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(Properties.Settings.Default.Homepage);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoForward)
            {
                chromiumWebBrowser1.Forward();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoBack)
            {
                chromiumWebBrowser1.Back();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backdrop.Show(new frmSettings());
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text.Contains(".com"))
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else if (bunifuTextBox1.Text.Contains(".org"))
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else if (bunifuTextBox1.Text.Contains(".net"))
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else if (bunifuTextBox1.Text.Contains(".gov"))
            {
                chromiumWebBrowser1.Load(bunifuTextBox1.Text);
            }
            else
            {
                chromiumWebBrowser1.Load(Properties.Settings.Default.Search + bunifuTextBox1.Text);
            }
        }

        private void bunifuTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // OR e.KeyChar == (char)Keys.Enter
            {
                e.Handled = true;
                
                if (bunifuTextBox1.Text.Contains(".com"))
                {
                    chromiumWebBrowser1.Load(bunifuTextBox1.Text);
                }
                else if (bunifuTextBox1.Text.Contains(".org"))
                {
                    chromiumWebBrowser1.Load(bunifuTextBox1.Text);
                }
                else if (bunifuTextBox1.Text.Contains(".net"))
                {
                    chromiumWebBrowser1.Load(bunifuTextBox1.Text);
                }
                else if (bunifuTextBox1.Text.Contains(".gov"))
                {
                    chromiumWebBrowser1.Load(bunifuTextBox1.Text);
                }
                else
                {
                    chromiumWebBrowser1.Load(Properties.Settings.Default.Search + bunifuTextBox1.Text);
                }
            }
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotepad notepad = new frmNotepad();
            notepad.ShowDialog();
        }
    }
}