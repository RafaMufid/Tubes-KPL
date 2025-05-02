using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tubes_KPL_Kel6.dummydata;

//ini pake enum automata//
namespace Tubes_KPL_Kel6
{
    class battle
    {
        enum State { playerturn, enemyturn, battleOver }

        public static void kondisi() {
            attribut monster = new attribut();
            attribut player = new attribut();
            inventoryPlayer inv = new inventoryPlayer();
            State state = State.playerturn;
            string[] screen = { "playerturn", "enemyturn", "battleOver" };
            inv.addWeapon();
            inv.addHeals();

            while (state != State.battleOver) {
                Console.WriteLine(screen[(int)state]);
                Console.WriteLine("HP player: " + player.getHealth() + " || " + "HP musuh: " + monster.getHealth());
                switch (state) {
                    case State.playerturn:
                        if (state == State.playerturn) {
                            
                            inv.ShowInventory();
                            Console.WriteLine("enter command: ");

                            string input1 = null;
                            do {
                                input1 = Console.ReadLine();
                                Console.WriteLine("");
                                if (input1 == "heal")
                                {
                                    Console.WriteLine("player berhasil diheal");
                                    player.sethealth(attack.getHeal(player.getHealth(), input1));
                                    Console.WriteLine("");
                                    break;
                                }
                                else if (inv.checkWeapon(input1) == false)
                                {
                                    Console.WriteLine("tidak ada item!");
                                    Console.WriteLine("masukkan command lagi");
                                    input1 = null;
                                }

                                
                                if (input1 != null)
                                {
                                    Console.WriteLine("player melakukan serangan " + input1);
                                    monster.sethealth(attack.getDamage(monster.getHealth(), input1));
                                    Console.WriteLine("");
                                }


                            } while (attack.Damage(input1) == 0 || input1 == null);
                            if (monster.getHealth() <= 0)
                            {
                                Console.WriteLine("pertarungan selesai player menang");
                                Console.ReadKey();
                                state = State.battleOver;
                            }
                            else {
                                Console.ReadKey();
                                state = State.enemyturn;
                            }
                        }
                        break;

                    case State.enemyturn:
                        if (state == State.enemyturn) {

                            player.sethealth(attack.enemyDMG(player.getHealth()));
                            Console.WriteLine("");
                            if (player.getHealth() <= 0 )
                            {
                                Console.WriteLine("pertarungan selesai player kalah");
                                Console.ReadKey();
                                state = State.battleOver;
                                
                            }
                            else
                            {
                                Console.ReadKey();
                                state = State.playerturn;
                            }
                        }
                        break;
                }
            }
        }
    }
}
