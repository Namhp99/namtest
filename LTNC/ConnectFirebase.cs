using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTNC
{
    public class ConnectFirebase
    {
        public ConnectFirebase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "EL7KmTYI0wcvAJQvFLnDo4GZBIwNXfomLt2zgdx6",
                BasePath = "https://htn-1-4c758-default-rtdb.firebaseio.com/"
            };
            client = new FirebaseClient(config);
        }
        public IFirebaseClient client;
    }
}