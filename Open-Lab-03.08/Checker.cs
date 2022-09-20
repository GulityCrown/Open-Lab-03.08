using System;
using System.ComponentModel.DataAnnotations;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            if (word[word.Length-1]  == 's') {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
