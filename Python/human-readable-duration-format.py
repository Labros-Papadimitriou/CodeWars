def format_duration(sec):
    value = ''
    time = [31536000, 86400, 3600, 60, 1]
    unit = [' years',' days',' hours',' minutes',' seconds']
    i = 0
    count = 0
    if sec == 0: return 'now'
    while sec > 0:
        if sec//time[i] > 1:
            if sec%time[i] > 0:
                value += str(sec//time[i]) + unit[i] + ', '
            elif sec%time[i] == 0 and count > 0:
                value = value.strip()[:-1] + ' and ' + str(sec//time[i]) + unit[i]
            else:
                value += str(sec//time[i]) + unit[i]
            count += 1
        if sec//time[i] == 1:
            if sec%time[i] > 0:
                value += str(sec//time[i]) + unit[i][:-1] + ', '
            elif sec%time[i] == 0 and count > 0:
                value = value.strip()[:-1] + ' and ' + str(sec//time[i]) + unit[i][:-1]
            else:
                value += str(sec//time[i]) + unit[i][:-1]
            count += 1
        sec = sec%time[i]
        i+=1
    return value
  
