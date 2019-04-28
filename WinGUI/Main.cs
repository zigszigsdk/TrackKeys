using System;
using System.Windows.Forms;

using Core;

namespace WinGUI
{
    public partial class Main : Form
    {
        Parser _parser = new Parser();

        public Main()
        {
            InitializeComponent();
            SetDesktopBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Size.Height);
            inputTextbox.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, inputTextbox.Size.Height);
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true;

            _parser.Parse(inputTextbox.Text).ForEach(expression => expression.Executes());
            inputTextbox.Text = "";
        }
    }
}
