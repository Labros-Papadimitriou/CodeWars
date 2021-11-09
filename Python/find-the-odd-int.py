def find_it(seq):
    setting = set(seq)
    for num in list(setting):
        if seq.count(num) % 2 != 0:
            return num
