def duplicate_count(text):
    li = []
    if len(text) == 0:
        return 0
    else:
        counter = 0
        for letter in text:
            li.append(letter.lower())
        for letter in li:
            if li.count(letter) > 1:
                li = [x for x in li if x != letter]
                counter += 1
    return counter
