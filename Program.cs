using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //自作したPersonクラス（Person型）の実体化（インスタンス）
            Person p1 = new Person("ムラビート",150);
            p1.InfoDisplay(); //p1にメソッドを使わせてみる
            p1.AttackInfo(); //技名を調べてみる(引数なし）

            //自作したPersonクラス（Person型）の実体化（インスタンス）
            Person p2 = new Person();
            p2.NameSet("マチビート");
            p2.HPSet(180);
            p2.InfoDisplay(); //p2にメソッドを使わせてみる
            p2.AttackInfo(1); //技名を調べてみる(引数なし）

            //自作したPersonクラス（Person型）の実体化（インスタンス）
            Person p3 = new Person();
            p3.InfoDisplay(); //p3にメソッドを使わせてみる
            p3.AttackInfo(99); //技名を調べてみる(引数なし）
        }
    }
}
