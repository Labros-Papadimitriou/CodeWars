function findOutlier(integers){
  evens = [];
  odds = [];
  count_even = 0;
  count_odd = 0;
  for (let i = 0; i < integers.length; i++) {
    if (integers[i] % 2 == 0) {
      evens.push(integers[i]);
      count_even++;
    }
    else {
      odds.push(integers[i]);
      count_odd++;
    }   
  }
  if (count_even==1) {
    return evens[0];
  }
  else {
    return odds[0];
  }
}
