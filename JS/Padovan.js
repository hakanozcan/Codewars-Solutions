//6 kyu
//https://www.codewars.com/kata/5803ee0ed5438edcc9000087

function padovan(n) {
    let arr = [1,1,1]
    for (let i=2;i<n;i++){
      arr.push(arr[i-1]+arr[i-2])
    }
    return arr[n]
}