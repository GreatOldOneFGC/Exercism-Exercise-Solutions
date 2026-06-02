class RemoteControlCar(int speed, int batteryDrain)
{
    private int _battery = 100;
    private int _metersDriven = 0;

    public bool BatteryDrained() => _battery < batteryDrain;

    public int DistanceDriven() => _metersDriven;

    public void Drive()
    {
        if (BatteryDrained())
            return;

        _metersDriven += speed;
        _battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack(int distance)
{
    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool racing = true;
        bool finishedRace = false;
        while (racing)
        {
            car.Drive();

            if (car.BatteryDrained())
            {
                racing = false;
            }

            if (car.DistanceDriven() >= distance)
            {
                finishedRace = true;
                racing = false;
            }
        }

        return finishedRace;
    }
}
