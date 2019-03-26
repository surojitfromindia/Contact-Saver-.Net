using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSaver
{ //26.2.2019
    class MissL
    {
        /** Capital First Word *
         * 26.2.2019*/
        public static string CapitalWord(String Word, int Index)
        {
            String word = Word;
            string IndexCh = word.Substring(Index,1);
           
            string NewValu = IndexCh.ToUpper();
     
            word = NewValu + word.Remove(Index,1);
            
            return word;
        }
    }
}
