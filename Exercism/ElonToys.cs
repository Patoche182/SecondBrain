namespace Exercism
{
    class RemoteControlCar
    {
        int distanceRun = 0;
        int batteryLevel = 100;

        // Méthode statique pour acheter une voiture télécommandée
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        // Affiche la distance parcourue
        public string DistanceDisplay()
        {
            return $"Driven {distanceRun} meters";
        }

        // Affiche le niveau de batterie
        public string BatteryDisplay()
        {
            // Si la batterie est à 0%, on affiche "Battery empty"
            if (batteryLevel == 0)
            {
                return "Battery empty";
            }
            return $"Battery at {batteryLevel}%";
        }

        // Méthode pour conduire la voiture
        public void Drive()
        {
            // Vérifie si la batterie est encore chargée
            if (batteryLevel > 0)
            {
                int eachDrive = 20; // Chaque trajet fait avancer la voiture de 20 mètres
                distanceRun += eachDrive; // Ajoute la distance parcourue

                batteryLevel -= 1; // Réduit le niveau de batterie de 1%
            }
            // Si la batterie est à 0%, la voiture ne peut plus avancer (rien ne se passe)
        }
    }
}
/*
Introduction
Classes
The primary object-oriented construct in C# is the class, which is a combination of data (fields) and behavior (methods). The fields and methods of a class are known as its members.

Access to members can be restricted through access modifiers, the two most common ones being:

public: the member can be accessed by any code (no restrictions).
private: the member can only be accessed by code in the same class.
You can think of a class as a template for creating instances of that class. To create an instance of a class (also known as an object), the new keyword is used:

class Car
{
}

// Create two car instances
var myCar = new Car();
var yourCar = new Car();
Fields have a type and can be defined anywhere in a class. Public fields are defined in PascalCase and private fields are defined in camelCase and prefixed with an underscore _:

class Car
{
    // Accessible by anyone
    public int Weight;

    // Only accessible by code in this class
    private string _color;
}
One can optionally assign an initial value to a field. If a field does not specify an initial value, it wll be set to its type's default value. An instance's field values can be accessed and updated using dot-notation.

class Car
{
    // Will be set to specified value
    public int Weight = 2500;

    // Will be set to default value (0)
    public int Year;
}

var newCar = new Car();
newCar.Weight; // => 2500
newCar.Year;   // => 0

// Update value of the field
newCar.Year = 2018;
Private fields are usually updated as a side-effect of calling a method. Such methods usually don't return any value, in which case the return type should be void:

class CarImporter
{
    private int _carsImported;

    public void ImportCars(int numberOfCars)
    {
        // Update private field from public method
        _carsImported = _carsImported + numberOfCars;
    }
}
 * 
 * 
Instructions
In this exercise you'll be playing around with a remote controlled car, which you've finally saved enough money for to buy.

Cars start with full (100%) batteries. Each time you drive the car using the remote control, it covers 20 meters and drains one percent of the battery.

The remote controlled car has a fancy LED display that shows two bits of information:

The total distance it has driven, displayed as: "Driven <METERS> meters".
The remaining battery charge, displayed as: "Battery at <PERCENTAGE>%".
If the battery is at 0%, you can't drive the car anymore and the battery display will show "Battery empty".

You have six tasks, each of which will work with remote controlled car instances.

1. Buy a brand-new remote controlled car
Implement the (static) RemoteControlCar.Buy() method to return a brand-new remote controlled car instance:

RemoteControlCar car = RemoteControlCar.Buy();
2. Display the distance driven
Implement the RemoteControlCar.DistanceDisplay() method to return the distance as displayed on the LED display:

var car = RemoteControlCar.Buy();
car.DistanceDisplay();
// => "Driven 0 meters"
3. Display the battery percentage
Implement the RemoteControlCar.BatteryDisplay() method to return the battery percentage as displayed on the LED display:

var car = RemoteControlCar.Buy();
car.BatteryDisplay();
// => "Battery at 100%"
4. Update the number of meters driven when driving
Implement the RemoteControlCar.Drive() method that updates the number of meters driven:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.DistanceDisplay();
// => "Driven 40 meters"
5. Update the battery percentage when driving
Update the RemoteControlCar.Drive() method to update the battery percentage:

var car = RemoteControlCar.Buy();
car.Drive();
car.Drive();
car.BatteryDisplay();
// => "Battery at 98%"
6. Prevent driving when the battery is drained
Update the RemoteControlCar.Drive() method to not increase the distance driven nor decrease the battery percentage when the battery is drained (at 0%):

var car = RemoteControlCar.Buy();

// Drain the battery
// ...

car.DistanceDisplay();
// => "Driven 2000 meters"

car.BatteryDisplay();
// => "Battery empty"
 */
