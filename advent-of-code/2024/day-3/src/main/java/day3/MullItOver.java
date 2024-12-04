package day3;

import lombok.Getter;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Arrays;

@Getter
public class MullItOver {
    private final String memorySegment;

    public MullItOver(String inputPath) throws IOException {
        memorySegment = Files.readString(Path.of(inputPath));
    }


    public int mull() {
        return scan(memorySegment);
    }
    
    public int mullWithConditionals() {
        return scanWithConditionals(memorySegment);
    }

    private int scan(String segment) {
        int segmentSum = 0;
        char instructionPrefix = 'm';
        char[] segmentArray = segment.toCharArray();
        for (int i = 0; i < segmentArray.length; i++) {
            char character = segmentArray[i];
            if (character == instructionPrefix) {
                int[] result = verifyInstruction(
                        new String(Arrays.copyOfRange(segmentArray, i, segmentArray.length)));

                segmentSum += result[0];
                i += result[1];
            }
        }

        return segmentSum;
    }

    private int scanWithConditionals(String segment) {
        int segmentSum = 0;
        char instructionPrefix = 'm';
        char conditionalPrefix = 'd';
        boolean instructionsEnabled = true;
        char[] segmentArray = segment.toCharArray();
        for (int i = 0; i < segmentArray.length; i++) {
            char character = segmentArray[i];
            if (instructionsEnabled && character == instructionPrefix) {
                int[] result = verifyInstruction(
                        new String(Arrays.copyOfRange(segmentArray, i, segmentArray.length)));

                segmentSum += result[0];
                i += result[1];
            } else if (character == conditionalPrefix) {
                instructionsEnabled = evaluateConditional(
                        instructionsEnabled,
                        new String(Arrays.copyOfRange(segmentArray, i, segmentArray.length)));
            }
        }

        return segmentSum;
    }

    private int[] verifyInstruction(String segmentPartition) {
        String instructionPrefix = "mul(";
        int prefixPointer = 1;
        char[] prefixArray = instructionPrefix.toCharArray();
        boolean inPrefix = true;

        int firstInt = 0;
        int secondInt;
        boolean inDigits = false;
        int digitPointer = 0;

        char instructionSuffix = ')';
        char delimiter = ',';
        char[] partitionArray = segmentPartition.toCharArray();
        for (int i = 1; i < partitionArray.length; i++) {
            if (inPrefix && prefixArray[prefixPointer] == partitionArray[i]) {
                prefixPointer++;

                if (prefixPointer == instructionPrefix.length()) {
                    inPrefix = false;
                    inDigits = true;
                    digitPointer = i + 1;
                }
            } else if (inDigits && Character.isDigit(partitionArray[i])) {
                continue;
            } else if (inDigits && partitionArray[i] == delimiter) {
                firstInt = Integer.parseInt(
                        new String(Arrays.copyOfRange(partitionArray, digitPointer, i)));

                digitPointer = i + 1;
            } else if (inDigits && partitionArray[i] == instructionSuffix) {
                secondInt = Integer.parseInt(
                        new String(Arrays.copyOfRange(partitionArray, digitPointer, i)));

                return new int[] {firstInt * secondInt, i};
            } else {
                break;
            }
        }

        return new int[] {0, 0};
    }

    private boolean evaluateConditional(boolean currentConditional, String segmentPartition) {
        boolean conditional = currentConditional;

        String enablingConditional = "do()";
        char[] enablingConditionalArray = enablingConditional.toCharArray();
        String disablingConditional = "don't()";
        char[] disablingConditionalArray = disablingConditional.toCharArray();
        int enablingPointer = 1;
        int disablingPointer = 1;

        boolean inEnablingConditonal = true;
        boolean inDisablingConditonal = true;
        char[] partitionArray = segmentPartition.toCharArray();
        for (int i = 1; i < partitionArray.length; i++) {
            if (inEnablingConditonal && enablingConditionalArray[enablingPointer] == partitionArray[i]) {
                enablingPointer++;

                if (enablingPointer == enablingConditional.length()) {
                    conditional = true;

                    return conditional;
                }
            } else {
                inEnablingConditonal = false;
            }

            if (inDisablingConditonal && disablingConditionalArray[disablingPointer] == partitionArray[i]) {
                disablingPointer++;

                if (disablingPointer == disablingConditional.length()) {
                    conditional = false;

                    return conditional;
                }
            } else {
                inDisablingConditonal = false;
            }

            if (!inEnablingConditonal && !inDisablingConditonal) {
                return conditional;
            }
        }

        return conditional;
    }
}