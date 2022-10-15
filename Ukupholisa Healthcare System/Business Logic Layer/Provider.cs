﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare_System.Business_Logic_Layer
{
    class Provider
    {
        private int providerID, chargeRate;
        private string name, email, rating;
        private bool provider_Status;
        private string agreement_With_Provider, type_of_Provider, type_of_Packages, criteria_for_PolicyHolders;

        public Provider(string name, string email, string rating, int providerID)
        {
            this.name = name;
            this.email = email;
            this.rating = rating;
            this.providerID = providerID;
        }

        public Provider(bool provider_Status, string agreement_With_Provider, string type_of_Provider, string type_of_Packages, string criteria_for_PolicyHolders, string name, string email, string rating, int chargeRate, int providerID)
        {
            this.provider_Status = provider_Status;
            this.agreement_With_Provider = agreement_With_Provider;
            this.type_of_Provider = type_of_Provider;
            this.type_of_Packages = type_of_Packages;
            this.criteria_for_PolicyHolders = criteria_for_PolicyHolders;
            this.name = name;
            this.email = email;
            this.rating = rating;
            this.chargeRate = chargeRate;
            this.providerID = providerID;
        }

        public bool Provider_Status { get => provider_Status; set => provider_Status = value; }
        public string Agreement_With_Provider { get => agreement_With_Provider; set => agreement_With_Provider = value; }
        public string Type_of_Provider { get => type_of_Provider; set => type_of_Provider = value; }
        public string Type_of_Packages { get => type_of_Packages; set => type_of_Packages = value; }
        public string Criteria_for_PolicyHolders { get => criteria_for_PolicyHolders; set => criteria_for_PolicyHolders = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Rating { get => rating; set => rating = value; }
        public int ChargeRate { get => chargeRate; set => chargeRate = value; }
        public int ProviderID { get => providerID; set => providerID = value; }
    }
}
