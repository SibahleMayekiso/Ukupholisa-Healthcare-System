using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Hospital
    {
        private int hospitalID, regionID;
        private string hospitalName, street, suburb, city, region;
        private string medical_condition, type_of_Treatment, insurance_Provider_for_Client;
        private int price_Of_Treatment, amount_Due;

        public Hospital(int hospitalID, string street, string suburb, string city, string region, string medical_condition, string type_of_Treatment, string insurance_Provider_for_Client, int price_Of_Treatment, int amount_Due, string hospitalName, int regionID)
        {
            this.hospitalID = hospitalID;
            this.street = street;
            this.suburb = suburb;
            this.city = city;
            this.region = region;
            this.medical_condition = medical_condition;
            this.type_of_Treatment = type_of_Treatment;
            this.insurance_Provider_for_Client = insurance_Provider_for_Client;
            this.price_Of_Treatment = price_Of_Treatment;
            this.amount_Due = amount_Due;
            this.hospitalName = hospitalName;
            this.regionID = regionID;
        }

        public int HospitalID { get => hospitalID; set => hospitalID = value; }
        public string Street { get => street; set => street = value; }
        public string Suburb { get => suburb; set => suburb = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public string Medical_condition { get => medical_condition; set => medical_condition = value; }
        public string Type_of_Treatment { get => type_of_Treatment; set => type_of_Treatment = value; }
        public string Insurance_Provider_for_Client { get => insurance_Provider_for_Client; set => insurance_Provider_for_Client = value; }
        public int Price_Of_Treatment { get => price_Of_Treatment; set => price_Of_Treatment = value; }
        public int Amount_Due { get => amount_Due; set => amount_Due = value; }
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
        public int RegionID { get => regionID; set => regionID = value; }


        public string AddMedicalConditionValidation(string name, string severity, int MedicalconditionID)
        {
            if (name == null | severity == null | String.IsNullOrEmpty(MedicalconditionID.ToString()))
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("Added Succesfully");
            }


        }

        public string AddTreatmentValidation(string name, string duration, int TreatmentID)
        {
            if (name == null | duration == null | String.IsNullOrEmpty(TreatmentID.ToString()))
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("Added Succesfully");
            }


        }

        public string UpdateMedicalConditionValidation(string name, string severity, int MedicalconditionID)
        {
            if (name == null | severity == null | String.IsNullOrEmpty(MedicalconditionID.ToString()))
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("updated Succesfully");
            }



        }

        public string UpdateTreatmentValidation(string name, string duration, int TreatmentID)
        {
            if (name == null | duration == null | String.IsNullOrEmpty(TreatmentID.ToString()))
            {
                return ("Please Fill in all Fields");
            }
            else
            {
                return ("updated Succesfully");
            }


        }
    }
}
