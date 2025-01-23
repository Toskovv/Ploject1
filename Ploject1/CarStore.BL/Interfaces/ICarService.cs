using CarStore.Models.DTO;

namespace CarStore.BL.Interfaces;

public interface ICarService
{
    IEnumerable<CarModel> GetAllCars();
    CarModel? GetCarById(int id);
    void AddCar(CarModel car);
    void UpdateCar(CarModel car);
    void DeleteCar(int id);
}
