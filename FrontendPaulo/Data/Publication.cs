using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Publication
    {
        public DateTime AuxDate { get; set; }
        public string CreateDate { get; set; }
        public string PublicationDate { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public Publication() 
        {
            this.Reset();
        }

        public void Reset() 
        {
            this.AuxDate = DateTime.Now;
            this.CreateDate = "";
            this.PublicationDate = "";
            this.Title = "";
            this.Link = "";
        }
    }
}