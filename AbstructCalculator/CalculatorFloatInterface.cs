using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructCalculator
{
    class CalculatorFloatInterface : ICalculator <float>
    {
        public float Add(float a, float b) { return a + b; }
        public float Sub(float a, float b) { return a - b; }
        public float Multiply(float a,float b){ return a * b; }
        public float Divide(float a, float b) { return a / b; }
    }
}
