using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using Newtonsoft.Json;
namespace WebIntVM.Models
{
    public class CreateNewModel
    {
        public bool FirstSoft { get; set; }
        public bool SecondSoft { get; set; }
        public bool ThirdSoft { get; set; }    
    
        public string VirtualMachineSelected { get; set; }
        public string RegionSelected { get; set; }
        public string VMSize { get; set; }

        public string VirtualMachineName { get; set; }
        public string AdminUser { get; set; }
        public string Password { get; set; }

        public string GetJson()
        {
           return JsonConvert.SerializeObject(this);
        }
    }
}