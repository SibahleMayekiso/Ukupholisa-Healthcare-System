using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    public interface Medical
    {
        void GetMedicalConditons();
        void GetMedicalTreatments();
        void UpdateMedicalConditions();
        void UpdateMedicalTreatments();
    }
}
