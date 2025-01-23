using CarStore.Models.DTO;

namespace CarStore.DL.Interfaces;

public interface ICarRepository
{
    IEnumerable<CarModel> GetAllCars();
    CarModel? GetCarById(int id);
    void AddCar(CarModel car);
    void UpdateCar(CarModel car);
    void DeleteCar(int id);
}
