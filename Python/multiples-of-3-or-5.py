def solution(number):

    total = []
    multiplier = 1
    while 3 * multiplier < number:
        total.append(3 * multiplier)
        multiplier += 1

    multiplier = 1
    while 5 * multiplier < number:
        total.append(5 * multiplier)
        multiplier += 1

    return sum(set(total))
  
