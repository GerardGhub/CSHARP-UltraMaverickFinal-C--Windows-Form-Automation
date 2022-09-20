using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AutoSproc;

namespace ULTRAMAVERICK.Models
{
    public interface IStoredProcedures : ISprocBase
    {
        DataSet DisciplinaryInitialResolutionReleased(int daId);

        //from login page - user's login
        DataSet sp_userlogin(string username, string password);

        //general (any pages) - get single table
        DataSet sp_getMinorTables(string eTableName,
            int? pkId,
            string string_data_find,
            string string_data_find2,
            string string_data_find3,
            string string_data_find4);
        DataSet sp_getFilterTables(string eTableName, string eDescription, int ePk);

        DataSet sp_GetCategory(string eTableName, int? cid, string feed_code, string category, string fgdate);

        //store proc for getting table data - with joins
        DataSet sp_getMajorTables(string eTableName);

        DataSet sp_department(int department_id, string department_name, string mode);
        DataSet rdf_sp_category(int category_id, string category_name, string mode);
        DataSet rdf_sp_prod_type(int type_id, string type_name, string mode);

        DataSet rdf_sp_supplier(int supplier_id, string supplier, string contact_no, string address, string email_address, string mode);
        DataSet rdf_sp_prod_schedules(int prod_id, string p_feed_code, string p_bags, string p_nobatch, string proddate, string dateadded, string iscancelreason, string feed_type, string series_num, string bagorbin, string additional_bin, string corn_type, string planning_by, string mode);

        //Move order

        DataSet rdf_sp_move_order(int move_id, string order_no, string date_time, string warehouse, string account_title, string customer, string address, string feed_code, string feed_type, string sack_bin, string production_date, string qty, string uom, string qty_received, string available, string grand_total, string production, string added_by, string date_added, int bags, string cancel_by, string cancel_date, string myfg_id, string mode);

        DataSet rdf_sp_transact_rdf_move_order(int move_id, string order_no, string date_time, string warehouse, string account_title, string customer, string address, string feed_code, string feed_type, string sack_bin, string production_date, float qty, string uom, string qty_received, float available, float grand_total, string production, string added_by, string date_added, int is_active, float bags, string platenumber, string mode);


        DataSet sp_transaction_in(int transact_id, string item_code, string item_description, string category, string supplier, string qty, string time_stamp, string mfg_date, string expiry_date, string remarks, string date_added, string added_by, string expiry_days, string transact_number, string material_id, string mode);

        DataSet sp_transaction_out(int transact_id, string item_code, string item_description, string category, string supplier, string qty, string time_stamp, string mfg_date, string expiry_date, string remarks, string date_added, string added_by, string expiry_days, string transact_number, string material_id, string counter_map, string last_stock, string warehouse, string account_title, string customer, string address, string reason, string descripto, string mode);


 



       

        DataSet sp_employee_new(int employee_id,
                          string employee_number,
                          string lastname,
                          string firstname,
                          string middlename,
                          string address,
                          string gender,
                          string contactno,
                          DateTime birthdate,
                          string sss_number,
                          string tin_number,
                          int civil_status_id,
                          int tax_id,
                          int department_id,
                          int section_id,
                          int position_id,
                          int employment_status_id,
                          DateTime date_hired,
                          DateTime date_regularization,
                          string PermanentAddress,
                          string philhealth_number,
                          string hdmf_number,
                          string hdmf_rtn,
                          string salary_rate,
                          string salary_structure,
                          int salary_type_id,
                          int workers_id,
                          string mode,
                          string InCaseOfEmergencyName,
                          string InCaseOfEmergencyNumber,
                            string Ros_hrd,
                            string remarks,
                          Byte[] image_employee
                          );



        DataSet sp_micro_new(int item_id,
                                int item_category,
                                string item_code,
                                int supplier,
                                string item_description,
                                string classification,
                                string quantity,
                                DateTime date_added,
                                string expiration_details,
                                string delivery_details,
                                string added_by,
                                string item_location,
                                string item_remarks,
                                string item_added_by,
                                string per_bag,
                                string mode,
                     Byte[] raw_material_image
                     );

        DataSet sp_micro_new(int item_id, string item_code, string mode);
        DataSet sp_employee_new(int employee_id, string employee_number, string mode);
        DataSet sp_employee_new(int employee_id, DateTime date_resigned, string mode);

        DataSet sp_attendance_monitoring(int attendance_monitoring_id
                                          , DateTime date_created
                                          , int employee_id
                                          , int leave_id
                                          , string reason_cause
                                          , int clinic_id
                                          , bool with_leave
                                          , bool with_medical
                                          , int doctors_id
                                          , int sickness_id
                                          , int user_id
                                          , string mode);



