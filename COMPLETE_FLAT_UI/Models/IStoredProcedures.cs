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
        DataSet sp_getMinorTables(string eTableName, int? pkId);
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

        DataSet rdf_sp_warehouse(int wh_id, string warehouse, string account_title, string addded_by, string date_added, string mode);

        DataSet rdf_sp_customer(int customer_id, string name, string type, string company, string mobile, string lead_man, string address, string added_by, string date_added, string mode);


        DataSet rdf_sp_bulk_data(int id, string qty, string remarks, string date_added, string added_by, string is_active, string mode);



        DataSet rdf_sp_new_micro(int item_id, int item_category, string item_code, int supplier, string item_description, string classification, string quantity, string date_added, string expiration_details, string item_location, string delivery_details, string item_added_by, string per_bag, string item_group, string Category, string buffer_of_stocks, string price, string classification_buffer, string ordering_buffer, string mode);

        DataSet rdf_sp_new_micro_received(int received_id, string r_item_id, string r_item_category, string r_item_code, string r_supplier, string r_item_description, string r_classification, string r_quantity, string r_receiving_date, string r_receiving_details, string added_by, string days_to_expired, string uniquedate, string totalnstock, string actual_count_good, string actual_count_reject, string oracle_qty_uom, string tracking_po_sum_id, string selected_uom, string r_qty_delivered, string r_mfg_date, string r_expiry_date, string r_qty_ordered, string r_QA_by, string r_expected, string r_missing, string r_actual_receiving, string QA_rgood, string QA_reject, string r_receiving_by, string r_total_delivered, string r_waiting_delivered, string r_primary_key, string receiving_status, string repack_balance, string qty_good, string qty_void, string qty_remarks, string r_qty_production, string Reason, string transaction_type, string mode);


        DataSet rdf_sp_new_preparation(int prepa_id, string pre_prod_id, string pre_feed_code, string pre_feed_type, string pre_item_code, string pre_description, string pre_batch, string pre_qty_batch, string pre_sum_total, string rep_item_code, string rep_qty, string rep_id, string rep_received_id, string rep_qa_id, string rep_is_active, string rep_date_added, string rep_added_by, string preparation_date_finish, string mode);


        DataSet rdf_sp_new_production(int product_id, string product_feed_code, string product_feed_type, string prod_id, string product_batch, string remaining_batch, string product_theo1, string product_theo2, string product_theo3, string product_theo4, string product_theo5, string product_theo6, string product_theo7, string product_theo8, string product_theo9, string product_theo10, string product_macro1, string product_macro2, string product_macro3, string product_macro4, string product_macro5, string product_macro6, string product_macro7, string product_macro8, string product_macro9, string product_macro10, string bmx_id, string bmx_qty_batch, string bmx_actual_batch, string bmx_mixing_date, string product_date, string product_added_by, string product_macro11, string product_macro12, string product_macro13, string product_macro14, string product_macro15, string mode);

        DataSet rdf_sp_new_basemixed(int bmx_id, string bmx_prod_date, string bmx_feed_code, string bmx_feed_type, string bmx_bags, string bmx_prepa_date, string bmx_batch, string bmx_rows, string bmx_qty_batch, string bmx_qty_sum_total, string bmx_actual_running_count, string bmx_actual_variance, string bmx_date_of_mixing, string bmx_actual_weight1, string bmx_actual_weight2, string bmx_actual_weight3, string bmx_actual_weight4, string bmx_actual_weight5, string bmx_actual_weight6, string bmx_actual_weight7, string bmx_actual_weight8, string bmx_actual_weight9, string bmx_actual_weight10, string bmx_actual_weight11, string bmx_actual_weight12, string bmx_actual_weight13, string bmx_actual_weight14, string bmx_actual_weight15, string bmx_actual_weight16, string bmx_actual_weight17, string bmx_actual_weight18, string bmx_actual_weight19, string bmx_actual_weight20, string bmx_actual_weight21, string bmx_actual_weight22, string bmx_actual_weight23, string bmx_actual_weight24, string bmx_actual_weight25, string bmx_actual_weight26, string bmx_actual_weight27, string bmx_actual_weight28, string bmx_actual_weight29, string bmx_actual_weight30, string bmx_actual_weight31, string bmx_actual_weight32, string bmx_actual_weight33, string bmx_actual_weight34, string bmx_actual_weight35, string bmx_actual_weight36, string bmx_actual_weight37, string bmx_actual_weight38, string bmx_actual_weight39, string bmx_actual_weight40, string bmx_actual_weight41, string bmx_actual_weight42, string bmx_actual_weight43, string bmx_actual_weight44, string bmx_actual_weight45, string bmx_actual_weight46, string bmx_actual_weight47, string bmx_actual_weight48, string bmx_actual_weight49, string bmx_actual_weight50, string variance_percentage, string mode);


        DataSet rdf_sp_new_micro_repacking(int repack_id, string rp_item_id, string rp_item_category, string rp_item_code, string rp_supplier, string rp_item_description, string rp_classification, string rp_quantity, string rp_receiving_date, string rp_receiving_details, string added_by, string days_to_expired, string uniquedate, string totalnstock, string actual_count_good, string actual_count_reject, string oracle_qty_uom, string tracking_po_sum_id, string selected_uom, string rp_qty_delivered, string rp_mfg_date, string rp_expiry_date, string rp_qty_ordered, string rp_QA_by, string rp_expected, string rp_missing, string rp_actual_receiving, string QA_rgood, string QA_reject, string rp_receiving_by, string rp_total_delivered, string rp_waiting_delivered, string total_repack, string repack_by, string raw_rp_available, string rp_balance, string rp_qtyneeded, string rp_qtyshared, string rp_posumid, string raw_rp_remaining, string rp_batch, string rp_feed_code, string deb_vendor_name, string deb_received_id, string deb_item_code, string deb_dof_received, string deb_xpdays, string deb_total_qty, string deb_total_shared, string deb_actual_remaining, string string_id, string macrocount, string prod_id_repack, string production_date, string repacking_date_time, string mode);


        DataSet rdf_sp_new_micro_bmx(int bmx_id, string prod_adv, string bmx_feed_code, string bmx_feed_type, string bmx_bags, string bmx_batch, string bmx_proddate, string bmx_qty_batch, string bmx_qty_kilos, string bmx_rows, string bmx_batch_print, string is_active, string added_by, string actual_weight, string bmx_id_string, string mode);



        DataSet rdf_sp_new_finish_goods(int fg_id, string prod_adv, string fg_feed_code, string fg_feed_type, string fg_bags, string fg_batch, string fg_proddate, string fg_micro_prepa, string fg_macro_prepa, string fg_micro_bmx, string fg_finish_production, string is_active, string added_by, string actual_weight, string bmx_id_string, string fg_actual_print_count, string fg_batchprint_primary, string fg_prod_batchcount, string fg_outofprod_bags, string fg_options, string status, string printing_date, string combi_code, string mode);

        DataSet rdf_sp_new_FG(int fg_primary_key, string fg_prod_id, string fg_feed_code, string fg_date_prod, string fg_bags, string fg_batchno, string fg_feedtype, string fg_micro_preparation_date, string fg_macro_preparation_date, string fg_micro_basemixed_date, string fg_finish_production_date, string fg_batchprint_primary, string fg_actual_print_count, string fg_prod_batchcount, string fg_outofprod_bags, string fg_options, string fg_qty_bulk_entry, string fg_date_added, string fg_added_by, int variance_bags, int bulkentry_total, int bags_total, string variance_percentage, string days_to_production, string mode);




        //    DataSet rdf_sp_new_micro_updated(int received_id, string r_item_id, string r_item_category, string r_item_code, string r_supplier, string r_item_description, string r_classification, string r_quantity, string r_receiving_date, string r_receiving_details, string added_by, string days_to_expired,string exp1, string mode);
        DataSet rdf_sp_classification(int classification_id, string classification_name, string mode);
        DataSet sp_sickness(int sickness_id, string sickness_name, string mode);

        DataSet sp_section(int section_id, int department_id, string section_name, string mode);

        DataSet rdf_sp_feed_code(int feed_id, int prod_type, string feed_code, string feed_type, string sack_color, string mode);

        DataSet rdf_sp_TimeKeeper(int id, string date, string time, string exp1, string mode);

        DataSet rdf_sp_myrecipe(int recipe_id, int feed_type, int category_id, string item_code, int description, int group_id, string quantity, string last_modified, string feed_code, string rp_type, string rp_feed_type, string rp_description, string rp_category, string rp_group, string mode);
        //DataSet rdf_sp_myrecipe(int recipe_id, int feed_type, int category_id, string item_code, int description, int group_id, string quantity, string last_modified, string mode);


        DataSet rdf_sp_group(int group_id, int group_category, string group_name, string date_added, string added_by, string mode);


        DataSet sp_positions(int position_id, int section_id, string position_name, string mode);

        DataSet sp_types_of_leave(int leave_id, string leave_name, string mode);

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

        DataSet sp_attendance_monitoring(int attendance_monitoring_id, int employee_id, string mode);

        DataSet sp_tardiness(int tardiness_id, int employee_id, string time_late, string mode);

        DataSet sp_userfile(int userfile_id, int user_rights_id, string username, string password, string employee_name, string user_section, string receiving_status, string mode);
        DataSet sp_userfile(int userfile_id, string username, string password, string user_section, string mode);

        DataSet sp_disciplinary(int da_id,
                    string da_number,
                    int employee_id,
                    int offense_id,
                    string violation_incured,
                    string date_of_incident,
                    string number_of_offense,
                    string penalty_impose,
                    string remarks,
                    string resolution_memo,
                    string suspension_date,
                    string incident_details,
                    DateTime date_created,
                    string mode,
                    DateTime? dateInitialMemo,
                    DateTime? dateInitialMemoPrepared,
                    DateTime? dateResolutionMemo,
                    DateTime? dateResolutionMemoPrepared,
                    bool? is_explanation);

        DataSet sp_disciplinary(int da_id, string da_number, string mode);
        DataSet sp_disciplinary(DateTime date_created, string mode);

        DataSet sp_offense(int offense_id, string offense_code, string offense_description, string mode);

        DataSet sp_DTRecords1(int ID, DateTime attendance_date, string mode);
        DataSet sp_DTRecords1(int ID, string employee_id, string mode);
        DataSet sp_DTRecords1(int ID, DateTime attendance_date, string employee_id, string TimeIn, string LunchOut, string LunchIn, string TimeOut, string TotalHrs, string mode);

        DataSet sp_phonebook(int phonebook_id, string company_name, string contact_name, string address, string phonenumber1, string phonenumber2, string cellno1, string cellno2, string faxnumber, string emailaddress, string mode);
        DataSet sp_phonebook(int phonebook_id, string company_name, string contact_name, string mode);
        DataSet sp_SchedShift(string mode, int ID, string SName, string STimeIn, string SLunchOut, string SLunchIn, string STimeOut, int is_active);

        DataSet sp_Sched(string mode, string column, string filter, int ID, string SName, string SDate, string STimeIn, string SLunchOut, string SLunchIn, string STimeOut);

        DataSet sp_Sched2(string mode, int ID, string Employee_ID, string Shift_Name, string Date, string Date2);
        DataSet sp_tard(string mode, string filter, string Employee_ID, string Date, string Date2);

        DataSet sp_available_menu(int menu_id, string menu_name, string menu_form_name, string menu_count, string mode);

        DataSet sp_user_rights(int user_rights_id, string user_rights_name, string mode);

        DataSet sp_user_rights_details(int user_rights_details_id, int user_rights_id, int menu_id, string mode);
        DataSet sp_user_rights_details(int user_rights_details_id, string mode);

        //show accessible menu for selected user
        DataSet sp_getMenu_by_user(string eTablename, int user_id, int userRightsId, int menuId);

        DataSet sp_visitors(int visitors_id, string visitors_lastname, string visitors_firstname, DateTime date_visit, string time_in, string time_out, string contact_number, string company, string person_visited, string purpose, string mode);



        DataSet sp_LoanHistory(string ID, string mode, string filter, string search, string Loan_ID, string date_paid, decimal amount_paid, decimal remaining_balance);

        DataSet sp_Loan(string ID, string mode, string filter, string search, string Employee_ID,
            string Loan_from,
            string Loan_Type,
            string Loan_Granted,
            string Amortization,
            string Payment_Terms,
            string Start_Payment,
            string End_Payment,
            string Payroll_list,
            string Payroll_Payments,
            string Payroll_Amount, int active);


        DataSet sp_IDGenerator(int ID, string mode, string filter, string search, int selected);

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
