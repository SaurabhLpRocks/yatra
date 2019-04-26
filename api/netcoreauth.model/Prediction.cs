using System;
using System.Collections.Generic;
using System.Text;

namespace netcoreauth.model
{
    public class Prediction
    {
        public string Class { get; set; }
        public int Accuracy { get; set; }
    }
}