        DataSet sp_userfile(int userfile_id,
            int user_rights_id,
            string username, string password,
            string employee_name,
            string user_section,
            string receiving_status,
            string Position,
            string employee_lastname,
            string Department,
            string requestor_type,
            string Unit,
            string gender,
            Byte[] image_employee,
            string mode);

        DataSet sp_userfileIncrement(int userfile_id,
         int user_rights_id,
         string username, string password,
         string employee_name,
         string user_section,
         string receiving_status,
         string Position,
         string employee_lastname,
         string Department,
         string requestor_type,
         string Unit,
         string gender,
         string mode);

        DataSet sp_userfile(int userfile_id, string username, string password, string user_section, string mode);






        DataSet sp_position(
        int position_id,
        string position_name,
        string department_id,
        string created_by,
        string created_at,
        string modified_by,
        string modified_date,
        string primary_user_id,
        string mode);


        DataSet sp_department(
        int department_id,
        string department_name,
        string created_by,
        string created_at,
        string updated_at,
        string updated_by,
        string primary_user_id,
        string location_id,
        string mode);



        DataSet sp_ParentForms(
     int parent_id,
     string parent_form_name,
     string created_at,
     string created_by,
     string updated_at,
     string updated_by,
     string primary_user_id,
     string department,
     string mode);



      DataSet sp_TypeofApprover(
     int approver_id,
     string type_of_approver,
     string created_at,
     string created_by,
     string updated_at,
     string updated_by,
     string mode);




        DataSet sp_available_menu(int menu_id,
            string menu_name,
            string menu_form_name,
            string menu_count,
            string created_at,
            string created_by,
            string updated_at,
            string updated_by,
            string mode);


        DataSet sp_Item_Class(int item_class_id,
        string item_class_desc,
        string item_added_by,
        string item_added_at,
        string item_updated_at,
        string item_updated_by,
        string mode);


        DataSet sp_Tblwarehouses(int wh_id,
            string wh_description,
            string wh_account_title,
            string wh_added_by,
            string wh_date_added,
            string mode);


        DataSet sp_Allocation_Logs(int allocation_id,
            string a_item_code,
            string a_item_desc,
            string allocation_qty,
            string allocate_by,
            string allocate_date,
            string order_key,
            int total_row,
            int total_column_qty,
            string mode);


        DataSet sp_Store_order_force_cancel_logs(int id,
        int preparation_fk,
        string store_code,
        string qty,
        string is_cancel_by,
        string is_cancel_date,
        int dry_order_fk,
        string item_code,
        string mode);


        DataSet sp_Store_Preparation_Logs(int prepa_id,
        string prepa_source_key,
        string prepa_approved_prepa_date,
        string prepa_item_code,
        string prepa_item_description,
        string prepa_order_qty,
        string prepa_allocated_qty,
        string prepa_date_added,
        string prepa_added_by,
        int order_source_key,
        string fox,
        string route,
        string area,
        int FK_dry_wh_orders_parent_id,
        string mode);


        DataSet sp_Dry_Wh_Order_Parent(int id,
        string approve_preparation,
        string fox,
        string store_name,
        string route,
        string area,
        string category,
        int start_by_user_id,
        string is_approved,
        int is_approved_by,
        string is_approved_date,
        string is_approved_prepa_date,
        string is_active,
        string mode);



        DataSet sp_Internal_Preparation_Logs(int prepa_id,
       string prepa_source_key,
       string prepa_approved_prepa_date,
       string prepa_item_code,
       string prepa_item_description,
       string prepa_order_qty,
       string prepa_allocated_qty,
       string prepa_date_added,
       string prepa_added_by,
       int order_source_key,
       string fox,
       string route,
       string area,
       string mode);


        DataSet sp_avg_order_trend(int avg_id,
        string avg_desc,
        int avg_days,
        string added_by,
        string date_added,
        string updated_by,
        string updated_date,
        string mode);

        DataSet sp_store_order_activation_remarks(int soar_id,
        string soar_desc,
        string soar_type,
        string soar_added_by,
        string soar_date_added,
        string soar_updated_by,
        string soar_updated_date,
        string mode);


        DataSet sp_internal_order_activation_remarks(int soar_id,
        string soar_desc,
        string soar_type,
        string soar_added_by,
        string soar_date_added,
        string soar_updated_by,
        string soar_updated_date,
        string mode);



        DataSet sp_Major_Category(int major_category_id,
        string major_category_desc,
        string mc_added_by,
        string mc_added_at,
        string mc_updated_at,
        string mc_updated_by,
        string mode);


        DataSet sp_lot_management(
        int id,
        string lot_number,
        string description,
        string category,
        string added_by,
        string date_added,
        string updated_by,
        string date_updated,
        string mode);


