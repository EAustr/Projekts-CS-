using System;

class Program{
    static void Main (){
        Console.WriteLine("Enter owner's name:");
        string owner = Console.ReadLine();

        Console.WriteLine("Enter flat number:");
        int flat = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of floors:");
        int floors = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter number of people:");
        int people = Convert.ToInt32(Console.ReadLine());

        Flat newFlat = new Flat(owner, flat, floors, people);

        bool running = true;
        while (running){
            Console.WriteLine("");
            Console.WriteLine("Choose an action: \n1. Add Flat\n2. Remove Flat\n3. Add People\n4. Remove People\n5. Add Floors\n6. Remove Floors\n7. Print Flat\n8. Exit");
            string action = Console.ReadLine();
            switch(action) {
                case "1":
                    newFlat.addFlat();
                    break;
                case "2":
                    newFlat.removeFlat();
                    break;
                case "3":
                    newFlat.addPeople();
                    break;
                case "4":
                    newFlat.removePeople();
                    break;
                case "5":
                    newFlat.addFloors();
                    break;
                case "6":
                    newFlat.removeFloors();
                    break;
                case "7":
                    newFlat.printFlat();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}