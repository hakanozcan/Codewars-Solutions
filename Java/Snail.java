//4 kyu
//https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1
import java.util.Arrays;

public class Snail {
  public static final int WALL = -1;

  public static void main(String[] args) {
    // {1,2,3,6,9,8,7,4,5}
    System.out.println(Arrays.toString(snail(new int[][]{{1,2,3},{4,5,6},{7,8,9}})));
  }

  public static int[] snail(int[][] array) {
    if(array[0].length <= 0) { return new int[0]; }

    int n = array.length;
    int[] result = new int[n * n];
    int x = 0,y = 0;
    int xStep = 1,yStep = 0;

    for(int i = 0; i < result.length; ++i) {
      result[i] = array[y][x];
      array[y][x] = WALL;

      x += xStep; y += yStep;

      if(xStep != 0 && (x < 0 || x >= n || array[y][x] == WALL)) {
        x += -xStep; y += xStep;
        yStep = xStep; xStep = 0;
      }
      else if(yStep != 0 && (y < 0 || y >= n || array[y][x] == WALL)) {
        x += -yStep; y += -yStep;
        xStep = -yStep; yStep = 0;
      }
    }

    return result;
  }
}