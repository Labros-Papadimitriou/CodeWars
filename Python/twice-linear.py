def dbl_linear(n):
    u = [1]
    count_y = 0
    count_z = 0

    while len(u) <= n:
        y = 2 * u[count_y] + 1
        z = 3 * u[count_z] + 1

        if y > z:
            u.append(z)
            count_z += 1
        elif y < z:
            u.append(y)
            count_y += 1
        else:
            u.append(y)
            count_y += 1
            count_z += 1

    return u[n]
    
