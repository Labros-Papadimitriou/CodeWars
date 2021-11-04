function evenOrOdd(str) {
    let evens = 0;
    let odds = 0;
    for (var i = 0; i < str.length; i++) {
        if (str[i] % 2 == 0) {
            evens += parseInt(str[i]);
        }
        else if (str[i] % 2 != 0) {
            odds += parseInt(str[i]);
        }
        
    }
    if (evens > odds) {
        return "Even is greater than Odd";
    }
    else if (evens < odds) {
        return "Odd is greater than Even";
    }
    else {
        return"Even and Odd are the same";
    }
}
