class RemoteControlCar
{
    private int _meters = 0;
    private int _battery = 100;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {_meters} meters";
    public string BatteryDisplay() => _battery > 0 ? $"Battery at {_battery}%" : "Battery empty";

    public void Drive()
    {
        if (_battery <= 0) return;
        _meters += 20;
        _battery--;
    }
}
