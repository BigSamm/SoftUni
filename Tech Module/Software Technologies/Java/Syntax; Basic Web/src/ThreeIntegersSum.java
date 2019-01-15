import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int num1 = scanner.nextInt();
        int num2 = scanner.nextInt();
        int num3 = scanner.nextInt();

        if(num1 + num2 == num3) {
            System.out.printf("%d + %d = %d%n", Math.min(num1, num2), Math.max(num1, num2), num3);
        }
        else if(num1 + num3 == num2) {
            System.out.printf("%d + %d = %d%n", Math.min(num1, num3), Math.max(num1, num3), num2);
        }
        else if(num2 + num3 == num1) {
            System.out.printf("%d + %d = %d%n", Math.min(num2, num3), Math.max(num2, num3), num1);
        }
        else {
            System.out.println("No");
        }
    }
}
