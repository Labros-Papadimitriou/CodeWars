snail = function(array) {
  let size = array.length;
  if (size == 0)
    return [];
  if (size == 1)
    return array[0];
  let top    = array[0].slice(0, -1);
  let right  = array.slice(0, -1).map(a => a[size - 1]);
  let bottom = array[size -1].slice(1).reverse();
  let left   = array.slice(1).map(a => a[0]).reverse();
  let inner  = array.slice(1, -1).map(a => a.slice(1, -1));
  return [].concat(top, right, bottom, left, snail(inner));
  }
