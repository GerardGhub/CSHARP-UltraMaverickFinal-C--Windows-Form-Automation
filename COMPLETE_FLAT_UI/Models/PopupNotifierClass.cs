using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace ULTRAMAVERICK.Models
{
    class PopupNotifierClass
    {


        public void DispatchedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Dispatched Successfully!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        public void NoOfPagesforPrintingMoveOrder()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Select number of pages for printing set-up!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.DarkSlateBlue;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        public void ActivatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Activated!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        public void InactiveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Inactive";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }



        public void CommittedSuccessFully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Committed Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }




        public void DataAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Data Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }





        public void FillRequiredFields()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
    }
}
