def anagrams(word, words):
    result = []
    for i in words:
        if "".join(sorted(list(i))) == "".join(sorted(list(word))):
            result.append(i)
    return result
  
