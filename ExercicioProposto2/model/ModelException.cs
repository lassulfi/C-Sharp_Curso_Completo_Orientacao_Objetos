using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioProposto2.model
{
    class ModelException : Exception
    {
        public ModelException(string msg) : base(msg){ }
    }
}
