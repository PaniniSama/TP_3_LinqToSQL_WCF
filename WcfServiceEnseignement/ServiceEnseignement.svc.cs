﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour
    //changer le nom de classe "ServiceEnseignement" à la fois dans le code, le fichier svc et
    //le fichier de configuration.
    public class ServiceEnseignement : IServiceEnseignement
    {
        DataClassesEnseignementDataContext l = new DataClassesEnseignementDataContext();
        public List<Eleves> getByCNE(string s)
        {
            return (from p in l.Eleves where p.CNE == s select p).ToList();
        }
    }
}