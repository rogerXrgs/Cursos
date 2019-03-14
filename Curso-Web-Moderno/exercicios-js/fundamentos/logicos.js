function compras(trabalho1, trabalho2) {
  const comprarSoverte = trabalho1 || trabalho2;
  const comprarTv50 = trabalho1 && trabalho2;
  const comprarTv32 = trabalho1 != trabalho2;
  const manterSaudaevel = !comprarSoverte;

  return { comprarSoverte, comprarTv50, comprarTv32, manterSaudaevel };
}

console.log(compras(true, true));

console.log(compras(false, true));

console.log(compras(true, false));

console.log(compras(false, false));
