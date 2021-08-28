/*

変数と関数 - 問題文

整数a,bが与えられた時、a+bを返す関数を作ってください。
また、その関数を使って、整数a,bが与えられた時　、その和nを表示するプログラムを作成してください。

入力は以下の通りです。
a
b

出力は以下の通りです。
n

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(a, b));
        }

        static int Sum (int a, int b) {
            return a + b;
        }
    }
}