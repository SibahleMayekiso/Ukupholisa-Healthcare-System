using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Treatment: ITreatment
    {
        string treatmentID, treatmentName;
        int duration;

        public Treatment()
        {

        }
        public Treatment(string treatmentID, string treatmentName, int duration)
        {
            this.treatmentID = treatmentID;
            this.treatmentName = treatmentName;
            this.duration = duration;
        }

        public string TreatmentID { get => treatmentID; set => treatmentID = value; }
        public string TreatmentName { get => treatmentName; set => treatmentName = value; }
        public int Duration { get => duration; set => duration = value; }

        public BindingSource GetMedicalTreatments()
        {
            MedicalData medicalData = new MedicalData();
            BindingSource source = new BindingSource();
            source.DataSource = medicalData.ReadAllMedicalTreatments();
            return source;
        }

        public void UpdateMedicalTreatmentsDetails()
        {

        }
        public string InsertTreatmentDetails(Treatment treatment)
        {
            MedicalData medical = new MedicalData();
            return medical.InsertTreatmentData(treatment);
        }
    }
}
