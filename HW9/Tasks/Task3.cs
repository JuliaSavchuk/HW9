namespace HW9
{
    public struct RGBColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        //HEX
        public string ToHex()
        {
            return "#" + Red.ToString("X2") + Green.ToString("X2") + Blue.ToString("X2");
        }

        //HSL
        public void ToHSL(out double hue, out double saturation, out double lightness)
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h, s, l;

            double delta = max - min;

            if (delta == 0)
            {
                h = 0;
            }
            else if (max == r)
            {
                h = 60 * (((g - b) / delta) % 6);
            }
            else if (max == g)
            {
                h = 60 * (((b - r) / delta) + 2);
            }
            else
            {
                h = 60 * (((r - g) / delta) + 4);
            }

            l = (max + min) / 2;

            if (delta == 0)
            {
                s = 0;
            }
            else
            {
                s = delta / (1 - Math.Abs(2 * l - 1));
            }

            hue = h < 0 ? 360 + h : h;
            saturation = s;
            lightness = l;
        }

        //CMYK
        public void ToCMYK(out double cyan, out double magenta, out double yellow, out double black)
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            black = 1 - Math.Max(r, Math.Max(g, b));

            if (black == 1)
            {
                cyan = 0;
                magenta = 0;
                yellow = 0;
            }
            else
            {
                cyan = (1 - r - black) / (1 - black);
                magenta = (1 - g - black) / (1 - black);
                yellow = (1 - b - black) / (1 - black);
            }
        }
    }
}
