using DataFeed.Entities.Core;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataFeed.HotelImport.Entities.Target
{
    [Table("StageHotels", Schema = "dbo")]
    public class Hotel : BaseTargetEntity
    {
        [Key]
        [StringLength(18)]
        [Description("Record ID")]
        public string HotelId { get; set; }

        [Description("Deleted")]
        public bool? IsDeleted { get; set; }

        [StringLength(80)]
        [Description("Hotel Name")]
        public string Name { get; set; }

        [Description("Created Date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(18)]
        [Description("Created By ID")]
        public string CreatedById { get; set; }

        [Description("Last Modified Date")]
        public DateTime? LastModifiedDate { get; set; }

        [StringLength(18)]
        [Description("Last Modified By ID")]
        public string LastModifiedById { get; set; }

        [Description("System Modstamp")]
        public DateTime? SystemModstamp { get; set; }

        [Description("Last Activity Date")]
        public DateTime? LastActivityDate { get; set; }

        [StringLength(18)]
        [Description("Received Connection ID")]
        public string ConnectionReceivedId { get; set; }

        [StringLength(18)]
        [Description("Sent Connection ID")]
        public string ConnectionSentId { get; set; }

        [StringLength(18)]
        [Description("Supplier")]
        public string Supplier__c { get; set; }

        [StringLength(4099)]
        [Description("Additional Program Participation")]
        public string Additional_Program_Participation__c { get; set; }

        [StringLength(140)]
        [Description("Address 1")]
        public string Address_1__c { get; set; }

        [StringLength(140)]
        [Description("Address 2")]
        public string Address_2__c { get; set; }

        [StringLength(140)]
        [Description("Amadeus Chain Code")]
        public string Amadeus_Chain_Code__c { get; set; }

        [StringLength(140)]
        [Description("Amadeus Property Code")]
        public string Amadeus_Property_Code__c { get; set; }

        [StringLength(4099)]
        [Description("Amenities")]
        public string Amenities__c { get; set; }

        [StringLength(140)]
        [Description("Apollo/Galileo Chain Code")]
        public string Apollo_Galileo_Chain_Code__c { get; set; }

        [StringLength(140)]
        [Description("Apollo/Galileo Property Code")]
        public string Apollo_Galileo_Property_Code__c { get; set; }

        [StringLength(140)]
        [Description("Billing Address")]
        public string Billing_Address__c { get; set; }

        [StringLength(140)]
        [Description("Billing City")]
        public string Billing_City__c { get; set; }

        [StringLength(140)]
        [Description("Billing Country")]
        public string Billing_Country__c { get; set; }

        [StringLength(140)]
        [Description("Billing Postal Code")]
        public string Billing_Postal_Code__c { get; set; }

        [StringLength(140)]
        [Description("Billing State / Province")]
        public string Billing_State_Province__c { get; set; }

        [StringLength(140)]
        [Description("City")]
        public string City__c { get; set; }

        [StringLength(140)]
        [Description("Client Specific Property Contact")]
        public string Client_Specific_Property_Contact__c { get; set; }

        [StringLength(140)]
        [Description("Client Specific Property Title")]
        public string Client_Specific_Property_Title__c { get; set; }

        [StringLength(255)]
        [Description("Country")]
        public string Country__c { get; set; }

        [Description("Extended Stay/Residential Apartment")]
        public bool? Extended_Stay_Residential_Apartment__c { get; set; }

        [StringLength(255)]
        [Description("Hotel Market Tier")]
        public string Hotel_Market_Tier__c { get; set; }

        [StringLength(140)]
        [Description("Hotel Name")]
        public string Hotel_Name__c { get; set; }

        [StringLength(255)]
        [Description("Hotel Service")]
        public string Hotel_Service__c { get; set; }

        [StringLength(255)]
        [Description("Hotel Status")]
        public string Hotel_Status__c { get; set; }

        [StringLength(255)]
        [Description("Hotel Website")]
        public string Hotel_Website__c { get; set; }

        [Description("Latitude")]
        public decimal? Latitude__c { get; set; }

        [Description("Longitude")]
        public decimal? Longitude__c { get; set; }

        [StringLength(255)]
        [Description("Property Status")]
        public string Property_Status__c { get; set; }

        [Description("Property will offer additional amenity")]
        public bool? Property_will_offer_additional_amenity__c { get; set; }

        [StringLength(140)]
        [Description("Sabre Chain Code")]
        public string Sabre_Chain_Code__c { get; set; }

        [StringLength(140)]
        [Description("Sabre Property Code")]
        public string Sabre_Property_Code__c { get; set; }

        [Description("Select Accepted in Last Year's Program")]
        public bool? Select_Accepted_in_Last_Year_s_Program__c { get; set; }

        [StringLength(140)]
        [Description("Select After-Hours Contact Email")]
        public string Select_After_Hours_Contact_Email__c { get; set; }

        [StringLength(140)]
        [Description("Select After-Hours On-Site Contact")]
        public string Select_After_Hours_On_Site_Contact__c { get; set; }

        [StringLength(140)]
        [Description("Select After-Hours Phone Contact")]
        public string Select_After_Hours_Phone_Contact__c { get; set; }

        [Description("Select Agreed to Terms & Conditions")]
        public bool? Select_Agreed_to_Terms_Conditions__c { get; set; }

        [Description("Select Commission Invoice required")]
        public bool? Select_Commission_Invoice_required__c { get; set; }

        [StringLength(140)]
        [Description("Select Complimentary Breakfast")]
        public string Select_Complimentary_Breakfast__c { get; set; }

        [StringLength(255)]
        [Description("Select Complimentary Nights Offered")]
        public string Select_Complimentary_Nights_Offered__c { get; set; }

        [StringLength(100)]
        [Description("Select Email of person who completed bid")]
        public string Select_Email_of_person_who_completed_bid__c { get; set; }

        [StringLength(100)]
        [Description("Select Entertainment Sales Rep Email")]
        public string Select_Entertainment_Sales_Rep_Email__c { get; set; }

        [StringLength(140)]
        [Description("Select Entertainment Sales Rep")]
        public string Select_Entertainment_Sales_Rep__c { get; set; }

        [StringLength(100)]
        [Description("Select Group Sales Representative Email")]
        public string Select_Group_Sales_Representative_Email__c { get; set; }

        [StringLength(140)]
        [Description("Select Group Sales Representative")]
        public string Select_Group_Sales_Representative__c { get; set; }

        [StringLength(100)]
        [Description("Select Head Concierge email")]
        public string Select_Head_Concierge_email__c { get; set; }

        [StringLength(140)]
        [Description("Select Main Property Representative")]
        public string Select_Main_Property_Representative__c { get; set; }

        [StringLength(255)]
        [Description("Select Program Level")]
        public string Select_Program_Level__c { get; set; }

        [StringLength(100)]
        [Description("Select Property Representative Email")]
        public string Select_Property_Representative_Email__c { get; set; }

        [StringLength(140)]
        [Description("Select Property Representative Phone")]
        public string Select_Property_Representative_Phone__c { get; set; }

        [StringLength(140)]
        [Description("Select Property Representative Title")]
        public string Select_Property_Representative_Title__c { get; set; }

        [StringLength(255)]
        [Description("Select Type of Wi-Fi in Room")]
        public string Select_Type_of_Wi_Fi_in_Room__c { get; set; }

        [StringLength(140)]
        [Description("Select Special Amenity")]
        public string Select_special_amenity__c { get; set; }

        [StringLength(255)]
        [Description("State/Province Code")]
        public string State_Province_Code__c { get; set; }

        [StringLength(140)]
        [Description("Worldspan Chain Code")]
        public string Worldspan_Chain_Code__c { get; set; }

        [StringLength(140)]
        [Description("Worldspan Property Code")]
        public string Worldspan_Property_Code__c { get; set; }

        [Description("Accepted In Last Years Program")]
        public bool? Worldwide_Accepted_in_Last_Years_Program__c { get; set; }

        [Description("Worldwide Agreed to Terms & Conditions")]
        public bool? Worldwide_Agreed_to_Terms_Conditions__c { get; set; }

        [StringLength(100)]
        [Description("Worldwide Bid Email")]
        public string Worldwide_Bid_Email__c { get; set; }

        [StringLength(255)]
        [Description("Worldwide Block Space Allotment")]
        public string Worldwide_Block_Space_Allotment__c { get; set; }

        [StringLength(100)]
        [Description("Worldwide Block Space Email")]
        public string Worldwide_Block_Space_Email__c { get; set; }

        [StringLength(140)]
        [Description("Worldwide Contact for Block Space")]
        public string Worldwide_Contact_for_Block_Space__c { get; set; }

        [StringLength(100)]
        [Description("Entertainment Contact Email Address")]
        public string Worldwide_Entertainment_Sales_Rep_Email__c { get; set; }

        [StringLength(140)]
        [Description("Entertainment Contact")]
        public string Worldwide_Entertainment_Sales_Rep__c { get; set; }

        [StringLength(100)]
        [Description("Group Sales  Email Address")]
        public string Worldwide_Group_Sales_Rep_Email__c { get; set; }

        [StringLength(140)]
        [Description("Group Sales Contact")]
        public string Worldwide_Group_Sales_Rep__c { get; set; }

        [StringLength(140)]
        [Description("Billing City for Invoice")]
        public string Worldwide_Invoice_City__c { get; set; }

        [StringLength(40)]
        [Description("Worldwide Invoice Contact Phone")]
        public string Worldwide_Invoice_Contact_Phone__c { get; set; }

        [StringLength(140)]
        [Description("Billing Contact")]
        public string Worldwide_Invoice_Contact__c { get; set; }

        [StringLength(140)]
        [Description("Billing Country for Invoice")]
        public string Worldwide_Invoice_Country__c { get; set; }

        [StringLength(100)]
        [Description("Billing Email")]
        public string Worldwide_Invoice_Email__c { get; set; }

        [StringLength(140)]
        [Description("Billing Postal Code")]
        public string Worldwide_Invoice_Postal_Code__c { get; set; }

        [StringLength(140)]
        [Description("Billing State/Province for Invoice")]
        public string Worldwide_Invoice_State_Province__c { get; set; }

        [StringLength(140)]
        [Description("Address for Invoice")]
        public string Worldwide_Invoice_Street_Address__c { get; set; }

        [StringLength(140)]
        [Description("Person Who Submitted Bid")]
        public string Worldwide_Name_of_person_submitting_bid__c { get; set; }

        [StringLength(255)]
        [Description("Worldwide Program Level")]
        public string Worldwide_Program_Level__c { get; set; }

        [StringLength(100)]
        [Description("Worldwide Program Contact Email Address")]
        public string Worldwide_Property_Rep_Email__c { get; set; }

        [StringLength(140)]
        [Description("Worldwide Program Contact Title")]
        public string Worldwide_Property_Representative_Title__c { get; set; }

        [StringLength(140)]
        [Description("Worldwide Program Contact")]
        public string Worldwide_Property_Representative__c { get; set; }

        [Description("Worldwide Requires Commission Invoice")]
        public bool? Worldwide_Requires_Commission_Invoice__c { get; set; }

        [StringLength(140)]
        [Description("Worldwide Special Amenity")]
        public string Worldwide_Special_Amenity__c { get; set; }

        [Description("Worldwide Will offer Special Amenity")]
        public bool? Worldwide_Will_offer_Special_Amenity__c { get; set; }

        [Description("Year Property Built")]
        public decimal? Year_Property_Built__c { get; set; }

        [Description("Year of Last Guest Room Renovation")]
        public decimal? Year_of_Last_Guest_Room_Renova__c { get; set; }

        [Description("Property Code")]
        public decimal? Property_Code__c { get; set; }

        [StringLength(1300)]
        [Description("Property Code")]
        public string Property_Code_formula_field__c { get; set; }

        [StringLength(140)]
        [Description("Postal Code")]
        public string Postal_Code__c { get; set; }

        [StringLength(32768)]
        [Description("Select Property Full Description")]
        public string Select_Property_Full_Description__c { get; set; }

        [Description("Enhanced Commission Property")]
        public bool? Enhanced_Commission_Property__c { get; set; }

        [Description("Select Program Website Listing Published")]
        public bool? Select_Program_Website_Listing_Publishe__c { get; set; }

        [StringLength(18)]
        [Description("Star Rating")]
        public string Star_Rating_2__c { get; set; }

        [StringLength(32768)]
        [Description("Airport City Metro Code")]
        public string Airport_City_Metro_Code__c { get; set; }

        [Description("Blackout End Date 10")]
        public DateTime? Blackout_End_Date_10__c { get; set; }

        [Description("Blackout End Date 1")]
        public DateTime? Blackout_End_Date_1__c { get; set; }

        [Description("Blackout End Date 2")]
        public DateTime? Blackout_End_Date_2__c { get; set; }

        [Description("Blackout End Date 3")]
        public DateTime? Blackout_End_Date_3__c { get; set; }

        [Description("Blackout End Date 4")]
        public DateTime? Blackout_End_Date_4__c { get; set; }

        [Description("Blackout End Date 5")]
        public DateTime? Blackout_End_Date_5__c { get; set; }

        [Description("Blackout End Date 6")]
        public DateTime? Blackout_End_Date_6__c { get; set; }

        [Description("Blackout End Date 7")]
        public DateTime? Blackout_End_Date_7__c { get; set; }

        [Description("Blackout End Date 8")]
        public DateTime? Blackout_End_Date_8__c { get; set; }

        [Description("Blackout End Date 9")]
        public DateTime? Blackout_End_Date_9__c { get; set; }

        [Description("Blackout Start Date 10")]
        public DateTime? Blackout_Start_Date_10__c { get; set; }

        [Description("Blackout Start Date 1")]
        public DateTime? Blackout_Start_Date_1__c { get; set; }

        [Description("Blackout Start Date 2")]
        public DateTime? Blackout_Start_Date_2__c { get; set; }

        [Description("Blackout Start Date 3")]
        public DateTime? Blackout_Start_Date_3__c { get; set; }

        [Description("Blackout Start Date 4")]
        public DateTime? Blackout_Start_Date_4__c { get; set; }

        [Description("Blackout Start Date 5")]
        public DateTime? Blackout_Start_Date_5__c { get; set; }

        [Description("Blackout Start Date 6")]
        public DateTime? Blackout_Start_Date_6__c { get; set; }

        [Description("Blackout Start Date 7")]
        public DateTime? Blackout_Start_Date_7__c { get; set; }

        [Description("Blackout Start Date 8")]
        public DateTime? Blackout_Start_Date_8__c { get; set; }

        [Description("Blackout Start Date 9")]
        public DateTime? Blackout_Start_Date_9__c { get; set; }

        [StringLength(255)]
        [Description("City Tax Percent or Fixed")]
        public string City_Tax_Percent_or_Fixed__c { get; set; }

        [Description("City Tax")]
        public decimal? City_Tax__c { get; set; }

        [Description("City Tax in Negotiated Rate")]
        public bool? City_Tax_in_Negotiated_Rate__c { get; set; }

        [Description("Credit Cards Accepted American Express")]
        public bool? Credit_Cards_Accepted_American_Express__c { get; set; }

        [Description("Credit Cards Accepted Diners Club")]
        public bool? Credit_Cards_Accepted_Diners_Club__c { get; set; }

        [Description("Credit Cards Accepted Discover")]
        public bool? Credit_Cards_Accepted_Discover__c { get; set; }

        [Description("Credit Cards Accepted JCB")]
        public bool? Credit_Cards_Accepted_JCB__c { get; set; }

        [Description("Credit Cards Accepted Mastercard")]
        public bool? Credit_Cards_Accepted_Mastercard__c { get; set; }

        [Description("Credit Cards Accepted Visa")]
        public bool? Credit_Cards_Accepted_Visa__c { get; set; }

        [Description("Facilities Handicapped Friendly")]
        public bool? Facilities_Handicapped_Friendly__c { get; set; }

        [StringLength(3)]
        [Description("IMF Currency Code")]
        public string IMF_Currency_Code__c { get; set; }

        [Description("Lodging Tax In Negotiated Rate")]
        public bool? Lodging_Tax_In_Negotiated_Rate__c { get; set; }

        [StringLength(255)]
        [Description("Lodging Tax Percent or Fixed")]
        public string Lodging_Tax_Percent_or_Fixed__c { get; set; }

        [Description("Lodging Tax")]
        public decimal? Lodging_Tax__c { get; set; }

        [StringLength(32768)]
        [Description("Nearest Airport Code")]
        public string Nearest_Airport_Code__c { get; set; }

        [StringLength(255)]
        [Description("Occupancy Tax Percent or Fixed")]
        public string Occupancy_Tax_Percent_or_Fixed__c { get; set; }

        [Description("Occupancy Tax")]
        public decimal? Occupancy_Tax__c { get; set; }

        [Description("Occupancy Tax in Negotiated Rate")]
        public bool? Occupancy_Tax_in_Negotiated_Rate__c { get; set; }

        [Description("Phone Area Code")]
        public decimal? Phone_Area_Code__c { get; set; }

        [Description("Phone Country Code")]
        public decimal? Phone_Country_Code__c { get; set; }

        [Description("Phone Number")]
        public decimal? Phone_Number__c { get; set; }

        [StringLength(32768)]
        [Description("Property Description")]
        public string Property_Description__c { get; set; }

        [Description("Select Airport Transportation In Rate")]
        public bool? Select_Airport_Transportation_In_Rate__c { get; set; }

        [Description("Select Average Airport Transportation Co")]
        public decimal? Select_Average_Airport_Transportation_Co__c { get; set; }

        [Description("Select Calling Card In Rate")]
        public bool? Select_Calling_Card_In_Rate__c { get; set; }

        [StringLength(200)]
        [Description("Select Describe Airport Transportation")]
        public string Select_Describe_Airport_Transportation__c { get; set; }

        [StringLength(40)]
        [Description("Select Featured Image")]
        public string Select_Featured_Image__c { get; set; }

        [StringLength(255)]
        [Description("Brand")]
        public string Brand__c { get; set; }

        [StringLength(18)]
        [Description("Select Hotel Region")]
        public string Select_Hotel_Region__c { get; set; }

        [StringLength(4099)]
        [Description("Select Hotel Tag")]
        public string Select_Hotel_Tag__c { get; set; }

        [Description("Select Internet Access Fee")]
        public decimal? Select_Internet_Access_Fee__c { get; set; }

        [Description("Select Internet Access In Negotiated Rat")]
        public bool? Select_Internet_Access_In_Negotiated_Rat__c { get; set; }

        [StringLength(32768)]
        [Description("Select Late Arrival Cancellation Policy")]
        public string Select_Late_Arrival_Cancellation_Policy__c { get; set; }

        [Description("Select Rate Commissionable Percent")]
        public decimal? Select_Negotiated_Rates_Commissionable_P__c { get; set; }

        [Description("Select Negotiated Rates Commissionable")]
        public bool? Select_Negotiated_Rates_Commissionable__c { get; set; }

        [Description("Select On Site Fitness Center Cost")]
        public decimal? Select_On_Site_Fitness_Center_Cost__c { get; set; }

        [Description("Select On Site Fitness Center")]
        public bool? Select_On_Site_Fitness_Center__c { get; set; }

        [Description("Select Oversold Acc Free Phone")]
        public bool? Select_Oversold_Acc_Free_Phone__c { get; set; }

        [Description("Select Oversold Acc Free Transport")]
        public bool? Select_Oversold_Acc_Free_Transport__c { get; set; }

        [Description("Select Oversold Accommodations Will Pay")]
        public bool? Select_Oversold_Accommodations_Will_Pay__c { get; set; }

        [Description("Select Oversold Accommodations")]
        public bool? Select_Oversold_Accommodations__c { get; set; }

        [StringLength(10)]
        [Description("Select Parking Cost")]
        public string Select_Parking_Cost__c { get; set; }

        [Description("Select Parking In Negotiated Rate")]
        public bool? Select_Parking_In_Negotiated_Rate__c { get; set; }

        [StringLength(32768)]
        [Description("Select Parking Info")]
        public string Select_Parking_Info__c { get; set; }

        [StringLength(100)]
        [Description("Select Program Commission Rate")]
        public string Select_Program_Commission_Rate__c { get; set; }

        [StringLength(100)]
        [Description("Select Program Contact Email")]
        public string Select_Program_Contact_Email__c { get; set; }

        [StringLength(50)]
        [Description("Select Program Contact Title")]
        public string Select_Program_Contact_Title__c { get; set; }

        [StringLength(100)]
        [Description("Select Program Contact")]
        public string Select_Program_Contact__c { get; set; }

        [Description("Select Program Website Listing")]
        public bool? Select_Program_Website_Listing__c { get; set; }

        [Description("Select Rates Negotiable")]
        public bool? Select_Rates_Negotiable__c { get; set; }

        [Description("Service Fee In Negotiated Rate")]
        public bool? Service_Fee_In_Negotiated_Rate__c { get; set; }

        [StringLength(255)]
        [Description("Service Fee Percent or Fixed")]
        public string Service_Fee_Percent_or_Fixed__c { get; set; }

        [Description("Service Fee")]
        public decimal? Service_Fee__c { get; set; }

        [Description("State Tax In Negotiated Rate")]
        public bool? State_Tax_In_Negotiated_Rate__c { get; set; }

        [StringLength(255)]
        [Description("State Tax Percent or Fixed")]
        public string State_Tax_Percent_or_Fixed__c { get; set; }

        [Description("State Tax")]
        public decimal? State_Tax__c { get; set; }

        [Description("Total Number Floors")]
        public decimal? Total_Number_Floors__c { get; set; }

        [Description("Total Number Rooms Suites")]
        public decimal? Total_Number_Rooms_Suites__c { get; set; }

        [Description("VAT GST Food Bev In Negotiated Rate")]
        public bool? VAT_GST_Food_Bev_In_Negotiated_Rate__c { get; set; }

        [StringLength(255)]
        [Description("VAT GST Food Bev Percent or Fixed")]
        public string VAT_GST_Food_Bev_Percent_or_Fixed__c { get; set; }

        [Description("VAT GST Food Beverage")]
        public decimal? VAT_GST_Food_Beverage__c { get; set; }

        [Description("VAT GST In Negotiated Rate")]
        public bool? VAT_GST_In_Negotiated_Rate__c { get; set; }

        [StringLength(255)]
        [Description("VAT GST Percent or Fixed")]
        public string VAT_GST_Percent_or_Fixed__c { get; set; }

        [Description("VAT GST")]
        public decimal? VAT_GST__c { get; set; }

        [StringLength(80)]
        [Description("Email Address of Person Submitting Bid")]
        public string Email_Address_of_Person_Submitting_Bid__c { get; set; }

        [StringLength(255)]
        [Description("Worldwide Level of Participation")]
        public string Worldwide_Level_of_Participation__c { get; set; }

        [StringLength(255)]
        [Description("After hours contact title")]
        public string After_hours_contact_title__c { get; set; }

        [Description("All inclusive option")]
        public bool? All_inclusive_option__c { get; set; }

        [Description("Babysitting services")]
        public bool? Babysitting_services__c { get; set; }

        [StringLength(255)]
        [Description("Chain Code Master Chain")]
        public string Chain_Code_Master_Chain__c { get; set; }

        [Description("Check-in Time")]
        public string Check_in_Time__c { get; set; }

        [Description("Check-out Time")]
        public string Check_out_Time__c { get; set; }

        [Description("Eco Friendly")]
        public bool? Eco_Friendly__c { get; set; }

        [Description("In-room dining")]
        public bool? In_room_dining__c { get; set; }

        [Description("Meeting space")]
        public bool? Meeting_space__c { get; set; }

        [Description("Parking Valet")]
        public bool? Parking_Valet__c { get; set; }

        [StringLength(80)]
        [Description("Reservations Manager contact email")]
        public string Reservations_Manager_contact_email__c { get; set; }

        [StringLength(25)]
        [Description("Reservations Manager contact name")]
        public string Reservations_Manager_contact_name__c { get; set; }

        [StringLength(40)]
        [Description("Reservations Manager contact phone")]
        public string Reservations_Manager_contact_phone__c { get; set; }

        [StringLength(25)]
        [Description("Reservations Manager contact title")]
        public string Reservations_Manager_contact_title__c { get; set; }

        [StringLength(255)]
        [Description("Resort fee")]
        public string Resort_fee__c { get; set; }

        [Description("Restaurant on property")]
        public bool? Restaurant_on_property__c { get; set; }

        [Description("Open Year-Round")]
        public bool? Open_Year_Round__c { get; set; }

        [Description("Smoking Rooms Available")]
        public bool? Smoking_Rooms_Available__c { get; set; }

        [Description("Handicapped Accessible Rooms")]
        public bool? Handicapped_Accessible_Rooms__c { get; set; }

        [StringLength(255)]
        [Description("Taxes")]
        public string Taxes__c { get; set; }

        [Description("Salon On Property")]
        public bool? Salon_On_Property__c { get; set; }

        [Description("Connecting rooms")]
        public decimal? Connecting_rooms__c { get; set; }

        [StringLength(255)]
        [Description("Select Upgrade Availability or Confirmed")]
        public string Select_Upgrade_Availability_or_Confirmed__c { get; set; }

        [StringLength(255)]
        [Description("Select Early Check In/Late Check Out")]
        public string Select_Early_Check_In_Late_Check_Out__c { get; set; }
    }
}
