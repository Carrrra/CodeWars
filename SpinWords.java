public class SpinWords {

  public String spinWords(String sentence) {
    String[] splits = sentence.split("[ ]");
    int index = 0;
    for(String word : splits) {
      if(word.length() >= 5) {
        splits[index] = new StringBuffer(word).reverse().toString();
      }
      index++; 
    }
    return String.join(" ", splits);
  }
}