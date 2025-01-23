using CarStore.DL.Interfaces;
using CarStore.Models.DTO;

namespace CarStore.DL.Repositories;

public class CarRepository : ICarRepository
{
    private readonly List<CarModel> _cars = new();

    public IEnumerable<CarModel> GetAllCars() => _cars;

    public CarModel? GetCarById(int id) => _cars.FirstOrDefault(c => c.Id == id);

    public void AddCar(CarModel car) => _cars.Add(car);

    public void UpdateCar(CarModel car)
    {
        var existing = GetCarById(car.Id);
        if (existing != null)
        {
            existing.Brand = car.Brand;
            existing.Model = car.Model;
            existing.Price = car.Price;
        }
    }

    public void DeleteCar(int id) => _cars.RemoveAll(c => c.Id == id);
}
