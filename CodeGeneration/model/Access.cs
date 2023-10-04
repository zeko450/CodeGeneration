using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.model
{
    internal class Access
    {
        //Attribut
        public string platform { get; set; }
        public string password { get; set; }
        public string key { get; set; }

        //Constructeur
        public Access()
        {

        }

        public Access(string platform, string password)
        {
            this.password = password;
            this.platform = platform;
        }

        public Access(string platform, string password, string key)
        {
            this.platform = platform;
            this.password = password;
            this.key = key;
        }



        //ToString
        public override string ToString()
        {
            return platform + "\n" + password.ToString();
        }
    }
}
