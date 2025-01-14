const faturamento = {
    "SP": 67836.43,
    "RJ": 36678.66,
    "MG": 29229.88,
    "ES": 27165.48,
    "Outros": 19849.53
};

function calcularFaturamento(faturamento) {
    const valores = Object.values(faturamento);
    const total = valores.reduce((acc, val) => acc + val, 0);
    const media = total / valores.length;

    const menorFaturamento = Math.min(...valores);
    const maiorFaturamento = Math.max(...valores);

    const diasAcimaDaMedia = valores.filter(val => val > media).length;

    console.log(`Menor faturamento: R$ ${menorFaturamento}`);
    console.log(`Maior faturamento: R$ ${maiorFaturamento}`);
    console.log(`Número de dias acima da média: ${diasAcimaDaMedia}`);
}

calcularFaturamento(faturamento);
