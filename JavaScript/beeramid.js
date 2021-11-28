var beeramid = function(bonus, price) {
  let beersLeft = Math.floor(bonus / price);
  let piles = 0;
  for (let i = 1; i <= beersLeft; i++){
    if (beersLeft - Math.pow(i, 2) >= 0) {
      beersLeft = beersLeft - Math.pow(i, 2);
      piles++;
    }
  }
  return piles;
}
