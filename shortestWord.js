function findShort(s){
  let min = "isthisaverylongstringlol";
  
  let words = s.split(" ");
  for(let i = 0; i < words.length; i++) {
    if(words[i].length < min.length) {
      min = words[i];
    } 
  }
  return min.length;
}