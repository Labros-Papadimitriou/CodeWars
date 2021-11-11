import copy

def dirReduc(arr: list):
    check = True
    new = copy.deepcopy(arr)
    arr.append(".")
    while check:
        if new != arr:
            new = copy.deepcopy(arr)
            for i in range(len(arr)):
                if (arr[i] == "WEST" and arr[i - 1] == "EAST") or (arr[i] == "EAST" and arr[i - 1] == "WEST") \
                        or (arr[i] == "NORTH" and arr[i - 1] == "SOUTH") or (arr[i] == "SOUTH" and arr[i - 1] == "NORTH"):
                    del arr[i]
                    del arr[i - 1]
                    break
        else:
            check = False
    arr.remove(arr[-1])
    return arr
    
