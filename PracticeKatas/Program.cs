using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace PracticeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(UniqueInOrder("AAAABBBCCDAABBB"));
            Console.WriteLine(addingBigNumbers("123456789", "987654322"));
            Console.WriteLine(MultiplesOfThreeAndFive(10));
            Console.WriteLine(dubStepDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"));
            Console.WriteLine(jadenCased("i don't know"));
            Console.WriteLine(replaceLetterswithAlphabet("abc"));
            Console.WriteLine(ExesandOhs("ooxx"));
            Console.WriteLine(firstNonRepeatingChar("sTreSS"));
            // Console.WriteLine(romanNumeralsHelper("L"));
            Console.WriteLine(iLoveYou(7));
            Console.WriteLine(binaries("10111213"));
            Console.WriteLine(movingZeros(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            Console.WriteLine(convertandreverse(12345));
        }
        public static long[] convertandreverse(int number)
        {
            char[] numtoWords = number.ToString().ToCharArray();
            long[] result = new long[numtoWords.Length];

            Array.Reverse(numtoWords);
            for(int i = 0; i < numtoWords.Length; i++)
            {
                result[i] = long.Parse(numtoWords[i].ToString());
            }


            return result;
        }
        public static int[] movingZeros(int[] numbers)
        {
            List<int> correctArray = new List<int>();
            List<int> zeros = new List<int>();

            foreach (int num in numbers)
            {
                if (num == 0)
                {
                    zeros.Add(0);
                }
                else
                {
                    correctArray.Add(num);
                }
            }
            correctArray.ForEach(num => Console.Write(num));
            return correctArray.Concat(zeros.ToArray()).ToArray();
        }

        public static int binaries(string binaryString)
        {
            int decimalNumber = 0;
            int remainder = 0;
            int numbits = 0; 
            string binary, finalString = "";

            foreach (char letter in binaryString)
            {
                Console.WriteLine(letter);
                binary = "";
                decimalNumber = int.Parse(letter.ToString());
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    binary = remainder.ToString() + binary;
                    decimalNumber = decimalNumber / 2;
                }

                numbits = (binary.Length - 1);
                Console.WriteLine("num bits " + numbits);
                binary = numbits.ToString() + "1" + binary;
                Console.WriteLine(binary + " ");
                finalString = finalString + binary;
            }
            
            return 0;
        }

        public static string iLoveYou(int number)
        {
            string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all"};

            if (number % 6 == 0)
            {
                return phrases[6];
            }

            return phrases[(number % 6) - 1];
        }


        private static void romanNumeralsHelper(string romanNumerals)
        {
        // incomplete
            string[,] numerals = { {"L","50" }, { "X","10"},{ "V", "5" }, { "I", "1" } }; 
            
            //work out if it's a letter or a number


            //get it working with a simple number
            for(int i = 0; i < romanNumerals.Length; i++)
            {
                //go through the array and find the value
                if (romanNumerals[i] == char.Parse(numerals[0, 0]))
                {

                }
                
            }
           
        }

        private static char firstNonRepeatingChar(string word)
        {
            ///////////////////////////////////////////////////
            //Description: finds the first non-repeating character in a string
            //works with upper and lower case values
            //date 30/3/2020
            int count = 0;


            for(int i = 0; i < word.Length; i++)
            {
                foreach(char letter in word)
                {
                    if(char.ToLower(letter) == char.ToLower(word[i]))
                    {
                        count++;
                    }

                }
                //check to see if this is the only letter in the string
                if (count == 1)
                {
                    //return the single letter
                    return word[i];
                }
                count = 0;
            }

            //command that returns an empty char
            return '\0';
        }

        private static bool ExesandOhs(string data)
        {
            ///////////////////////////////////////////////////////
            /*Description: counts all teh x's and o's in a string and returns a true/false value
            /* Date: 16/3/21
            /*
            /*********************************************************/
            int xCount = 0;
            int oCount = 0;

           foreach(char element in data.ToLower()){
                if (element == 'x')
                {
                    xCount++;
                }
                else if(element == 'o')
                {
                    oCount++;
                }
            }

            if (xCount == oCount) { return true; } else { return false; };
        }


        private static string replaceLetterswithAlphabet(string str)
        {
            //replace each value of a word with it's alphabetic value - complete
            string result = "";
            string text = str.ToLower();

            foreach (var c in text)
            {
                Console.WriteLine((int)c);
                result = result + ((int)c - 96);

            }

            return result;

        }

        private static void UniqueInOrder(string sequence)
        {
            /*          IEnumerable<T> lettersUsed;

                foreach (char letter in sequence)
                   {
                       if (letter != lettersUsed.Last())
                       {
                           lettersUsed.Add(letter); 
                       }
                   }

                   return lettersUsed;*/
        }
        private static int CatchingCarMilage(int Milage)
        {
            //returns a number based on how interesting the milage is
            int HowInteresting = 0;

            //if the number is followed by all 0's
            //if every digit is the same
            //if digits are sequential incrementing or decrementing
            //palindromic numbers
            //values in the awesomphrases array



            return HowInteresting;
        }
        private static string addingBigNumbers(string num1, string num2)
        {
            BigInteger ConvertedNum1 = BigInteger.Parse(num1);
            Console.WriteLine(ConvertedNum1);
            BigInteger ConvertedNum2 = BigInteger.Parse(num2);

            BigInteger sum = ConvertedNum1 + ConvertedNum2;

            return sum.ToString();
        }
        private static int MultiplesOfThreeAndFive(int num)
        {
            int total = 0;

            for(int count = 0; count < num; count++)
            {
                if (count % 3 == 0 || count % 5 == 0)
                {
                    Console.WriteLine(count);
                    total = total + count;
                }
            }

            return total;
        }
        private static string jadenCased(string NonJCString)
        {
            string jadenCaseString = "";
            string[] splitString = NonJCString.Split();
            foreach (string word in splitString) {
                jadenCaseString = jadenCaseString + char.ToUpper(word[0]) + word.Substring(1,word.Length-1) + " ";
            }

            return jadenCaseString.Trim(); 
        }

        private static string dubStepDecoder(string dubStep)
        {
            string songChoice = "  ";

            for (int i = 0; i < dubStep.Length; i++) {
                if ((dubStep[i] == 'W') && (dubStep[i+1] == 'U') && (dubStep[i+2] == 'B'))
                {
                    //strip repeating spaces
                    if (songChoice[songChoice.Length-1] != ' ')
                    {
                        songChoice = songChoice + " ";
                    }
                    i = i + 2;
                }
                else
                {
                    songChoice = songChoice + dubStep[i];
              }
            }

                return songChoice.Trim(); 
        }
    }
}
