using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_shepardson_bruce
{      // Define an internal class named 'Car'
       // 'internal' means this class is accessible only within the same assembly

    internal class Car
    {   // Private field to store the model of the car
        private string model;
        // Auto-implemented property for the 'Make' of the car
        // The compiler generates the backing field automatically
        public string Model { get { return model; } set { model = value; } } 
        public string Make { get; set; }



    }
}
