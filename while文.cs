/*

while文 - 問題文

整数nが与えられる。この時、k^2 <= nとなる最大の整数kを求めてください。

入力は以下の通りです。
n

出力は以下の通りです。
k

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int k = 0;

            while(true) {
                k++;

                if (k * k > n) {
                    k--;
                    break;
                }
            }

            Console.WriteLine(k);
        }
    }
}