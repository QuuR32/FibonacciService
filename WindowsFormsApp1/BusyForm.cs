using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Form displaying a loading image and a text
    /// </summary>
    public partial class BusyForm : Form
    {
        public BusyForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Overrided OnShown method allowing us to position this Form at the center of the owner Form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            if (Owner != null)
            {
                SetBounds(
                    Owner.Bounds.X + Owner.Bounds.Width / 2 - Bounds.Width / 2,
                    Owner.Bounds.Y + Owner.Bounds.Height / 2 - Bounds.Height / 2,
                    Bounds.Width,
                    Bounds.Height
                    );
            }

            base.OnShown(e);
        }
    }
}
