import java.util.Arrays;
import java.util.Scanner;

public class LargestThreeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        Arrays.sort(nums);

        int counter = Math.min(3, nums.length);

        for (int i = 0; i < counter; i++) {
            System.out.println(nums[nums.length - i - 1]);
        }
    }
}
