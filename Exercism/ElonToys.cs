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