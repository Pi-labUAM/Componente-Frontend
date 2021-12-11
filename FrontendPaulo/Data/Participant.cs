using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Participant
    {
        public string Document { get; set; }
        public string Picture { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public Participant()
        {
            this.Reset();
        }

        public void Reset() 
        {
            this.Document = "";
            this.Fullname = "";
            this.Email = "";
            this.Picture = "default.jpg";
        }
    }
}