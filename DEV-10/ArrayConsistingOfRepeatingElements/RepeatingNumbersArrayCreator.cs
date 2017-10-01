using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConsistingOfRepeatingElements
{
    class RepeatingNumbersArrayCreator
    {
        public List<double> CreateRepeatingNumbersArray(List<double[]> superArray)
        {
            const double epsilon = double.Epsilon;
            int count = 0;
            //List<float[]> superArray = superArrayCreator.CreateSuperArray();
            List<double> repeatingNumbersArray = new List<double>();
            for (int i = 0; i < superArray.Count - 1; i++)
            {
                for(int l = i + 1; l < superArray.Count; l++)
                {
                    for (int j = 0; j < superArray[i].Length; j++)
                    {
                        for (int k = 0; k < superArray[l].Length; k++)
                        {
                            if (Math.Abs(superArray[i][j] - superArray[l][k]) <= epsilon)
                            {
                                /**/
                                count++;
                                break;
                            }
                        }
                        if (count >= 1)
                        {
                            if(repeatingNumbersArray.Count == 0)
                            {
                                repeatingNumbersArray.Add(superArray[i][j]);
                            }
                            else
                            {
                                for (int h = 0; h < repeatingNumbersArray.Count; h++)
                                {
                                    if (!(Math.Abs(superArray[i][j] - repeatingNumbersArray[h]) < epsilon))
                                    {
                                        repeatingNumbersArray.Add(superArray[i][j]);
                                        break;
                                    }
                                }
                            }                           
                        }                       
                    }
                }             
            }
            return repeatingNumbersArray;
        }
    }
}
