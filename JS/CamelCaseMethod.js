//6 kyu
//https://www.codewars.com/kata/587731fda577b3d1b0001196

String.prototype.camelCase=function(){
    let arg = this.toString().trim().split(' ');
    let arr = arg.map((v,i,arr)=>v?v.slice(0,1).toUpperCase()+v.slice(1):v);
    return arr.join('');
  }