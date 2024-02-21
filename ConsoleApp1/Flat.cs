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

    // Pievieno dzīvokli, nevar but vairak par 5 dzīvokļiem
    public void addFlat(){
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

    public void removeFlat(){
        if (flat == 0){
            Console.WriteLine("You cant have less than 0 flats!");
        } else {
            Console.WriteLine("You have " + flat + " flats, flat removed!");
            flat--;
        }
    }

    public void addPeople(){
        if (people >= 5){
            Console.WriteLine("You can't have more than five people");
        } else if (people == 0){
            Console.WriteLine("You don't have any people, people added!");
            people++;
        } else {
            Console.WriteLine("You have " + people + " people, people added!");
            people++;
        }
    }

    public void removePeople(){
        if (people == 0){
            Console.WriteLine("You cant have less than 0 people!");
        } else {
            Console.WriteLine("You have " + people + " people, people removed!");
            people--;
        }
    }

    public void addFloors(){
        if (floors >= 10){
            Console.WriteLine("You can't have more than 10 floors");
        } else if (floors == 0){
            Console.WriteLine("You don't have any floors, floor added!");
            floors++;
        } else {
            Console.WriteLine("You have " + floors + " floors, floor added!");
            floors++;
        }
    }

    public void removeFloors(){
        if (floors == 0){
            Console.WriteLine("You cant have less than 0 floors!");
        } else {
            Console.WriteLine("You have " + floors + " floors, floor removed!");
            floors--;
        }
    }
}