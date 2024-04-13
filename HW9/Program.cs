namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");

            Vector3D vector1 = new Vector3D(2, 3, 4);
            Vector3D vector2 = new Vector3D(5, 6, 7);

            Console.WriteLine("Перший вектор: " + vector1);
            Console.WriteLine("Другий вектор: " + vector2);

            Vector3D scaledVector = vector1 * 3;
            Console.WriteLine("Помножений перший вектор: " + scaledVector);

            Vector3D sumVector = vector1 + vector2;
            Console.WriteLine("Сума векторів: " + sumVector);

            // Віднімання векторів
            Vector3D subtractedVector = vector1 - vector2;
            Console.WriteLine("Різниця векторів: " + subtractedVector);
            Console.WriteLine("\n________________\n");


            Console.WriteLine("\n_____Task 2_____\n");
            DecimalNumber number = new DecimalNumber(15);

            Console.WriteLine("Десяткове число: " + number);

            string binary = number.ToBinary();
            Console.WriteLine("У двійковій системі: " + binary);

            string octal = number.ToOctal();
            Console.WriteLine("У вісімковій системі: " + octal);

            string hexadecimal = number.ToHexadecimal();
            Console.WriteLine("У шістнадцятковій системі: " + hexadecimal);
            Console.WriteLine("\n________________\n");



            Console.WriteLine("\n_____Task 3_____\n");
            RGBColor color = new RGBColor(255, 128, 64);
            Console.WriteLine("RGB колір: R = 255, G = 128, B = 64");

            string hex = color.ToHex();
            Console.WriteLine("HEX формат: " + hex);

            double hue, saturation, lightness;
            color.ToHSL(out hue, out saturation, out lightness);
            Console.WriteLine($"HSL формат: H = {hue}, S = {saturation}, L = {lightness}");

            double cyan, magenta, yellow, black;
            color.ToCMYK(out cyan, out magenta, out yellow, out black);
            Console.WriteLine($"CMYK формат: C = {cyan}, M = {magenta}, Y = {yellow}, K = {black}");
            Console.WriteLine("\n________________\n");
        }
    }
}