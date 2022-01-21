function stepDown(stair, width){
  let result = [];
  function rec(s, w){
  if(s - w < 0){
    return result.unshift(s);
  }
  else{
    result.unshift(s)
    rec(s - w, w)
    }
  }
  rec(stair,width)
  return result;
}
