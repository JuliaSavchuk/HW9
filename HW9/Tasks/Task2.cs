namespace HW9
{
    public struct DecimalNumber
    {
        public int value { get; set; }

        public DecimalNumber(int val)
        {
            value = val;
        }

        //Переведення числа у двійкову систему
        public string ToBinary()
        {
            return Convert.ToString(value, 2);
        }

        //Переведення числа у вісімкову систему
        public string ToOctal()
        {
            return Convert.ToString(value, 8);
        }

        //Переведення числа у шістнадцяткову систему
        public string ToHexadecimal()
        {
            return Convert.ToString(value, 16);
        }

        public override string ToString()
        {
            return $"({value})";
        }
    }
}