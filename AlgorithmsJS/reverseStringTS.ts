function reverseStringTS(input:string) : string {
    let result: string[] = input.split('');

    for(let i:number = 0, j:number = result.length - 1; i < j; i++, j--) {
        result[i] = input[j];
        result[j] = input[i];
    }

    return result.join('');
}

console.log(reverseStringTS('hello world'));
console.log(reverseStringTS('hire me'));