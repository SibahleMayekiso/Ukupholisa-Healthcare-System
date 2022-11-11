using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    internal interface ICondition
    {
        BindingSource GetMedicalConditons();
        void UpdateMedicalConditions();
    }
}
