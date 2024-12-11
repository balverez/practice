package day7;

import lombok.Data;

import java.util.List;

public class Equation {
    private final long result;
    private final List<Long> numbers;

    public Equation(long result, List<Long> numbers) {
        this.result = result;
        this.numbers = numbers;
    }

    public long getResult() {
        return result;
    }

    public List<Long> getNumbers() {
        return numbers;
    }
}
