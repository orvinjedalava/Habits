function reverseStringTS(input) {
    var result = input.split('');
    for (var i = 0, j = result.length - 1; i < j; i++, j--) {
        result[i] = input[j];
        result[j] = input[i];
    }
    return result.join('');
}
console.log(reverseStringTS('hello world'));
console.log(reverseStringTS('hire me'));
