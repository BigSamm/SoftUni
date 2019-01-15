import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            if(String.valueOf(i).equals(new StringBuilder(String.valueOf(i)).reverse().toString())) {
                System.out.println(i + " ");
            }
        }
    }
}
