function getCount(str) {
  let vowels = ["a","e","i","o","u"]
  let chars = str.split('')
  let vowelCount = 0;
  for(let i = 0; i < chars.length; i++) {
    if(vowels.includes(chars[i])) {
      vowelCount++;
    }
  }
  return vowelCount;
}