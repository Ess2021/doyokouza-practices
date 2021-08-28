/*

for文 - 問題文

整数nが与えられる。この時、0以上n以下の全ての偶数n1,n2,n3,...,niを表示するプログラムを作成してください。

入力は以下の通りです。
n

出力は以下の通りです。
n1
n2
n3
.
.
.
ni

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (String[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i += 2) {
                Console.WriteLine(i - 1);
            }

            /*
            for (int i = 1; i < n; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}