using Microsoft.AspNetCore.Mvc;
using CarStore.BL.Interfaces;
using CarStore.Models.DTO;

namespace CarStore.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet]
    public IActionResult GetAllCars() => Ok(_carService.GetAllCars());

    [HttpGet("{id}")]
    public IActionResult GetCarById(int id)
    {
        var car = _carService.GetCarById(id);
        return car != null ? Ok(car) : NotFound();
    }

    [HttpPost]
    public IActionResult AddCar(CarModel car)
    {
        _carService.AddCar(car);
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateCar(CarModel car)
    {
        _carService.UpdateCar(car);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCar(int id)
    {
        _carService.DeleteCar(id);
        return Ok();
    }
}
