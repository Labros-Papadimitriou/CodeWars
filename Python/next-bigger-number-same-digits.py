def next_bigger(number):
    backup = number
    if list(str(backup)) == list(reversed(sorted(str(number)))):
        return -1
    other = number + 9
    while sorted(str(number)) != sorted(str(other)):
        other += 9
    return other
  
