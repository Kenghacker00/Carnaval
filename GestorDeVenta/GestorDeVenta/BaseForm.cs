using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeVenta
{
    public class BaseForm : Form
    {
        protected void CenterPanel(Panel panel)
        {
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            CenterPanels();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                CenterPanels();
            }
        }

        private void CenterPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel panel)
                {
                    CenterPanel(panel);
                }
            }
        }
    }
}
