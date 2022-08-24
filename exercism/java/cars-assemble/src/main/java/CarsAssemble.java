public class CarsAssemble {
    private static final int baseProduction = 221;
    private static final int minimumSpeed = 1;
    private static final int maximumSpeed = 10;
    private static final int minutes = 60;
    private static final double reliability2 = 0.9D;
    private static final double reliability3 = 0.8D;
    private static final double reliability4 = 0.77D;

    public double productionRatePerHour(int speed) {
        double produced = speed >= minimumSpeed && speed <= maximumSpeed ? baseProduction * speed : 0;
        if (speed < 5) {
            return produced;
        } else if (speed < 9) {
            return produced * reliability2;
        } else if (speed < 10) {
            return produced * reliability3;
        } else if (speed == 10) {
            return produced * reliability4;
        }

        return produced;
    }

    public int workingItemsPerMinute(int speed) {
        return (int) (productionRatePerHour(speed) / minutes);
    }
}
