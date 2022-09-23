namespace Task_1.Service
{
    public static class Calculator
    {
        public static dynamic Add(dynamic value1, dynamic value2)
        {
            return value1 + value2;
        }
        public static dynamic Mul(dynamic value1, dynamic value2)
        {
            return value1 * value2;
        }
        public static dynamic Div(dynamic value1, dynamic value2)
        {
            if (value2 != 0)
            {
                return value1 / value2;
            }

            return "Exception division by zero!";
        }

        public static dynamic Sub(dynamic value1, dynamic value2)
        {
            return value1 - value2;
        }
    }
}
