class NeedForSpeed {
    private final int carSpeed;
    private final int drainPercentage;
    private int distanceDriven = 0;
    private int batteryRemaining = 100;

    public NeedForSpeed(int carSpeed, int drainPercentage) {
        this.carSpeed = carSpeed;
        this.drainPercentage = drainPercentage;
    }

    public boolean batteryDrained() {
        return batteryRemaining < drainPercentage;
    }

    public int distanceDriven() {
        return distanceDriven;
    }

    public void drive() {
        if (batteryRemaining >= drainPercentage) {
            distanceDriven += carSpeed;
            batteryRemaining -= drainPercentage;
        }
    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50, 4);
    }
}

class RaceTrack {
    private final int distance;

    public RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean tryFinishTrack(NeedForSpeed car) {
        while (!car.batteryDrained())
            car.drive();

        return car.distanceDriven() >= distance;
    }
}
