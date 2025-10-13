function divisors(integer) {
 let ints = [];
  for(let i = 2; i < integer; i++) {
    if(integer % i == 0) 
    {
     ints.push(i);
    }
  }
  if(ints.length == 0) {
      return integer + " is prime"
    }
   return ints;
}