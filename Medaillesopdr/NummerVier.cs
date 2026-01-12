using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerVier
    {
        private int currentYear = 2026;
        private String a;
        private String aaa;
        private int age;
        private int dateOfBirth;
        private bool overEighteen;
       

        public void numbFour()
        {
            Console.WriteLine("Date of Birth?");
            a = Console.ReadLine();
            if (int.TryParse(a, out int b))
            {
                dateOfBirth = b;
                math();
                if (age >= 18) overEighteen = true;
                if (overEighteen == true)
                {
                    EighteenOrOlder();
                    Console.WriteLine("You are " + age + " years old! Also " + aaa);
                }
                else
                {
                    Console.WriteLine("You are " + age + " years old.");
                }


            }
            }
        public int math()
        {
            age = currentYear - dateOfBirth;
            return age;
        }
        public String EighteenOrOlder()
        {
            
            if(age == 18)
            {
                aaa = "you're an adult now, time to pay taxes :c";
            }
            if(age >= 25 && age < 40)
            {
                aaa = "at this point you should have your life figured out, if you dont it might be over dude gg";
            }
            if(age >= 40 && age < 55) { 
            
                aaa = "you're now considered old, yet if you die now you're considered too young to go, Funny how that works isnt it?";
            }
            if(age >= 55)
            {
                aaa = "fun fact, youre old.";
            }
            return aaa;
        }
    }
}