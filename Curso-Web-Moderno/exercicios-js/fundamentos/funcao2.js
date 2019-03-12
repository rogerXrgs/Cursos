//Armazenar função dentro de uma variavel
const imprimirSoma = function (a, b){ return a + b}

console.log(imprimirSoma(4,5));

// Armazenando uma função arrow em uma variável
const soma = (a, b) => {
    return a+b
}

console.log(soma(4, 9))

//Retorno implícito
const subtracao = (a, b) => a-b
console.log(subtracao(19, 8))