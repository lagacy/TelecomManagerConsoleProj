using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ServiTelecom.Utilitys.CredentialUtilitys;

namespace ServiTelecom
{
    /**
     * Base class for all the existing client in system.
     * 
     * 
     */

    public class Client
    {
       private Credential credential;
       private BillingInfo billingInfo;

        /*Service manager START -> Will have it's own class*/

        //TEMP
        public class Service
        { }

        Service[] ActiveService;
        Service[] ServiceOpportunity;

        /*Service manager END*/



        //Base Constructor
        private Client(Credential CCredential, BillingInfo CBillingInfo)
        {

        }

    }
}
