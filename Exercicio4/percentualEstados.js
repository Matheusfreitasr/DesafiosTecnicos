const faturamentoMensal = {
    "SP": 67836.43,
    "RJ": 36678.66,
    "MG": 29229.88,
    "ES": 27165.48,
    "Outros": 19849.53
};

function calcularPercentual(faturamento) {
    const totalFaturamento = Object.values(faturamento).reduce((acc, val) => acc + val, 0);
    for (let estado in faturamento) {
        const percentual = (faturamento[estado] / totalFaturamento) * 100;
        console.log(`O percentual de ${estado} é: ${percentual.toFixed(2)}%`);
    }
}

calcularPercentual(faturamentoMensal);
