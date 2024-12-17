package day13;

public class ClawMachine {
    private final double aX;
    private final double aY;
    private final double bX;
    private final double bY;
    private final double tX;
    private final double tY;

    public ClawMachine(double aX, double aY, double bX, double bY, double targetX, double targetY) {
        this.aX = aX;
        this.aY = aY;
        this.bX = bX;
        this.bY = bY;
        this.tX = targetX;
        this.tY = targetY;
    }

    public double getaX() {
        return aX;
    }

    public double getbX() {
        return bX;
    }

    public double getaY() {
        return aY;
    }

    public double getbY() {
        return bY;
    }

    public double gettX() {
        return tX;
    }

    public double gettY() {
        return tY;
    }
}
