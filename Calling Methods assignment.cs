using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods_Assignment_app;

namespace Methods_Assignment_app
{
    public class MathMethods

    {
        //create three methods that take one interger parameter and return an interger
        public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
        public static int Defense(int defense)
        {
            int enemy_str = 7;
            int weapon_mt = 11;
            int triangle_bonus = -1;
            int crit_coeff = 1;
            int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * crit_coeff;
            return damage;
        }
        public static int Attack(int strength)
        {
            int enemy_def = 4;
            int weapon_mt = 8;
            int triangle_bonus = 1;
            int crit_coeff = 3;
            int damage = (strength + (weapon_mt + triangle_bonus) - enemy_def) * crit_coeff;
            return damage;
        }
    }
}

//Program.cs


namespace CallingMethodsAssignment
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You' ve encountered Groznyi the brigand and he launches a suprise attack.");
            Console.WriteLine("input your defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods.Defense(defense);
            Console.WriteLine("You have taken " + enemy_damage + " HP of damage.");
            Console.WriteLine("Your healer, serra is near by. she heals you with her staff.");
            Console.WriteLine("Input your healer's magic stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + " HP ");
            Console.WriteLine("Now its your turn  to counter attack.");
            Console.WriteLine("Input your strength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods.Attack(strength);
            Console.WriteLine("You have landed a critical attack and dealt " + damage + " HP worth of damage");
            Console.ReadLine();
        }
    }
}

