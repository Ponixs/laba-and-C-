using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RegularPromice
    {
        string reg;

        public RegularPromice(string regex)
        {
            reg = regex;
        }
        public async Task<MatchCollection> parse_main(string text)
        {
            return await Task.Run(() =>
            {
                Regex regex = new Regex(@reg);
                MatchCollection matches = regex.Matches(text);
                return matches;
            });

        }
    }
}
