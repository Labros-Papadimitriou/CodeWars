def duplicate_encode(word: str):
    word = word.lower()
    result = [x for x in word]
    for i in range(len(word)):
        if word.count(word[i]) > 1:
            result[i] = ")"
        else:
            result[i] = "("
    return ''.join(result)
