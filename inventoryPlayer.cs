using System;
using System.Collections.Generic;

namespace Tubes_KPL_Kel6
{
    public class inventoryPlayer
    {  
        public List<string> heals = new List<string>();
        public List<string> buffs = new List<string>();
        public List<string> weapon = new List<string>();
        public void addWeapon()
        {
            weapon.Add("sword");
            weapon.Add("spear");
            weapon.Add("hammer");
            weapon.Add("fireball");
        }
        public void addHeals() {

            heals.Add("heal");
        }
        public void ShowInventory()
        {
            Console.WriteLine("-- Inventory --");
            for (int i = 0; i < weapon.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + weapon[i]);
            }

            Console.WriteLine("");
            Console.WriteLine(" =- heal -= ");

            for (int i = 0; i < heals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". "+ heals[i]);
            }
        }

        public bool checkWeapon(string item)
        {
            for (int i = 0; i < weapon.Count; i++)
            {
                if (item == weapon[i]) {
                    return true;
                }
            }
            return false;
        }

        public bool checkHeals(String name) {
            for(int i = 0; i < heals.Count; i++)
            {
                if (name == heals[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
