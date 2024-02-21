using System;
using System.Text.RegularExpressions;
class Program{
    static void Main (){
        //Regex, pārbauda vai ievadītā vērtība ir skaitlis vai vārds un lai skaitļa vieta nevaretu but burts vai otradi 
        Regex nameRegex = new Regex("^[a-zA-Z]+$");
        Regex numberRegex = new Regex("^[0-9][0-9]*$");

        Flat[] owners = new Flat[5];


        // Ievadīt dzīvokļa īpašnieka vārdu, dzīvokļa numuru, stāvu skaitu un cilvēku skaitu
        Console.WriteLine("Enter owner's name:");
        string owner = Console.ReadLine();
        while (!nameRegex.IsMatch(owner)){
            Console.WriteLine("Invalid input, please enter a valid name:");
            owner = Console.ReadLine();
        }

        Console.WriteLine("Enter flat number:");
        string flat = Console.ReadLine();
        while (!numberRegex.IsMatch(flat.ToString())){
            Console.WriteLine("Invalid input, please enter a valid number:");
            flat = Console.ReadLine();
        }
        // Pārveido ievadīto dzīvokļa numuru par int
        int flatI = int.Parse(flat);
        
        Console.WriteLine("Enter number of floors:");
        string floors = Console.ReadLine();
        while (!numberRegex.IsMatch(floors.ToString())){
            Console.WriteLine("Invalid input, please enter a valid number:");
            floors = Console.ReadLine();
        }
        // Pārveido ievadīto stāvu skaitu par int
        int floorsI = int.Parse(floors);


        Console.WriteLine("Enter number of people:");
        string people = Console.ReadLine();
        while (!numberRegex.IsMatch(people.ToString())){
            Console.WriteLine("Invalid input, please enter a valid number:");
            people = Console.ReadLine();
        }
        //Pārvieto ievadīto cilvēku skaitu par int
        int peopleI = int.Parse(people.ToString());
        
        //Izveidot dzīvokli
        owners[0] = new Flat(owner, flatI, floorsI, peopleI);
        Flat newFlat = owners[0];
        int currentOwnerIndex = 0;

        //Izvēlēties darbību
        bool running = true;
        while (running){
            Console.WriteLine("");
            Console.WriteLine("Choose an action: \n1.Eddit Flat \n2.Add a new flat \n3.Show all flats \n4.Exit");
            string action = Console.ReadLine();
            switch(action) {
                case "1":
                    Console.WriteLine("Choose an action: \n1.Add flat\n2.Remove flat\n3.Add people\n4.Remove people\n5.Add floors\n6.Remove floors");
                    string action2 = Console.ReadLine();
                    switch(action2) {
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
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                    break;
                case "2":
                    if (currentOwnerIndex >= 4){
                        Console.WriteLine("You can't have more than five flats");
                    } else {
                        currentOwnerIndex++;
                        Console.WriteLine("Enter owner's name:");
                        string owner2 = Console.ReadLine();
                        while (!nameRegex.IsMatch(owner2)){
                            Console.WriteLine("Invalid input, please enter a valid name:");
                            owner2 = Console.ReadLine();
                        }

                        Console.WriteLine("Enter flat number:");
                        string flat2 = Console.ReadLine();
                        while (!numberRegex.IsMatch(flat2.ToString())){
                            Console.WriteLine("Invalid input, please enter a valid number:");
                            flat2 = Console.ReadLine();
                        }
                        int flatI2 = int.Parse(flat2);
                        
                        Console.WriteLine("Enter number of floors:");
                        string floors2 = Console.ReadLine();
                        while (!numberRegex.IsMatch(floors2.ToString())){
                            Console.WriteLine("Invalid input, please enter a valid number:");
                            floors2 = Console.ReadLine();
                        }
                        int floorsI2 = int.Parse(floors2);

                        Console.WriteLine("Enter number of people:");
                        string people2 = Console.ReadLine();
                        while (!numberRegex.IsMatch(people2.ToString())){
                            Console.WriteLine("Invalid input, please enter a valid number:");
                            people2 = Console.ReadLine();
                        }
                        int peopleI2 = int.Parse(people2.ToString());
                        owners[currentOwnerIndex] = new Flat(owner2, flatI2, floorsI2, peopleI2);
                        newFlat = owners[currentOwnerIndex];
                    }
                    break;
                case "3":
                    for (int i = 0; i <= currentOwnerIndex; i++){
                        Console.WriteLine("Owner:" + owners[i].owner + " Flats:" + owners[i].flat + " Floors:" + owners[i].floors + " People:" + owners[i].people);
                    }
                    break;
                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}