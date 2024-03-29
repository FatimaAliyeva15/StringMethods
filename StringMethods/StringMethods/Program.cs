namespace StringMethods
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Space($"Bosluq olmadan: {"   Salam,        dunya"}");
            Console.WriteLine(Check("Hello World"));
            Console.WriteLine($"Ilk soz: {FirstWord("Hello World")}");
            Console.WriteLine($"2 soz ve ilk herfler boyuk: {TwoWords("   Salam,        Dunya")}");


            int[] arr = { 1, 2, 3 };
            Console.Write("Yeni deyer elave et: ");
            AdddArray(ref arr, 4);
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }


        public static void Space(string str)
        {
            if (str == null || str.Length == 0)
            {
                return;
            }
            string newStr = "";
            if (str[0] != ' ')
            {
                newStr += str[0];
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (!(str[i] == ' ' && str[i - 1] == ' '))
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine(newStr);

        }


        public static string Check(string str)
        {
            bool checkDigit = false;
            bool checkUpper = false;
            bool checkLower = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {

                    checkDigit = true;
                }

                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    checkUpper = true;
                }

                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    checkLower = true;

                }
            }

            string result = $"En az 1 reqem : {checkDigit}\nEn az 1 boyuk herf: {checkUpper}\nEn az 1 kicik herf: {checkLower}";

            return result;
        }




        public static string FirstWord(string str)
        {
            string newStr = "";

            if (str.Length == 0)
            {
                return "String bosdur";
            }

            if (str[0] != ' ')
            {
                newStr += str[0];
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!(str[i] != ' ' && str[i - 1] == ' '))
                {
                    newStr += str[i];
                }
                else if (str[i] != ' ')
                {
                    break;
                }
            }
            return newStr;

        }


        public static bool TwoWords(string str)
        {
            bool firstWord = false;
            bool secondWord = false;
            bool check = false;

            if (str == null || str.Length == 0)
            {
                return false;
            }



            string newStr = "";
            if (str[0] != ' ')
            {
                newStr += str[0];
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!(str[i] == ' ' && str[i - 1] == ' '))
                {
                    newStr += str[i];
                }
            }

            if (newStr[0] >= 'A' && newStr[0] <= 'Z')
            {
                firstWord = true;
            }
            for (int j = 0; j < newStr.Length; j++)
            {
                if ((newStr[j] == ' ' && j + 1 < newStr.Length && (newStr[j + 1] >= 'A' && newStr[j + 1] <= 'Z')))
                {
                    secondWord = true;

                    for (int k = j + 2; k < newStr.Length; k++)
                    {
                        if (newStr[k] == ' ' && k + 1 < newStr.Length && ((newStr[j + 1] >= 'A' && newStr[j + 1] <= 'Z') || (newStr[j + 1] >= 'a' && newStr[j + 1] <= 'z')))
                        {
                            check = true;
                            break;
                        }
                    }
                    break;
                }


            }



            if (firstWord && secondWord && !check)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static void AdddArray(ref int[] arr, int value)
        {
            int[] arr2 = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr2.Length - 1] = value;
            arr = arr2;

        }


    }
}
