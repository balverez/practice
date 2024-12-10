package day6;

import lombok.Builder;
import lombok.Data;

@Data
public class GuardCoordinate {
    int i;
    int j;
    int pivot;


    public GuardCoordinate(int i, int j, int pivot) {
        this.i = i;
        this.j = j;
        this.pivot = pivot;
    }
}
