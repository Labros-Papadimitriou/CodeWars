def pig_it(text):
    changed = ' '.join([word[1:] + word[0] + "ay" for word in text.split(" ") if word.isalpha()])
    if text[-1].isalpha():
        return changed
    else:
        return changed + " " + text[-1]
