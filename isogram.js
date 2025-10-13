function isIsogram(str) {
  str = str.toLowerCase();
  let chars = str.split("");

  for (let i = 0; i < chars.length; i++) {
    if (chars.indexOf(chars[i]) !== i) {
      return false;
    }
  }
  return true;
}