        DataSet sp_tblDryWHReceiving(
        int id,
        int index_id_partial,
        string item_code,
        string item_description,
        string qty_received,
        string date_added,
        string added_by,
        string updated_by,
        string updated_date,
        string supplier,
        string lot_no,
        string lot_description,
        string mfg_date,
        string exp_date,
        string category,
        string uom,
        string qty_reject,
        int po_number,
        int added_by_userid,
        string is_expiry_received,
        string po_date,
        string pr_no,
        string pr_date,
        string FK_Sub_Category_SubCategoryDesc,
        int FK_Sub_Category_IsExpirable,
        string FileName,
        string FilePath,
        string mode);



        DataSet sp_dry_wh_lab_test_req_logs(
        int lab_req_id,
        string item_code,
        string item_desc,
        string category,
        string qty_received,
        string remaining_qty,
        string days_to_expired,
        string lab_status,
        string historical,
        string aging,
        string remarks,
        string fk_receiving_id,
        string added_by,
        string bbd,
        string lab_access_code,
        int po_number,
        int pr_number,
        decimal sample_qty,
        string mode);


        DataSet sp_tblDryPartialReceivingRejection(
        int id,
        int index_id,
        int po_number,
        int qty_reject,
        string reject_remarks,
        string added_by,
        string date_added,
        string updated_by,
        string updated_date,
        int projection_identity,
        string mode);


        DataSet sp_Sub_Category(int sub_category_id,
      string sub_category_desc,
      string sc_added_by,
      string sc_added_at,
      string sc_updated_at,
      string sc_updated_by,
      string is_expirable,
      string mode);

        DataSet sp_Primary_Unit(int unit_id,
            string unit_desc,
            string pm_added_by,
            string pm_added_at,
            string pm_updated_at,
            string pm_updated_by,
            string mode);

        DataSet sp_Item_Type(int item_type_id,
        string item_type_desc,
        string it_added_by,
        string it_added_at,
        string it_updated_at,
        string it_updated_by,
        string mode);

        DataSet sp_tblArea(int area_id,
        string area_name,
        string added_by,
        string date_added,
        string modified_by,
        string modified_at,
        string mode);

        DataSet sp_tblRoute(int route_id,
        string route_name,
        string added_by,
        string date_added,
        string modified_by,
        string modified_at,
        string mode);

        DataSet sp_tblRegion(int region_id,
        string region_description,
        string is_active,
        string added_by,
        string date_added,
        string modified_by,
        string modified_at,
        string mode);

        DataSet sp_TblStoreOrderManageSyncing(
             int id,
             string time_from_desc,
             string time_from_to,
             string added_by,
             string date_added,
             string updated_by,
             string updated_at,
             string mode);



        DataSet sp_tbl_stores(
        int stored_id,
        string store_name,
        string store_area,
        string store_code,
        string store_route,
        string added_by,
        string date_added,
        string modified_by,
        string modified_date,
        string region,
        string mode);

        DataSet sp_dry_wh_orders(
        int primary_id,
        int order_id,
        string date_ordered,
        string fox,
        string store_name,
        string route,
        string area,
        string category,
        string item_code,
        string description,
        string uom,
        string qty,
        string is_active,
        string date_added,
        string added_by,
        string dateneeded,
        string mode);


        DataSet sp_Raw_Materials_Dry(
        int item_id,
        string item_code,
        string item_description,
        string item_class,
        string major_category,
        string sub_category,
        string primary_unit,
        string conversion,
        string item_type,
        string created_at,
        string created_by,
        string updated_at,
        string updated_by,
        float buffer_stock,
        string expiration_prompting,
        string mode);

        DataSet Sp_DryWHReceipt(
        int Id,
        string ParentDescription,
        int TransactionNo,
        int LotNumber,
        string LotDescription,
        string ManufacturingDate,
        string ExpirationDate,
        string ExpiryDays,
        string ItemCode,
        string ItemDescription,
        string Category,
        string Supplier,
        double Quantity,
        string Remarks,
        string AddedBy,
        string DateAdded,
        bool IsActive,
        string mode);



        DataSet Sp_DryWHIssue(
        int Id,
        string ParentDescription,
        int TransactionNo,
        int LotNumber,
        string LotDescription,
        string ManufacturingDate,
        string ExpirationDate,
        string ExpiryDays,
        string ItemCode,
        string ItemDescription,
        string Category,
        string Supplier,
        double Quantity,
        string Remarks,
        string AddedBy,
        string DateAdded,
        bool IsActive,
        int ActualQty,
        int ReceivingId,
        string mode);


        DataSet sp_DryWHReceiptParents(
        int Id,
        string ParentDescription,
        string Remarks,
        bool IsActive,
        string AddedBy,
        DateTime DateAdded,
        string mode);


