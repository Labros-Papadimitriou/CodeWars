function dblLinear(n) {

    let u = [1];
    let count_y = 0;
    let count_z = 0;

    while (u.length <= n) {
        let y = 2 * u[count_y] + 1
        let z = 3 * u[count_z] + 1
    
        if (y > z) {
            u.push(z)
            count_z += 1
          }
        else if (y < z) {
            u.push(y)
            count_y += 1
          }
        else {
            u.push(y)
            count_y += 1
            count_z += 1
        }
      }
    return u[n]
}
