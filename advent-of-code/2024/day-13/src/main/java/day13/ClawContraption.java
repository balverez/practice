package day13;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ClawContraption {
    private List<ClawMachine> clawMachines = new ArrayList<>();

    public ClawContraption(String inputPath, boolean conversionFlag) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            while (scanner.hasNextLine()) {
                String aString = scanner.nextLine();
                String bString = "";
                if (scanner.hasNextLine())
                    bString = scanner.nextLine();
                String prizeString = "";
                if (scanner.hasNextLine())
                    prizeString = scanner.nextLine();

                Pattern xPattern = Pattern.compile("X\\+[0-9]+");
                Matcher xMatcher = xPattern.matcher(aString);
                double aX = 0;
                while (xMatcher.find()) {
                    String xString = xMatcher.group(0);
                    aX = Double.parseDouble(xString.substring(2));
                }

                Pattern yPattern = Pattern.compile("Y\\+[0-9]+");
                Matcher yMatcher = yPattern.matcher(aString);
                double aY = 0;
                while (yMatcher.find()) {
                    String yString = yMatcher.group(0);
                    aY = Double.parseDouble(yString.substring(2));
                }

                xMatcher = xPattern.matcher(bString);
                double bX = 0;
                while (xMatcher.find()) {
                    String xString = xMatcher.group(0);
                    bX = Double.parseDouble(xString.substring(2));
                }

                yMatcher = yPattern.matcher(bString);
                double bY = 0;
                while (yMatcher.find()) {
                    String yString = yMatcher.group(0);
                    bY = Double.parseDouble(yString.substring(2));
                }

                Pattern targetXPattern = Pattern.compile("X=[0-9]+");
                Pattern targetYPattern = Pattern.compile("Y=[0-9]+");
                Matcher targetXMatcher = targetXPattern.matcher(prizeString);
                Matcher targetYMatcher = targetYPattern.matcher(prizeString);
                double targetX = 0;
                while (targetXMatcher.find()) {
                    String targetXString = targetXMatcher.group(0);
                    targetX = Double.parseDouble(targetXString.substring(2))
                            + (conversionFlag
                            ? 10000000000000L
                            : 0);
                }

                double targetY = 0;
                while (targetYMatcher.find()) {
                    String targetYString = targetYMatcher.group(0);
                    targetY = Double.parseDouble(targetYString.substring(2))
                            + (conversionFlag
                            ? 10000000000000L
                            : 0);
                }

                clawMachines.add(new ClawMachine(aX, aY, bX, bY, targetX, targetY ));


                if (scanner.hasNextLine())
                    scanner.nextLine();
            }
        }
    }

    public double optimizeTokens() {
        double optimalTokenCount = 0;
        for (ClawMachine clawMachine : clawMachines) {

            double i = (clawMachine.gettX() * clawMachine.getbY()) - (clawMachine.gettY() * clawMachine.getbX());
            double j = ((clawMachine.getaX() * clawMachine.getbY()) - (clawMachine.getaY() * clawMachine.getbX()));
            double countA = i / j;

            double countB = ((clawMachine.gettX() - (clawMachine.getaX() * countA))
                    / clawMachine.getbX());


            if (countA % 1 == 0
                    && countB % 1 == 0)
                optimalTokenCount += (3 * countA) + countB;
        }

        return optimalTokenCount;
    }
}