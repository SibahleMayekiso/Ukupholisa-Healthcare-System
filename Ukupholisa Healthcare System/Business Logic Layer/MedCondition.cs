using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa_Healthcare_System.Data_Access_Layer;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class MedCondition: ICondition  
    {
        string conditionID, conditionName, severity;

        public MedCondition()
        {

        }
        public MedCondition(string conditionID, string conditionName, string severity)
        {
            this.conditionID = conditionID;
            this.conditionName = conditionName;
            this.severity = severity;
        }

        public string ConditionID { get => conditionID; set => conditionID = value; }
        public string ConditionName { get => conditionName; set => conditionName = value; }
        public string Severity { get => severity; set => severity = value; }

        //Read
        #region Read methods
        public BindingSource GetConditionsWithTreatment()
        {
            MedicalData medicalData = new MedicalData();
            BindingSource source = new BindingSource();
            source.DataSource = medicalData.ReadAllConditionTreatments();
            return source;
        }
        public BindingSource GetMedicalConditons()
        {
            MedicalData medicalData = new MedicalData();
            BindingSource source = new BindingSource();
            source.DataSource = medicalData.ReadAllMedicalConditions();
            return source;
        }
        #endregion

        //Update
        #region Update methods
        public void UpdateMedicalConditions()
        {

        }
        #endregion
    }
}
