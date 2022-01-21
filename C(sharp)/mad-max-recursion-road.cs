function max(array) {
  if(array.length == 0 ){
    return -Infinity;
  }
  else if(array.length == 1){
    return array[0];
  }
  else if(array.length >= 2){
    if(array[0] <= array[1]){
      array.splice(0,1);
      return max(array);
    }
    else{
      array.splice(1,1);
      return max(array);
    }
  }
}
