def digital_root(n):
    s = str(n)
    result = 0
    li = []
    if len(s) > 1:
        for digit in s:
            li.append(int(digit))
            result = sum(li)
        return digital_root(result)

    return n
