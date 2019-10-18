using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HRElectronicsShop {
    class Program {
        static void Main(string[] args) {

            int[] keyboards = { 12, 12 };
            int[] drives = { 5, 2, 8 };

            int b = 10;

            var spent = -1;      

            foreach(int n in keyboards) {
                foreach(int m in drives) {                    
                    if(n + m <= b && n + m > spent) {
                        spent = n + m;
                    }
                }
            }
            return spent;
        }
    }
}
