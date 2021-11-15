function multiply(a, b) {
    let num1 = a.replace(/^0+/, "");
    let num2 = b.replace(/^0+/, "");
    return (BigInt(num1) * BigInt(num2)).toString();
}
