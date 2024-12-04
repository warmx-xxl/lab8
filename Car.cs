public class Car
{
    public string CarID { get; set; }
    public string CarName { get; set; }

    public Car(string carID, string carName)
    {
        CarID = carID;
        CarName = carName;
    }

    public override string ToString()
    {
        return $"Car ID: {CarID}, Car Name: {CarName}";
    }
}
