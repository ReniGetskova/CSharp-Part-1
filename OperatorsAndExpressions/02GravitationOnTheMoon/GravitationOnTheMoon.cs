using System;

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitationOnTheMoon
{
    // use formula G = m * g, G is mesured in newtons
    //where m is weight, g is gravitational acceleration, G is force of weight
    // 1N ~ 9,8kg
    static void Main()
    {
        double earthGravitation = 9.8;
        double moonGravitation = earthGravitation * (17.0 / 100.0);
        Console.WriteLine("Insert your weight in kilograms");
        string takeWeight = Console.ReadLine();
        double weight = double.Parse(takeWeight);
        while (weight < 1 || weight > 200)
        {
            Console.WriteLine("Insert your weight in kilograms");
            takeWeight = Console.ReadLine();          
        }
        double forceOfWeight = weight * moonGravitation;
        // convert in kilograms
        forceOfWeight /= 9.8;
        Console.WriteLine("In the moon your weight will be: {0} kilograms", forceOfWeight);
    }
}
