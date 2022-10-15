using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Dependent: Client
    {
        private int dependentID;
        private string relationToClient;
        private int coveragePercentage;

        public Dependent(int dependentID, string relationToClient, int coveragePercentage, string name, string surname, int age) : base(name,surname,age)
        {
            this.dependentID = dependentID;
            this.relationToClient = relationToClient;
            this.coveragePercentage = coveragePercentage;
        }
        
        /*
         * //This method cannot be used since both parent and child classes contain their respective constructors( constructors of both classes must be executed)
        public Dependent(int dependentID, string relationToClient, int coveragePercentage, string name, string surname, int age)
        {
            this.dependentID = dependentID;
            FirstName = name;
            Lastname = surname;
            Age = age;
            this.relationToClient = relationToClient;
            this.coveragePercentage = coveragePercentage;
        }
        */

        public int DependentID { get => dependentID; set => dependentID = value; }
        public string RelationToClient { get => relationToClient; set => relationToClient = value; }
        public int CoveragePercentage { get => coveragePercentage; set => coveragePercentage = value; }
    }
}
