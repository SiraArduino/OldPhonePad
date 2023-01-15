using System;

namespace IronSoftware
{
    class CodingChallenge
    {

        static void Main(string[] args)
        {
            Console.Write("Please input: ");
            string input = Console.ReadLine();            
            Console.Write(OldPhonePad(input));
        }
    
        public static string OldPhonePad(string input)
        {
            // parameters
            string output = ""; // final output
            string btnAll = ""; // pressed buttons collection
            int i = 0; // index of btnAll
            
            if (input.EndsWith("#")) // to validate # that must be included at the end always
            {
                foreach (char btn in input) // start to identify which character to be returned one by one
                {
                    if (i == 0) // to collect first char at first time
                    {
                        btnAll += btn;
                        i += 1;
                    }
                    else
                    {
                        switch (btn)
                        {
                            // in case pausing or # is found
                            case ' ' or '#':
                                
                                output = PressingButton(btnAll.Substring(i - 1, 1), i, output); // function for identifying the right char

                                // to reset index and btnAll after pausing or # is found
                                i = 0;
                                btnAll = "";

                                break;

                            // in case * is found
                            case '*':
                                btnAll += btn;
                                i += 1;
                                break;
                            
                            // in case else
                            default:
                                if (btn.ToString() == btnAll.Substring(i - 1, 1)) // to check current char whether it's the same as last one or not
                                {
                                    i += 1; // if yes, continue to add index one by one
                                }
                                else
                                {
                                    output = PressingButton(btnAll.Substring(i - 1, 1), i, output); // function for identifying the right char

                                    // if no, reset the index and btnAll
                                    i = 1;
                                    btnAll = "";
                                }

                                btnAll += btn; // collect char into btnAll
                                break;
                        }
                    }


                }
                return "Output: " + output; // return final output once the entire input is identified
            }
            else
            {
                return "Please include # at the end of every input, try again."; // notification
            }                                          
        }

        // function for identifying the right char        
        // lastBtn = the last value of pressing button
        // indexBtn = the last index of btnAll
        // output = returned value after identifying
        public static string PressingButton(string lastBtn, int indexBtn, string output)
        {              
            switch (lastBtn)
            {

                // to seek the right returned char from the number of pressing the same button on keypad as the following cases of 1 - 9 and *
                // it's divided by 3 due to they have 3 characters in their own buttons other than 7 and 9 they are divided by 4 on the same reason                

                // pressing button 1 on keypad
                case "1":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "&";
                            break;
                        case 2:
                            output += '\'';
                            break;
                        case 0:
                            output += "(";
                            break;
                    }
                    break;

                // pressing button 2 on keypad
                case "2":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "A";
                            break;
                        case 2:
                            output += "B";
                            break;
                        case 0:
                            output += "C";
                            break;
                    }
                    break;

                // pressing button 3 on keypad
                case "3":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "D";
                            break;
                        case 2:
                            output += "E";
                            break;
                        case 0:
                            output += "F";
                            break;
                    }
                    break;

                // pressing button 4 on keypad
                case "4":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "G";
                            break;
                        case 2:
                            output += "H";
                            break;
                        case 0:
                            output += "I";
                            break;
                    }
                    break;

                // pressing button 5 on keypad
                case "5":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "J";
                            break;
                        case 2:
                            output += "K";
                            break;
                        case 0:
                            output += "L";
                            break;
                    }
                    break;

                // pressing button 6 on keypad
                case "6":
                    switch (indexBtn % 3)
                    {
                        case 1:
                            output += "M";
                            break;
                        case 2:
                            output += "N";
                            break;
                        case 0:
                            output += "O";
                            break;
                    }
                    break;

                // pressing button 7 on keypad
                case "7":
                    switch (indexBtn % 4)
                    {
                        case 1:
                            output += "P";
                            break;
                        case 2:
                            output += "Q";
                            break;
                        case 3:
                            output += "R";
                            break;
                        case 0:
                            output += "S";
                            break;
                    }
                    break;

                // pressing button 8 on keypad
                case "8":
                        switch (indexBtn % 3)
                        {
                            case 1:
                                output += "T";
                                break;
                            case 2:
                                output += "U";
                                break;
                            case 0:
                                output += "V";
                                break;
                        }
                        break;

                // pressing button 9 on keypad
                case "9":
                    switch (indexBtn % 4)
                    {
                        case 1:
                            output += "W";
                            break;
                        case 2:
                            output += "X";
                            break;
                        case 3:
                            output += "Y";
                            break;
                        case 0:
                            output += "Z";
                            break;
                    }
                    break;

                // pressing button * on keypad
                case "*": // * is backspace, so no adding
                    break;
            }
            
            return output; // return output after identifying
        }
    }
}