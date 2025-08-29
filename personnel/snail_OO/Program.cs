using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snail_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snail snail1 = new Snail(aliveSnail: "__@_ö", deadSnail: "_____", name: "Escargot 1", life: 50);;

            //Snail snail2 = new Snail();

            Console.WriteLine($"Vie de {snail1._name} : {snail1._life}");

            for (int i = 0; i < snail1._life; i++)
            {

            }


            Console.ReadKey();
        }

        class Snail
        {
            //public const string ALIVE_SNAIL     = "__@_ö";
            //public const string DEAD_SNAIL      = "_____";

            public string _aliveSnail;
            public string _deadSnail;
            public string _name;
            public int _life;

            public Snail()
            {
                _aliveSnail = "__@_ö";
                _deadSnail = "_____";
                _name = "Escargot par défaut";
                _life = 50;
                

            }

            public Snail(string aliveSnail, string deadSnail, string name, int life)
            {
                this._aliveSnail = aliveSnail;
                this._deadSnail = deadSnail;
                this._name = name;
                this._life = life;

            }

        }
    }
}
