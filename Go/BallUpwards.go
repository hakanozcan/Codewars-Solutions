//6 kyu
//https://www.codewars.com/kata/566be96bb3174e155300001b

package kata

import "math"

func MaxBall(v0 int) int {
	return int(math.Round(float64(v0) / 3.5316))
}

// package kata

// const g = 9.81

// func MaxBall(v int) int {
// 	for i := 0.0; ; i++ {
// 		if formula(v, i) > formula(v, i+1) {
// 			return int(i)
// 		}
// 	}
// }

// func formula(v int, t float64) float64 {
// 	speed := float64(v)
// 	return 5*speed/18*t/10 - 0.5*g*t*t/100
// }
