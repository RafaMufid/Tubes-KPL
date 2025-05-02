using System;

class Program
{
    static void Main()
    {
        var weaponShop = new Shop<Weapon>();
        weaponShop.AddItem(new Weapon { Name = "Pedang Api", Price = 100 });
        weaponShop.AddItem(new Weapon { Name = "Kapak Es", Price = 150 });
        weaponShop.AddItem(new Weapon { Name = "Tombak Petir", Price = 200 });

        var player = new Player(gold: 300);

        while (true)
        {
            Console.WriteLine($"\nGold Player: {player.Gold}");
            weaponShop.ShowItems();

            if (weaponShop.ItemCount == 0)
            {
                Console.WriteLine("Semua item sudah dibeli!");
                break;
            }

            Console.WriteLine("Pilih nomor item yang ingin dibeli (atau ketik 'q' untuk keluar): ");
            var input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Keluar dari toko.");
                break;
            }

            if (int.TryParse(input, out int choice))
            {
                if (choice >= 1 && choice <= weaponShop.ItemCount)
                {
                    var item = weaponShop.GetItem(choice - 1);
                    if (player.Gold >= item.Price)
                    {
                        player.BuyItem(item);
                        weaponShop.RemoveItem(item);
                        Console.WriteLine($"Berhasil membeli {item.Name}!");
                    }
                    else
                    {
                        Console.WriteLine("Uang tidak cukup.");
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }
        }

        Console.WriteLine("\nInventory Akhir:");
        player.Inventory.ShowItems();

        Console.WriteLine("Tekan Enter untuk keluar...");
        Console.ReadLine();
    }
}
