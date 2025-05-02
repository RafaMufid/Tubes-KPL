using System;

namespace Tubes_KPL_Kel6
{
    public class attack
    {
        public static readonly Random rng = new Random();
        public static int Damage(string Daction)
        {
            string[] weapon = { "sword", "spear", "hammer", "fireball", "heal" };
            string[] actions = { "slash", "pierce", "strike", "magic", "heal1", "heal2", "atk_buff", "hp_buff" };
            int[] damage = { 10, 15, 5, 20, 15, 30, 0, 25 };
            int maxlength = actions.Length;

            int cd = 0;
            for (int i = 0; i < weapon.Length; i++) {
                cd = damage[i];
                return cd;
            }

            return cd;
        }

        public static int enemyDMG(int health)
        {
            int a = rng.Next(5, 21);
            Console.WriteLine("musuh menyerang dengan damage: " + a);
            return health - a;
        }

        public static int getDamage(int health, string test)
        {
            int buff = Damage("atk_buff");
            int dmg = Damage(test);
            Console.WriteLine("damage yang dikeluarkan : " + dmg);
            Console.WriteLine("buff yang diberika: " + buff);
            return health - (dmg + buff);
        }

        public static int getHeal(int health, string heal)
        {
            int heal1 = Damage(heal);
            Console.WriteLine("heal yang diberikan : " + heal1);
            return health + heal1;
        }
    }
}
