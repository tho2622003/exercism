class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        var RemoteControlCar = new RemoteControlCar();
        return RemoteControlCar;
    }

    public int distance = 0;
    public int battery = 100;
    
    public string DistanceDisplay()
    {
        string display = $"Driven {distance} meters";
        return display;
    }

    public string BatteryDisplay()
    {
        string display = $"Battery at {battery}%";
        if (battery > 0) return display;
        else return "Battery empty";
    }

    public void Drive()
    {
        if (battery > 0) {
            distance = distance + 20; 
            battery = battery - 1;
        } else distance = distance;
        
    }
}
