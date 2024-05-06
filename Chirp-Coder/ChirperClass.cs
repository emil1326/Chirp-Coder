namespace Chirp_Coder
{
    class ChirperClass
    {
        public string KEY { get; set; } = "";
        public bool Decoding { get; set; } = false;

        public string ChirpIT(string Input)
        {
            string Res = "";
            int adjust = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                string temp = CharToString(Input[i], i + adjust);
                if (temp == "caw ")
                    adjust--;
                Res += temp;
            }

            return Res;
        }

        string CharToString(char Input, int Index)
        {
            if (Input == ' ')
                return "caw ";

            string Byn = Convert.ToString(Input, 2);

            Byn = Byn[1..];

            Byn = Byn.TrimStart('0');

            if (Byn.Length == 0)
                Byn = "0";

            Byn = ReplaceWithIndex(Byn, Index);

            return Byn;
        }

        string ReplaceWithIndex(string input, int index)
        {
            if (index % 5 == 0)
                return ReplaceWithChar(input, 'c');
            else if (index % 5 == 1)
                return ReplaceWithChar(input, 'h');
            else if (index % 5 == 2)
                return ReplaceWithChar(input, 'i');
            else if (index % 5 == 3)
                return ReplaceWithChar(input, 'r');
            else if (index % 5 == 4)
                return ReplaceWithChar(input, 'p');
            else
                return " ";
        }
        string ReplaceWithChar(string Input, char C)
        {
            Input = Input.Replace('0', C);
            Input = Input.Replace('1', char.ToUpper(C));
            return Input;
        }
    }
}