            DataSet sp_DryWHIssueParents(
            int Id,
            string ParentDescription,
            string Remarks,
            bool IsActive,
            string AddedBy,
            DateTime DateAdded,
            string mode);





        DataSet sp_tblCustomers(
        int cust_id,
        string cust_name,
        string cust_type,
        string cust_company,
        string cust_mobile,
        string cust_leadman,
        string cust_address,
        int cust_added_by,
        string cust_date_added,
        string cust_updated_by,
        string cust_date_updated,
        bool is_active,
        string mode);

        DataSet sp_projects(
        int primaryid,
        string projectid,
        string actual_remaining_receiving,
        string projectname,
        string pr_number,
        string pr_date,
        string po_number,
        string po_date,
        string item_code,
        string item_description,
        string qty_order,
        string qty_delivered,
        string qty_billed,
        string qty_uom,
        string unit_price,
        string supplier,
        string item_class,
        string item_type,
        string major_category,
        string sub_category,
        string is_expirable,
        string mode);


        DataSet sp_PrimaryUnitManagement(
        int id,
        string active_pu_primary_id,
        string active_pu_description,
        string active_pu_conversion,
        string item_primary_id,
        string item_item_code,
        string item_description,
        string created_at,
        string created_by,
        string modified_at,
        string modified_by,
        string is_active,
        string mode);



        DataSet sp_Location(int location_id,
        string location_name,
        string created_at,
        string created_by,
        string updated_at,
        string updated_by,
        string mode);



        DataSet sp_available_menu_grandChild(int menu_id,
      string menu_name,
      string menu_form_name,
      string parent_menu,
      string created_at,
      string created_by,
      string updated_at,
      string updated_by,
      string mode);



        DataSet sp_DepartmentUnit(int unit_id,
        string unit_description,
        string department,
        string updated_at,
        string updated_by,
        string created_at,
        string created_by,
        string mode);

        DataSet sp_user_rights(int user_rights_id, string user_rights_name, string mode);

        DataSet sp_user_rights_details(int user_rights_details_id,
            int user_rights_id,
            int menu_id,
            string updated_at,
            string updated_by,
            string Tagging_Relationship,
            string FirstName,
            string IDPerUser,
            string mode);





        DataSet sp_user_rights_details(int user_rights_details_id, string mode);

        //show accessible menu for selected user
        DataSet sp_getMenu_by_user(string eTablename, int user_id, int userRightsId, int menuId);
        DataSet sp_getMenu_by_user_Menu_Name(string eTablename, int user_id, int userRightsId, string menuName);




        DataSet sp_IDGenerator(int ID, 
            string mode, 
            string filter, 
            string search, 
            int selected,
            int FK_dry_wh_order);


        DataSet sp_IDGenerator_String(
            string ID, 
            string mode, 
            string filter, 
            string search,
            int selected,
            int FK_dry_wh_orders_parent_id);

        DataSet sp_company_info(int company_id, string company_name, string company_address_number, string company_street_1, string company_street_2, string company_city, string company_state, string company_postal_code, string company_country, string company_phone_number, string company_email_address, string company_website, int last_user_id, string mode);

        DataSet sp_emp_manager(int employee_id,
                         string employee_number,
                         string lastname,
                         string firstname,
                         string middlename,
                         string address,
                         string gender,
                         string contactno,
                         DateTime birthdate,
                         string sss_number,
                         string tin_number,
                         int civil_status_id,
                         int tax_id,
                         int department_id,
                         int section_id,
                         int position_id,
                         int employment_status_id,
                         DateTime date_hired,
                         DateTime date_regularization,
                         string PermanentAddress,
                         string philhealth_number,
                         string hdmf_number,
                         string hdmf_rtn,
                         string salary_rate,
                         string salary_structure,
                         int salary_type_id,
                         int workers_id,
                         string mode,
                         string InCaseOfEmergencyName,
                         string InCaseOfEmergencyNumber,
                           string Ros_hrd,
                           string remarks,
                         Byte[] image_employee
                         );
        DataSet sp_emp_manager(int employee_id, string employee_number, string mode);

        DataSet sp_emp_manager(int employee_id, DateTime date_resigned, string mode);

        DataSet sp_rdf_fg_feedcodetransaction(int fg_id, string prod_adv, string fg_feed_code, string fg_feed_type, string fg_options, string actual_weight, string printing_date, string proddate, string transaction_date, string transaction_type, string remarks, string added_by, string mode);


        DataSet rdf_sp_platenumber(int pnid, string to_vehicle, string platenumber, string added_by, string date_added, string inactive_by, string date_inactive, string activated_by, string date_activated, string edit_by, string date_edit, string mode);



    }
}
