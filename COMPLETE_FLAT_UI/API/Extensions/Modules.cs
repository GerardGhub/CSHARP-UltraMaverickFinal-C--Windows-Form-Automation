using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULTRAMAVERICK.API.Extensions
{
    public class Modules
    {
  
        public void SubMenu(DataSet dset_rights,
            ToolStripMenuItem ToolUserManagement,
            ToolStripMenuItem ToolUserRights,
            ToolStripMenuItem ToolDepartment,
            ToolStripMenuItem ToolDepartmentUnit,
            ToolStripMenuItem ToolPosition,
            ToolStripMenuItem ToolStripMenuReceipt,
            ToolStripMenuItem ToolStripMenuIssue,
            ToolStripMenuItem ToolDryStorePreparation,
            ToolStripMenuItem ToolDryInternalPreparation,
            ToolStripMenuItem ToolAllocationModule,
            ToolStripMenuItem ToolforApprovalToolStripMenuItem,
            ToolStripMenuItem ToolapprovedOrderToolStripMenuItem,
            ToolStripMenuItem ToolpreparationToolStripMenuItem,
            ToolStripMenuItem ToolmoveOrderToolStripMenuItem2,
            ToolStripMenuItem ToolreadyForSchedulingToolStripMenuItem,
            ToolStripMenuItem ToolapprovedScheduleToolStripMenuItem,
            ToolStripMenuItem ToolpreparationToolStripMenuItem1,
            ToolStripMenuItem TooltoolStripMenuDryLabTest,
            ToolStripMenuItem ToolStripMenuItemLabTransaction,
            ToolStripMenuItem ToolStripMenuItemRMNearlyExpiryMgmt,
            ToolStripMenuItem TooldryRawMaterialsToolStripMenuItem,
            ToolStripMenuItem ToolpoSummaryToolStripMenuItem,
            ToolStripMenuItem ToolImportStoreDry,
            ToolStripMenuItem ToolconsolidatedOrderToolStripMenuItem,
            ToolStripMenuItem ToolorderRESTAPIToolStripMenuItem,
            ToolStripMenuItem ToolpendingOrderToolStripMenuItem,
            ToolStripMenuItem ToolParentMenu,
            ToolStripMenuItem ToolChildMenu,
            ToolStripMenuItem ToolGrandChildMenu,
            ToolStripMenuItem ToollistOfReceivingToolStripMenuItem,
            ToolStripMenuItem ToolrMReceivingToolStripMenuItem,
            ToolStripMenuItem ToolrMBarcodeModuleToolStripMenuItem,
            ToolStripMenuItem ToolrMBarcodeReprintingToolStripMenuItem,
            ToolStripMenuItem TooldryWHInventorySubMenu
            )
        {
            for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
            {
                string form_name = dset_rights.Tables[0].Rows[x][1].ToString();

                //User Manager
                if (form_name == "toolUserManagement")
                { 
                    ToolUserManagement.Enabled = true;
                }
                else if (form_name == "toolUserRights")
                {
                    ToolUserRights.Enabled = true;

                }
                else if (form_name == "toolDepartment")
                {
                    ToolDepartment.Enabled = true;

                }
                else if (form_name == "toolDepartmentUnit")
                {
                    ToolDepartmentUnit.Enabled = true;

                }
                else if (form_name == "toolPosition")
                {
                    ToolPosition.Enabled = true;

                }
                else if (form_name == "toolStripMenuReceipt")
                {
                    ToolStripMenuReceipt.Enabled = true;

                }
                else if (form_name == "toolStripMenuIssue")
                {
                    ToolStripMenuIssue.Enabled = true;
                }

                // Preparation
                else if (form_name == "toolDryStorePreparation")
                {
                    ToolDryStorePreparation.Enabled = true;

                }
                else if (form_name == "toolDryInternalPreparation")
                {
                    ToolDryInternalPreparation.Enabled = true;

                }
                else if (form_name == "allocationModule")
                {
                    ToolAllocationModule.Enabled = true;

                }
                else if (form_name == "forApprovalToolStripMenuItem")
                {
                    ToolforApprovalToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "approvedOrderToolStripMenuItem")
                {
                    ToolapprovedOrderToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "preparationToolStripMenuItem")
                {
                    ToolpreparationToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "moveOrderToolStripMenuItem2")
                {
                    ToolmoveOrderToolStripMenuItem2.Enabled = true;
                }
                else if (form_name == "readyForSchedulingToolStripMenuItem")
                {
                    ToolreadyForSchedulingToolStripMenuItem.Enabled = true;
                }
                else if (form_name == "approvedScheduleToolStripMenuItem")
                {
                    ToolapprovedScheduleToolStripMenuItem.Enabled = true;
                }
                else if (form_name == "preparationToolStripMenuItem1")
                {
                    ToolpreparationToolStripMenuItem1.Enabled = true;
                }
                //Lab Test 
                else if (form_name == "toolStripMenuDryLabTest")
                {
                    TooltoolStripMenuDryLabTest.Enabled = true;
                }
                else if (form_name == "toolStripMenuItemLabTransaction")
                {
                    ToolStripMenuItemLabTransaction.Enabled = true;
                }
                else if (form_name == "toolStripMenuItemRMNearlyExpiryMgmt")
                {
                    ToolStripMenuItemRMNearlyExpiryMgmt.Enabled = true;
                }

                //    //Import Dry
                else if (form_name == "dryRawMaterialsToolStripMenuItem")
                {
                    TooldryRawMaterialsToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "poSummaryToolStripMenuItem")
                {
                    ToolpoSummaryToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "ImportStoreDry")
                {
                    ToolImportStoreDry.Enabled = true;

                }
                else if (form_name == "consolidatedOrderToolStripMenuItem")
                {
                    ToolconsolidatedOrderToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "orderRESTAPIToolStripMenuItem")
                {
                    ToolorderRESTAPIToolStripMenuItem.Enabled = true;

                }
                else if (form_name == "pendingOrderToolStripMenuItem")
                {
                    ToolpendingOrderToolStripMenuItem.Enabled = true;

                }
                //    //End Import Dry

        

                //Start Menu
                else if (form_name == "toolParentMenu")
                {
                    ToolParentMenu.Enabled = true;
                }

                else if (form_name == "toolChildMenu")
                {
                    ToolChildMenu.Enabled = true;
                }

                else if (form_name == "toolGrandChildMenu")
                {
                    ToolGrandChildMenu.Enabled = true;
                }
                //End Menu

                //Receiving
                else if (form_name == "listOfReceivingToolStripMenuItem")
                {
                    ToollistOfReceivingToolStripMenuItem.Enabled = true;
                }

                else if (form_name == "rMReceivingToolStripMenuItem")
                {
                    ToolrMReceivingToolStripMenuItem.Enabled = true;
                }

                else if (form_name == "rMBarcodeModuleToolStripMenuItem")
                {
                    ToolrMBarcodeModuleToolStripMenuItem.Enabled = true;
                }

                else if (form_name == "rMBarcodeReprintingToolStripMenuItem")
                {
                    ToolrMBarcodeReprintingToolStripMenuItem.Enabled = true;
                }

                //END Receiving
                //Start Inventory
                else if (form_name == "dryWHInventorySubMenu")
                {
                    TooldryWHInventorySubMenu.Enabled = true;
                }
                //End Inventory

            }
        }
    }
}
