using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_game
{
   public class Wizard : Character
    {

        public  Wizard (int Health, int Mana, int Strength, string Name) //constructeur
            : base(500, 250, Strength, Name) { }

        public string SendMessage(string message, string name)
        {
            return name + "" + Chat(message);
        }
        public void kick()
        {
            bool bl = IsBlock(Attack());

            if (bl)
            {

                Health -= Attack();
            }
        }
    } 
    } 

