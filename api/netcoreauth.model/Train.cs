using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace netcoreauth.model
{
    public class Train
    {
        [Key]
        public int Id { get; set; }
        public string TrainName { get; set; }  
        public List<Prediction> Prediction { get; set; }
    }
}
