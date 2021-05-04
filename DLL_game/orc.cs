using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_game
{
   public class Orc : Character
    {
        public Orc(int Health, int Mana, int Strength, string Name) //constructeur
            : base(1000, 0, Strength, Name) { }

        public string SendMessage(string message, string name)
        {
            return name + "" + Chat(message);
        }

        public void Fire()
        {
            bool bl = IsBlock(Attack());

            if (bl)
            {
                Health -= Attack();
            }
        }

    }
}
