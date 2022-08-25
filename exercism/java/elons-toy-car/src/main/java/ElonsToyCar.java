public class ElonsToyCar {
    private int metersDriven = 0;
    private int batteryCharge = 100;

    public static ElonsToyCar buy() {
        return new ElonsToyCar();
    }

    public String distanceDisplay() {
        return String.format("Driven %d meters", metersDriven);
    }

    public String batteryDisplay() {
        return batteryCharge != 0
                ? String.format("Battery at %d%%", batteryCharge)
                : "Battery empty";
    }

    public void drive() {
        if (batteryCharge != 0) {
            metersDriven += 20;
            batteryCharge--;
        }
    }
}
