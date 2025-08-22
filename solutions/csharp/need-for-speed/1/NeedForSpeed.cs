class RemoteControlCar
{
    public int speed;
    private int battery = 100;
    public int batteryDrain;
    private int distance;
    
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if (BatteryDrained() == false) {
            distance = distance + speed;
            battery = battery - batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        var car = new RemoteControlCar(50, 4);
        return car;
    }
}

class RaceTrack
{
    private int distance;
    
    public RaceTrack (int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        if (100 / car.batteryDrain * car.speed >= distance) return true;
        else return false;
    }
}
