using System;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class Reg1
    {
        string reg;

        public Reg1(string regex)
        {
            reg = regex;
        }
        public MatchCollection parse_main(string text)
        {
            Regex regex = new Regex(@reg);
            MatchCollection matches = regex.Matches(text);
            return matches;
        }
    }
}
