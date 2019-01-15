import java.util.Scanner;
import java.util.TreeMap;

public class SumsByTown {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int n = Integer.parseInt(scanner.nextLine());
        TreeMap<String, Double> allTowns = new TreeMap<String, Double>();


        for (int i = 0; i < n; i++) {
            String[] input = scanner.nextLine().split("\\|");
            String town = input[0].trim();
            double income = Double.parseDouble(input[1].trim());

            if(allTowns.containsKey(town)) {
                allTowns.put(town, allTowns.get(town) + income);
            }
            else {
                allTowns.put(town, income);
            }
        }

        for(String s : allTowns.keySet()) {
            System.out.println(s + " -> " + allTowns.get(s));
        }

    }
}
