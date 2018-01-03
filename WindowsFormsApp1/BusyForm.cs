using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Form displaying a loading image and a text
    /// </summary>
    public partial class BusyForm : Form
    {
        public const int INTERVAL = 1;

        public BusyForm()
        {
            InitializeComponent();
            FadeIn();
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

        protected async override void OnClosing(CancelEventArgs e)
        {
            await FadeOut();

            base.OnClosing(e);
        }

        private async Task FadeIn(int interval = INTERVAL)
        {
            Opacity = 0;

            //Object is not fully invisible. Fade it in
            while (Opacity < 1.0)
            {
                await Task.Delay(interval);
                Opacity += 0.05;
            }
            Opacity = 1; //make fully visible
        }

        private async Task FadeOut(int interval = INTERVAL)
        {
            //Object is fully visible. Fade it out
            while (Opacity > 0.0)
            {
                await Task.Delay(interval);
                Opacity -= 0.05;
            }
            Opacity = 0; //make fully invisible
        }
    }
}
