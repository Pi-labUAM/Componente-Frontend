using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendPaulo.Data
{
    public class Alert
    {
        public Boolean Visible { get; set; }
        public String Message { get; set; }
        public String Color { get; set; }

        public Alert() 
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Visible = false;
            this.Message = "";
            this.Color = "";
        }

        public Boolean isBad(String Message) 
        {
            this.Visible = true;
            this.Message = Message;
            this.Color = "danger";
            return false;
        }

        public Boolean isGood(String Message)
        {
            this.Visible = true;
            this.Message = Message;
            this.Color = "success";
            return true;
        }
    }
}