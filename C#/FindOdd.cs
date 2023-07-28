//6 kyu
//https://www.codewars.com/kata/54da5a58ea159efa38000836  
  
  class Kata
    {
    public static int find_it(int[] seq) 
      {
       int count = 0;
  for(int i = 0; i<seq.Length; i++){
    for(int j = 0; j<seq.Length; j++){
      if(seq[i] == seq[j]){
        count++;
      }
    }
    if(count % 2 != 0 ){
      return seq[i];
    }
  }
      return -1;
      }
       
    }