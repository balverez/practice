public class SalaryCalculator {
    private final double BASE_SALARY = 1000D;

    public double multiplierPerDaysSkipped(int daysSkipped) {
        return daysSkipped > 5 ? 0.85D : 1D;
    }

    public int multiplierPerProductsSold(int productsSold) {
        return productsSold > 20 ? 13 : 10;
    }

    public double bonusForProductSold(int productsSold) {
        return productsSold * multiplierPerProductsSold(productsSold);
    }

    public double finalSalary(int daysSkipped, int productsSold) {
        double finalSalary = (BASE_SALARY * multiplierPerDaysSkipped(daysSkipped)) + bonusForProductSold(productsSold);
        return Math.min(finalSalary, 2000D);
    } 
}
