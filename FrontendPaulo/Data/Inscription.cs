using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Inscription
    {
        public string Research { get; set; }
        public string Participant { get; set; }
        public string CreateDate { get; set; }

        public Inscription() 
        {
            this.Reset();
        }

        public void Reset() 
        {
            this.Research = "";
            this.Participant = "";
            this.CreateDate = "";
        }
    }
}
