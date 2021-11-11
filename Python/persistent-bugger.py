from math import prod

def persistence(n):
    total = 1
    count = 0
    if len(str(n)) < 2:
        return 0
    else:    
        while len(str(n)) > 1:
            li = [int(x) for x in str(n)]
            count += 1
            n = prod(li)
    return count
    
