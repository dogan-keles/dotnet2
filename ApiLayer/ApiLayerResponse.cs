using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkintechRestApiDemo.Domain.ApiLayer
{
    public class ApiLayerResponse
    {
        public bool change { get; set; }
        public string end_date { get; set; }
        public Quotes quotes { get; set; }
        public string source { get; set; }
        public string start_date { get; set; }
        public bool success { get; set; }
    }
}
