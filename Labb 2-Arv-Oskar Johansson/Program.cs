namespace Labb_2_Arv_Oskar_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(7,"Willy","Golden","Dog food",30,"Golden Retriver");
            Frog frog = new Frog(3, "Billy", "Green", "Flyes", 0.5, "Billy is jumping");
            Ape ape = new Ape(10, "Chuck", "Brown", "Banana", 40, "Chick is dancing");
            Console.WriteLine("Information on the dog:");
            dog.AnimalInfo();
            dog.breed();
            dog.Walk();
            dog.MakeSound();
            dog.Eat();
            dog.Sleep();
            Console.WriteLine();
            Console.WriteLine("Information on the frog:");
            frog.AnimalInfo();
            frog.MakeSound();
            frog.Eating();
            frog.Eat();
            frog.Sleep();
            Console.WriteLine();
            Console.WriteLine("Information on the ape:");
            ape.AnimalInfo();
            ape.MakeSound();
            ape.Climbing();
            ape.Eat();
            ape.Sleep();
            Console.WriteLine();         
            Rottweiler rottweiler = new Rottweiler(7, "Enna", "Black and a little brown", "Ham", 41,"Enna is runing", "Rottweiler");
            Dachshund dachshund = new Dachshund(1, "Fia", "Black and brown", "Meatballs", 2, "Fia is playing with all her toys", "Dachshund");
            Console.WriteLine("Information on the dachshund:");
            dachshund.AnimalInfo();
            dachshund.breed();
            dachshund.Dig();
            dachshund.MakeSound();
            dachshund.Eat();
            dachshund.Sleep();
            Console.WriteLine();
            Console.WriteLine("Information on the rottweiler:");
            Rottweiler rottweiler1= new Rottweiler(7, "Enna", "Black and a little brown", "Ham", 41,"Enna is runing", "Rottweiler");
            rottweiler.AnimalInfo();
            rottweiler1.breed();
            rottweiler1.TrowFrisbee();
            rottweiler.MakeSound();
            rottweiler.Eat();
            rottweiler.Sleep();

        }
    }
}