function rowSumOddNumbers(n) {
	let leftStart = 1
  let base = 2;
  let sum = 0;
  for(let i = 1; i < n; i++) {
    leftStart += base * i
  }
  while(n != 0) {
    sum += leftStart + (n-1) * base;
    n--;
  }
  return sum;
}