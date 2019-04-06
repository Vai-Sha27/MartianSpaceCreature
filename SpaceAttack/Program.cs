using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SpaceAttack
{
    class Program
    {
        private static List<Martian> ArrMartians = new List<Martian>();
        private  static SpaceCreature spaceCreature_Health = null;
        private const int DefaultMartian_AttackVal = 10;
        public static int MartianCount, MartianAliveCount;

        static void Main(string[] args)
        {
            Console.Write("Enter the Space Creature's Health: ");
            int setCreature_Health = Convert.ToInt32(Console.ReadLine());
            if (setCreature_Health <= 0)
            {
                throw new ArgumentOutOfRangeException("Value entered is below 1.");
            }
            spaceCreature_Health = new SpaceCreature(setCreature_Health);               

            while (spaceCreature_Health.HealthPoints > 0)
            {
                //1                
                CreateMartian();

                //2                
                CreatureAttacks();

                //3                
                MartianAttacks();
            }
            MartianCount = ArrMartians.Count;
            Console.WriteLine($"Total Martians: {MartianCount}");
            Console.WriteLine($"Total Martians alive: {MartianAliveCount}");
        }

        static void CreateMartian()
        {
            Console.Write("Enter new Martian: ");
            var objMartian = new Martian();            
            objMartian.HealthPoints = Convert.ToInt32(Console.ReadLine());
            if(objMartian.HealthPoints <=0)
            {
                throw new ArgumentOutOfRangeException("Value entered is below 1.");
            }
            Console.WriteLine();
            objMartian.AttackChk = DefaultMartian_AttackVal;
            ArrMartians.Add(objMartian);
        }

        static  void CreatureAttacks()
        {
            Console.WriteLine("Creature Attacks!");
            MartianAliveCount = ArrMartians.Count - 1;
            for (int index = 0; index < ArrMartians.Count; index++)
            {
                Martian martian = ArrMartians[index];
                martian.HealthPoints -= 10;
                if (martian.HealthPoints <= 0)
                {
                    MartianAliveCount -= 1;
                    continue;
                }
                else
                {
                    Console.WriteLine($"{index + 1} Martian Health: {martian.HealthPoints} ");
                }                
            }
            Console.WriteLine();
        }

        static  void MartianAttacks()
        {
            if (ArrMartians.Count >= 5)
            {
                Console.WriteLine("Martians Attack!");
                for (int index = 0; index < ArrMartians.Count; index++)
                {                    
                    Martian martian = ArrMartians[index];
                    if (martian.HealthPoints <= 0)
                        continue;
                    spaceCreature_Health.HealthPoints -= martian.AttackChk;
                    if (spaceCreature_Health.HealthPoints <= 0)
                    {
                        Console.WriteLine("Creature is dead!");
                        break;
                    }
                    Console.WriteLine($"Creature Health:  {spaceCreature_Health.HealthPoints}");
                    martian.AttackChk += 1;
                }
                Console.WriteLine();
            }
        }
    }
}
