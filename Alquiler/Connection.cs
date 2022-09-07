using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    public class Connection
    {
        //Agregar base de datos firebase aqui.
        public IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };


        public IFirebaseClient client;
    }
}
