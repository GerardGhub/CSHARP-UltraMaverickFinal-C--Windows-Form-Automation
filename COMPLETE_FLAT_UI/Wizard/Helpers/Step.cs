using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULTRAMAVERICK.Wizard.Helpers
{
    public class Step
    {
        public void Back(Form ParentForm, string currentImageBox, string previousImageBox, string previousPageName)
        {
            // resolve images
            SiticonePictureBox currentPictureBox = (SiticonePictureBox)ParentForm.Controls.Find(currentImageBox, false)[0];
            currentPictureBox.Image = Properties.Resources.pending;

            SiticonePictureBox previousPictureBox = (SiticonePictureBox)ParentForm.Controls.Find(previousImageBox, false)[0];
            previousPictureBox.Image = Properties.Resources.current;

            // resolve pages
            ParentForm.Controls.Find("PanelSlider", false)[0].Controls.Find(previousPageName, false)[0].BringToFront();
        }

        public void Forward(Form ParentForm, string currentImageBox, string nextImageBox, string nextPageName)
        {
            // resolve images 
            SiticonePictureBox currentPictureBox = (SiticonePictureBox)ParentForm.Controls.Find(currentImageBox, false)[0];
            currentPictureBox.Image = Properties.Resources.completed;

            SiticonePictureBox nextPictureBox = (SiticonePictureBox)ParentForm.Controls.Find(nextImageBox, false)[0];
            nextPictureBox.Image = Properties.Resources.current;

            // resolve pages
            ParentForm.Controls.Find("PanelSlider", false)[0].Controls.Find(nextPageName, false)[0].BringToFront();
        }


    }
}
