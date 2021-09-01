/*

配列 - 問題文

n個の整数a1,a2,a3,...,anが与えられます。この時、aの隣合わせる各要素の差の平均値μを求めてください。

入力は以下の通りです。
n
a1
a2
a3
.
.
.
an

出力は以下の通りです。
μ

例

入力
3
4
5
2

出力
2

参考: (nの絶対値) = Math.Abs(n);

*/

//解答例

using System;

namespace Practices {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            double avg = 0; //平均値は整数とは限らないからdouble型

            for (int i = 0; i <= n - 1; i++) { //n回入力を求めて,それぞれa[i]に代入する
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 1; j <= n - 1; j++) { //隣合わせる各要素間の差をとり、avgに足す
                avg += Math.Abs(a[j] - a[j - 1]);
            }

            avg /= n - 1; //平均をとる

            Console.WriteLine(avg); //出力
        }
    }
}