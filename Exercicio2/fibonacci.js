function pertenceFibonacci(numero) {
    let fib = [0, 1];
    while (fib[fib.length - 1] < numero) {
        fib.push(fib[fib.length - 1] + fib[fib.length - 2]);
    }
    if (fib.includes(numero)) {
        console.log(`O número ${numero} pertence à sequência de Fibonacci.`);
    } else {
        console.log(`O número ${numero} não pertence à sequência de Fibonacci.`);
    }
}

let numero = 13;
pertenceFibonacci(numero);
