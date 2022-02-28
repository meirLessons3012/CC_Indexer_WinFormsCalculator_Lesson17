using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Indexer_WinFormsCalculator_Lesson17
{
    public class Calculator
    {
        private double number1;
        public double Number1 { get { return number1; } set { number1 = value; } }
        public double Number2 { get; set; }
        private double[] Numbers { get; set; } = new double[10];



        public Calculator()
        {
        }

        public double this[int index]
        {
            get
            {
                return Numbers[index];
            }
            set
            {
                Numbers[index] = value;
            }
        }

        public double this[string propName]
        {
            get
            {
                if (propName == "Number1")
                    return Number1;
                else if (propName == "Number2")
                    return Number2;
                return 0;
            }
            set
            {
                if (propName == "Number1")
                    Number1 = value;
                else if (propName == "Number2")
                    Number2 = value;
            }
        }

        public double this[string propName, int mltpBy]
        {
            get
            {
                if (propName == "Number1")
                    return Number1 * mltpBy;
                else if (propName == "Number2")
                    return Number2 * mltpBy;
                return 0;
            }
            set
            {
                if (propName == "Number1")
                    Number1 = value * mltpBy;
                else if (propName == "Number2")
                    Number2 = value * mltpBy;
            }
        }

        public double GetPropValue(string propName, int mltpBy = 1)
        {
            if (propName == "Number1")
                return Number1 * mltpBy;
            else if (propName == "Number2")
                return Number2 * mltpBy;
            return 0;
        }

        public void SetPropValue(string propName, double value, int mltpBy = 1)
        {
            if (propName == "Number1")
                Number1 = value * mltpBy;
            else if (propName == "Number2")
                Number2 = value * mltpBy;
        }

    }
}
