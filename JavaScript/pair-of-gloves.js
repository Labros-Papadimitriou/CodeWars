function numberOfPairs(gloves) {
  let pair = 0;
  let count = [];
  for (let color of gloves) {
    if (color in count) {
      count[color]++;
    } 
    else {
      count[color] = 1;
    }
    if (count[color] == 2) {
      pair++;
      count[color] = 0;
    }
  }
  return pair;
}
