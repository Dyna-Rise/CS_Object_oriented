using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice2
{
    internal class Person
    {
        //変数
        string name; //キャラの名前
        int level; //レベル
        int hp; //体力
        string info = "ただの村人"; //キャラ属性の特徴

        //命令（メソッド）
        //そのキャラの情報を表示するメソッド
        public void InfoDisplay()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("名前：" + name);
            Console.WriteLine("レベル：" + level);
            Console.WriteLine("体力：" + hp);
            Console.WriteLine(info);
        }
    }
}
