/*

まとめの問題2 - 問題文

武田くんは、xについての数直線上を歩いて旅しようとしています。
武田くんは、時間t = 0の時点に、x = 0の地点を出発し、時間tiのときまでに地点xiに行こうと旅行プランを立てています。(iは添字)
訪れる地点は3つです。
武田くんは、時間t + 1の時点に最大x ± 2の地点まで移動できる速度で歩きます。その場にとどまることも可能です。
武田くんの旅行プランは実現可能であるかを調べ、可能の場合は、"able"、不可能の場合は、"unable"と出力してください。

入力は以下の通りです。
t1
x1
t2
x2
t3
x3

出力は以下の通りです。
ableまたはunable

※ AtCoder Beginners Contest(ABC) 86 - C問題 より改題 (配列の知識がなくても解けるように改題しました。その結果めちゃめちゃ簡単になりました。)

参考: (qの絶対値) = Math.Abs(q)

*/

using System;

namespace practices {
    class Program {
        static void Main (string[] args) {
            int t1 = Read();
            int x1 = Read();
            int t2 = Read();
            int x2 = Read();
            int t3 = Read();
            int x3 = Read();

            bool first = isAble(0, t1, 0, x1); //t0 = 0, x0 = 0を忘れずに
            bool second = isAble(t1, t2, x1, x2);
            bool third = isAble(t2, t3, x2, x3);

            if (first == true && second == true && third == true) {
                Console.WriteLine("able");
            } else {
                Console.WriteLine("unable");
            }
        }

        static int Read () {
            return int.Parse(Console.ReadLine());
        }

        static bool isAble (int time1, int time2, int place1, int place2) {
            if (Math.Abs(time2 - time1) >= Math.Abs(place2 - place1) / 2) {
                return true;
            } else {
                return false;
            }
        }
    }
}
