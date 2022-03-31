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
        public string Total_item_for_allocation { get; set; }
        public string Popup_barcode_identity { get; set; }
        public string PopperSp_Receiving_ID_RecommendedFefo { get; set; }
        public string WizzardMesage1 { get; set; }
        public string WizzardMesage2 { get; set; }
        public string WizzardMesage3 { get; set; }
        public string WizzardMesage4 { get; set; }
        public string ItemDescription { get; set; }



        public void YouHaveItemForAllocation()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "You have " + " " + this.Total_item_for_allocation +"" + " item for allocation";
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




        public void LabTestResultSuccessFullyReceived()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Lab Result successfully received!";
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



        public void BallonNotifyHover4()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "RESULT:" + " " + this.WizzardMesage4;
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


        public void BallonNotifyHover3()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "LABORATORY:" + " " +  this.WizzardMesage3;
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



        public void BallonNotifyHover2()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText ="APPROVAL:" + " " + this.WizzardMesage2;
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




        public void BallonNotifyHover()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "REQUEST:" + " " + this.WizzardMesage1;
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



        public void ErrorNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.sd;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Transaction Interupt Check the data to proceed!";
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



        public void LastLineofPreparationSubject()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "You are already reached the last line!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public void FirstLineofPreparationSubject()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "You are already reached the first line!";
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

        public void FeFoInformation()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "FEFO method select the recommended receiving ID " + PopperSp_Receiving_ID_RecommendedFefo + "!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }




        public void NotEnoughStockOnReceivingID()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Out of stock on receiving ID " + Popup_barcode_identity + "!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }



        public void ReceivingBarcodeIdIsnotExist()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Receiving ID is not exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;
            popup.ShowOptionsButton = true;


        }

        public void AllocationiSRequiredNotify()
        {
       

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Allocation is required for" + " "  +   this.Total_item_for_allocation + "" + " record(s)";
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

        public void GreaterThanAllocatedQty()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Greater than Allocated Qty!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        public void GreaterThanActualRemainingQty()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Greater than Actual Remaining Qty!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }


        public void GreaterThanActualRemainingQtyInformation()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Greater than Actual Remaining Qty!";
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



        public void ApprovedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Approved Successfully!";
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

        public void DoubleTaggingCategoryInformation()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Double tagging of category!";
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

        public void TripleTaggingCategoryInformation()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "You have already set a 2 category on this date!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
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
            popup.TitleText = "Notifications!";
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
            popup.ContentText = "Successfully Inactive!";
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
            popup.ContentText = "Your Data Has Been Successfully Saved";
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




        public void ImportSuccessFully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Import successfully";
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


        public void NotEnoughStock()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Not Enough Stock!";
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


        public void QCReceiverAlreadyApproved()
        {

            PopupNotifier popup = new PopupNotifier();
          
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Item Already Approved on QC Supervisor for receiving!";
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


        public void LessThanQtyReceived()
        {

            PopupNotifier popup = new PopupNotifier();

            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Less Than Qty Received";
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



        public void InvalidQuantity()
        {

            PopupNotifier popup = new PopupNotifier();
   
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Invalid Quantity!";
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


        public void RMNotExistReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
 
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "No Item for Receiving";
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



        public void SuccessfullyReceived()
        {

            PopupNotifier popup = new PopupNotifier();

            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Received";
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


        public void ItemFoundforReceiving()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "For Receiving '" + this.ItemDescription + "'";
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


        public void RawMaterialNotExist()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Item Not Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 11F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        public void UpdatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Resources.new_logo;
            popup.TitleText = "Notifications!";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(255, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Updated Successfully!";
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
