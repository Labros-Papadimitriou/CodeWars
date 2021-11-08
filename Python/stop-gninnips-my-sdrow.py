def spin_words(sentence):
    
    words = sentence.split()
    
    result = ""
    for word in words:
        if len(word) < 5:
            result += word + " "
        else:
            result += "".join(list(reversed(word))) + " "
    return result.rstrip()
  
