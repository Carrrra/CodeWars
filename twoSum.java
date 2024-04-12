public class twoSum {
    public static int[] twoSum(int[] numbers, int target) {
      int[] n = new int[2];
        for(int i = 0; i < numbers.length-1;i++) {
          for(int j = i+1; j < numbers.length; j++) {
            if(numbers[i] + numbers[j] == target) {
              n[0] = i;
              n[1] = j;
              return n;
            }
          }
        }
        return null;
    }


    public static void main (String[] args) {
        int[] numbers = {1234, 5678, 9012};
        int target = 14690;
        int[] n = twoSum(numbers, target);
        System.out.println(n[0] + " " + n[1]);
    }
}