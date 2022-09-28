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
            ToolStripMenuItem TooldryWHInventorySubMenu,
            ToolStripMenuItem ToolStripStoreArea,
            ToolStripMenuItem ToolstoreRoute,
            ToolStripMenuItem ToolStores,
            ToolStripMenuItem ToolregionToolStripMenuItem,
            ToolStripMenuItem ToolsyncConsolidatedOrderToolStripMenuItem,
            ToolStripMenuItem ToolTsCustomer,
            ToolStripMenuItem ToolStripModuleItemClass,
            ToolStripMenuItem ToolStripModuleMajorCategory,
            ToolStripMenuItem ToolStripModuleSubCategory,
            ToolStripMenuItem ToolStripModulePrimaryUnit,
            ToolStripMenuItem ToolStripModuleItemType,
            ToolStripMenuItem ToolModuleRawMaterialsDry,
            ToolStripMenuItem ToolModuleConversionMgmt,
            ToolStripMenuItem ToollotManagementToolStripMenuItem,
            ToolStripMenuItem ToolaverageOrderTrendToolStripMenuItem,
            ToolStripMenuItem ToolorderCancelRemarksToolStripMenuItem,
            ToolStripMenuItem ToolmRSCancelRemarksToolStripMenuItem,
            ToolStripMenuItem ToolmrsOrderImportToolStripMenuItem
            )
        {
            for (int x = 0; x < dset_rights.Tables[0].Rows.Count; x++)
            {
                string form_name = dset_rights.Tables[0].Rows[x][1].ToString();

                //User Manager
                if (form_name == "toolUserManagement")
                { 
                    ToolUserManagement.Visible = true;
                }
                else if (form_name == "toolUserRights")
                {
                    ToolUserRights.Visible = true;

                }
                else if (form_name == "toolDepartment")
                {
                    ToolDepartment.Visible = true;

                }
                else if (form_name == "toolDepartmentUnit")
                {
                    ToolDepartmentUnit.Visible = true;

                }
                else if (form_name == "toolPosition")
                {
                    ToolPosition.Visible = true;

                }
                else if (form_name == "toolStripMenuReceipt")
                {
                    ToolStripMenuReceipt.Visible = true;

                }
                else if (form_name == "toolStripMenuIssue")
                {
                    ToolStripMenuIssue.Visible = true;
                }

                // Preparation
                else if (form_name == "toolDryStorePreparation")
                {
                    ToolDryStorePreparation.Visible = true;

                }
                else if (form_name == "toolDryInternalPreparation")
                {
                    ToolDryInternalPreparation.Visible = true;

                }
                else if (form_name == "allocationModule")
                {
                    ToolAllocationModule.Visible = true;

                }
                else if (form_name == "forApprovalToolStripMenuItem")
                {
                    ToolforApprovalToolStripMenuItem.Visible = true;

                }
                else if (form_name == "approvedOrderToolStripMenuItem")
                {
                    ToolapprovedOrderToolStripMenuItem.Visible = true;

                }
                else if (form_name == "preparationToolStripMenuItem")
                {
                    ToolpreparationToolStripMenuItem.Visible = true;

                }
                else if (form_name == "moveOrderToolStripMenuItem2")
                {
                    ToolmoveOrderToolStripMenuItem2.Visible = true;
                }
                else if (form_name == "readyForSchedulingToolStripMenuItem")
                {
                    ToolreadyForSchedulingToolStripMenuItem.Visible = true;
                }
                else if (form_name == "approvedScheduleToolStripMenuItem")
                {
                    ToolapprovedScheduleToolStripMenuItem.Visible = true;
                }
                else if (form_name == "preparationToolStripMenuItem1")
                {
                    ToolpreparationToolStripMenuItem1.Visible = true;
                }
                //Lab Test 
                else if (form_name == "toolStripMenuDryLabTest")
                {
                    TooltoolStripMenuDryLabTest.Visible = true;
                }
                else if (form_name == "toolStripMenuItemLabTransaction")
                {
                    ToolStripMenuItemLabTransaction.Visible = true;
                }
                else if (form_name == "toolStripMenuItemRMNearlyExpiryMgmt")
                {
                    ToolStripMenuItemRMNearlyExpiryMgmt.Visible = true;
                }

                //    //Import Dry
                else if (form_name == "dryRawMaterialsToolStripMenuItem")
                {
                    TooldryRawMaterialsToolStripMenuItem.Visible = true;

                }
                else if (form_name == "poSummaryToolStripMenuItem")
                {
                    ToolpoSummaryToolStripMenuItem.Visible = true;

                }
                else if (form_name == "ImportStoreDry")
                {
                    ToolImportStoreDry.Visible = true;

                }
                else if (form_name == "consolidatedOrderToolStripMenuItem")
                {
                    ToolconsolidatedOrderToolStripMenuItem.Visible = true;

                }
                else if (form_name == "orderRESTAPIToolStripMenuItem")
                {
                    ToolorderRESTAPIToolStripMenuItem.Visible = true;

                }
                else if (form_name == "pendingOrderToolStripMenuItem")
                {
                    ToolpendingOrderToolStripMenuItem.Visible = true;

                }
                else if (form_name == "mrsOrderImportToolStripMenuItem")
                {
                   ToolmrsOrderImportToolStripMenuItem.Visible = true;

                }
                //    //End Import Dry



                //Start Menu
                else if (form_name == "toolParentMenu")
                {
                    ToolParentMenu.Visible = true;
                }

                else if (form_name == "toolChildMenu")
                {
                    ToolChildMenu.Visible = true;
                }

                else if (form_name == "toolGrandChildMenu")
                {
                    ToolGrandChildMenu.Visible = true;
                }
                //End Menu

                //Receiving
                else if (form_name == "listOfReceivingToolStripMenuItem")
                {
                    ToollistOfReceivingToolStripMenuItem.Visible = true;
                }

                else if (form_name == "rMReceivingToolStripMenuItem")
                {
                    ToolrMReceivingToolStripMenuItem.Visible = true;
                }

                else if (form_name == "rMBarcodeModuleToolStripMenuItem")
                {
                    ToolrMBarcodeModuleToolStripMenuItem.Visible = true;
                }

                else if (form_name == "rMBarcodeReprintingToolStripMenuItem")
                {
                    ToolrMBarcodeReprintingToolStripMenuItem.Visible = true;
                }

                //END Receiving
                //Start Inventory
                else if (form_name == "dryWHInventorySubMenu")
                {
                    TooldryWHInventorySubMenu.Visible = true;
                }
                //End Inventory

                //Setup Store
                else if (form_name == "toolStripStoreArea")
                {
                    ToolStripStoreArea.Visible = true;
                }
                else if (form_name == "storeRoute")
                {
                    ToolstoreRoute.Visible = true;
                }

                else if (form_name == "toolStores")
                {
                    ToolStores.Visible = true;
                }
                else if (form_name == "regionToolStripMenuItem")
                {
                    ToolregionToolStripMenuItem.Visible = true;
                }
                else if (form_name == "syncConsolidatedOrderToolStripMenuItem")
                {
                    ToolsyncConsolidatedOrderToolStripMenuItem.Visible = true;
                }
                else if (form_name == "TsCustomer")
                {
                    ToolTsCustomer.Visible = true;
                }

                //Setup End

                //Raw Material
                else if (form_name == "toolStripModuleItemClass")
                {
                    ToolStripModuleItemClass.Visible = true;
                }
                else if (form_name == "toolStripModuleMajorCategory")
                {
                    ToolStripModuleMajorCategory.Visible = true;
                }
                else if (form_name == "toolStripModuleSubCategory")
                {
                    ToolStripModuleSubCategory.Visible = true;
                }
                else if (form_name == "toolStripModulePrimaryUnit")
                {
                    ToolStripModulePrimaryUnit.Visible = true;
                }
                else if (form_name == "toolStripModuleItemType")
                {
                    ToolStripModuleItemType.Visible = true;
                }
                else if (form_name == "toolModuleRawMaterialsDry")
                {
                    ToolModuleRawMaterialsDry.Visible = true;
                }
                else if (form_name == "toolModuleConversionMgmt")
                {
                    ToolModuleConversionMgmt.Visible = true;
                }

                else if (form_name == "lotManagementToolStripMenuItem")
                {
                    ToollotManagementToolStripMenuItem.Visible = true;
                }
                else if (form_name == "averageOrderTrendToolStripMenuItem")
                {
                    ToolaverageOrderTrendToolStripMenuItem.Visible = true;
                }
                else if (form_name == "orderCancelRemarksToolStripMenuItem")
                {
                    ToolorderCancelRemarksToolStripMenuItem.Visible = true;
                }
                else if (form_name == "mRSCancelRemarksToolStripMenuItem")
                {
                    ToolmRSCancelRemarksToolStripMenuItem.Visible = true;
                }

                //End Raw Material

            }
        }
    }
}
