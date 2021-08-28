using Internal;
/*

まとめの問題1 - 問題文

整数a1,a2,a3が与えられる。この時、a1,a2,a3のそれぞれについて、
偶数なら2倍、奇数なら3倍してa1,a2,a3と対応する整数b1,b2,b3に代入し、b1,b2,b3の和sを求めてください。
また、その和について、偶数ならEven、奇数ならOddと出力してください。

入力は以下の通りです。
a1
a2
a3

出力は以下の通りです。
s
EvenまたはOdd

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int b1 = AtoB(a1);
            int b2 = AtoB(a2);
            int b3 = AtoB(a3);

            Console.WriteLine(b1 + b2 + b3);
            
            if ((b1 + b2 +b3) % 2 == 0) {
                Console.WriteLine("Even");
            } else {
                Console.WriteLine("Odd");
            }
        }

        static int AtoB (int a) {
            if (a % 2 == 0) {
                return a * 2;
            } else {
                return a * 3;
            }
        }
    }
}