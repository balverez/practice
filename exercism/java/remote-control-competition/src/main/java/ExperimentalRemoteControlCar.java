public class ExperimentalRemoteControlCar implements RemoteControlCar {
    private final int speed = 20;
    private int distanceTravelled = 0;

    public void drive() {
        distanceTravelled += speed;
    }

    public int getDistanceTravelled() {
        return distanceTravelled;
    }
}
