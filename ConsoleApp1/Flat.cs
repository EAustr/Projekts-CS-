using System;
class Flat{

    public string owner;
    public int flat;
    public int floors;
    public int people;

    public Flat(string owner, int flat, int floors, int people){
        this.owner = owner;
        this.flat = flat;
        this.floors = floors;
        this.people = people;
    }


    // Pievieno dzīvokli, nevar but vairak par 3 dzīvokļiem
    public void addFlat(int flat){
        if (flat >= 5){
            Console.WriteLine("You can't have more than five flats");
        } else if (flat == 0){
            Console.WriteLine("You don't have a flat, flat added!");
            flat++;
        } else {
            Console.WriteLine("You have " + flat + " flats, flat added!");
            flat++;
        }
    }

    public void removeFlat(int flat){
        if (flat == 0){
            Console.WriteLine("You cant have less than 0 flats!");
        } else {
            Console.WriteLine("You have " + flat + " flats, flat removed!");
            flat--;
        }
    }

    // Izvada dzīvokļa īpašnieku, dzīvokļa numuru, stāvus, un cilvēkus
    public void printFlat(){
        Console.WriteLine("Flat owner: " + owner);
        Console.WriteLine("Flats owned: " + flat);
        Console.WriteLine("Floors: " + floors);
        Console.WriteLine("People: " + people);
    }
    
}