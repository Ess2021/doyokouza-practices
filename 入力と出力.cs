/*

入力と出力 - 問題文

文字列sが与えられた時、"sさんこんにちは!"と表示するプログラムを作成してください。

入力は以下の通りです。
s

出力は以下の通りです。
sさんこんにちは!

*/

//解答例

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            string s = Console.ReadLine();
            Console.WriteLine(s + "さんこんにちは!");
        }
    }
}