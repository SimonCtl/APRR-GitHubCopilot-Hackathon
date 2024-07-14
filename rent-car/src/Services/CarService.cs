using System.Collections.Generic;
using System.Threading.Tasks;
using Repositories;

namespace Services
{
    public class CarService : ICarService
    {
        private readonly CarRepository _carRepository;

        public CarService(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // Liste des voitures
        // Liste des voitures par id
        // Supprimer une voiture
        // Mettre à jour une voiture
        // Liste des voitures par couleur
        // Liste des voitures par marque
        // Liste des voitures par modèle
        // Liste des voitures par année
        // Liste des voitures disponibles
        // Liste des voitures ayant moins de 1000 km
        // Liste des voitures rouges
    }
}