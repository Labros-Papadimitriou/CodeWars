function isValidWalk(walk) {
  if(walk.length === 10) {
    var arr = [0,0,0,0];
    for (var i = 0; i < walk.length; i++) {
      if (walk[i] === 'n') {
        arr[0]++;
      } else if (walk[i] === 's') {
        arr[1]++;
      } else if (walk[i] === 'w') {
        arr[2]++;
      } else if (walk[i] === 'e') {
        arr[3]++;
      }
    }
    if (arr[0] === arr[1] && arr[2] === arr[3]) {
      return true;
    } else {
      return false;
    }
  } else {
    return false;
  }
}
