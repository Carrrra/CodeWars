import java.util.Map;
public class cakes {
     public static int cakes(Map<String, Integer> recipe, Map<String, Integer> available) {
        int max = Integer.MAX_VALUE;

        for (Map.Entry<String, Integer> entry : recipe.entrySet()) {
            String ingredient = entry.getKey();
            int requiredAmount = entry.getValue();

            if (available.containsKey(ingredient)) {
               int maxx = available.get(ingredient) / requiredAmount;
                max = Math.min(maxx,max);
               } else {
                System.out.println("Ingredient not available: " + ingredient + " .No cakes can be baked.");
                return 0;
            }
          }
        return max;
    }

    public static void main(String[] args) {
        // Example usage
        Map<String, Integer> requiredIngredients = Map.of("flour", 500, "sugar", 200, "eggs", 1);
        Map<String, Integer> availableIngredients = Map.of("flour", 1200, "sugar", 1200, "eggs", 5, "milk", 200);

        int cakesPossible = cakes(requiredIngredients, availableIngredients);
        System.out.println("Number of cakes that can be baked: " + cakesPossible);
    }
}