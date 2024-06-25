function reverseString(input) {
    var result = input.split('');
    for (var i = 0, j = result.length - 1; i < j; i++, j--) {
        result[i] = input[j];
        result[j] = input[i];
    }
    return result.join('');
}
console.log(reverseString('hello world'));
console.log(reverseString('hire me'));
