namespace rentCar;

public class Car
{

    public long RentalId;

    public string? Brand { get; set; }

    public string? Type { get; set; }

    public int Horses { get; set; }

    public DateOnly RentalStartDate { get; set; }

    public DateOnly RentalEndDate { get; set; }

    public int FuelCharge { get; set; }

    public Boolean extraInsurance { get; set; }
    
}
