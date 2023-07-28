//6 kyu
//https://www.codewars.com/kata/59c68ea2aeb2843e18000109

function amort(r, b, t, n) {
    r/=1200; var c=r*b/(1-(1+r)**(-t));
    for(let m=1; m<n; m++) b-=(c-r*b);
    return `num_payment ${n.toFixed(0)} c ${c.toFixed(0)} princ ${(c-r*b).toFixed(0)} int ${(r*b).toFixed(0)} balance ${(b-(c-r*b)).toFixed(0)}`;
  }