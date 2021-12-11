using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Research
    {
        public string CreateDate { get; set; }
        public string Picture { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Objectives { get; set; }
        public string Results { get; set; }
        public string Bibliography { get; set; }
        public string State { get; set; }

        public Research() {
            this.Reset();
        }

        public void Reset()
        {
            this.CreateDate = "";
            this.Title = "";
            this.Abstract = "";
            this.Objectives = "";
            this.Results = "";
            this.Bibliography = "";
            this.State = "t";
            this.Picture = "default.jpg";
        }
    }
}