using System;

namespace car_reg_utils
{
    public class CarRegCheckerUtil
    {
        public int GetNextInfix(int input)
        {
            if(input > 50 && input < 99)
            {
                int result = input - 50 + 1;
                if (result == 50)
                {
                    return result - 1;
                }
                return result;
            } else
            {
                return 02;
            }
            
        }
    }
}