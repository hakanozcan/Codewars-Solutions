//6 kyu
//https://www.codewars.com/kata/51b62bf6a9c58071c600001b

const hash = {
    1: 'I',
    4: 'IV',
    5: 'V',
    9: 'IX',
    10: 'X',
    40: 'XL',
    50: 'L',
    90: 'XC',
    100: 'C',
    400: 'CD',
    500: 'D',
    900: 'CM',
    1000: 'M',
  };
  
  function solution(number) {
    let result = '';
    let keys = Object.keys(hash).map(x => +x).reverse();
    
    for (const key of keys) {
      while (number >= key) {
        result += hash[key];
        number -= key;
      }
    }
    
    return result;
  }