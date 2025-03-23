using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public static class PanelExtensions
    {
        public static Panel Clone(this Panel panel)
        {
            Panel panel1 = new Panel
            {
                Size = panel.Size,
                Location = panel.Location,
                BorderStyle = panel.BorderStyle,
                Tag = panel.Tag,
                Cursor = panel.Cursor,
            };
            foreach (Control control in panel.Controls)
            {
                Control newControls=(Control)Activator.CreateInstance(control.GetType());    
                newControls.Size = control.Size;
                newControls.Location = control.Location;
                newControls.Text = control.Text;
                newControls.Font = control.Font;
                newControls.BackColor=control.BackColor;
                newControls.ForeColor=control.ForeColor;
                newControls.Cursor = control.Cursor;
                if (control is PictureBox pictureBox && pictureBox.Image != null)
                {
                    ((PictureBox)newControls).Image = new Bitmap(pictureBox.Image);
                    ((PictureBox)newControls).SizeMode = pictureBox.SizeMode;

                }
                panel1.Controls.Add(newControls);
                
            }
            return panel1;
        }
    }
}
