function findUniq(arr) {
   return arr.sort().filter((x) => x.match(new RegExp(`[^${arr[1]}]`, 'gi')))[0];
 }
