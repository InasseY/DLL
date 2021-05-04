using System;

namespace DLL_game
{
   
    public class Character
    {
        
        private int m_health;
        public int Health //constructeur 
        {
            get { return m_health; }
            set { m_health = value; }
        }

        private int m_mana;
        public int Mana //constructeur 
        {
            get { return m_mana; } //get = lecture 
            set { m_mana = value; } //set = écriture
        }

        private int m_strength = 6;
        public int Strength //constructeur 
        {
            get { return m_strength; }
            set { m_strength = value; }
        }

        private string m_name; //constructeur 
        public string Name
        {
            get { return m_name ; }
            set { m_name = value; }
        }

        public Character()
        {
            Console.WriteLine("Nouvelle personnage créée.");
        }

        public Character(int health, int mana, int strength, string name)
        {
            this.m_health = health;
            this.m_mana = mana;
            this.m_strength = strength;
            this.m_name = name;
            Console.WriteLine("Nouvelle personnage créée. ");
        }

        public string Chat(string message)
        {
            return Name + " a dit " + message;
        }

        public int Attack()
        {
            Random rnd = new Random();
            return Strength * rnd.Next(1, 10);
        }

        public bool IsBlock(int x, int n = 3)
        {
            if ((x % n) == 0)
            {
                return false;
            }
            return true;
        }

    }
    
}
