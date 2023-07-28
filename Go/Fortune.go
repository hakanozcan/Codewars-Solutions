//6 kyu
//https://www.codewars.com/kata/56445c4755d0e45b8c00010a

package kata

import (
	"math"
)

func Fortune(f0 int, p float64, c0 int, n int, i float64) bool {
	if f0 < 0 || n < 2 {
		return f0 >= 0
	}

	f := float64(f0) + (p / 100 * float64(f0)) - float64(c0)
	c := float64(c0) * (1 + i/100)

	return Fortune(int(math.Floor(f)), p, int(math.Floor(c)), n-1, i)
}

// package kata

// import (
//     "math"
// )

// func Fortune(f0 int, p float64, c0 int, n int, i float64) bool {
//     if f0 < 0 || n == 0 {
//         return false
//     }

//     if n == 1 {
//         return true
//     }

//     f := math.Floor(float64(f0) * (1 + p/100) - float64(c0))
//     c := math.Floor(float64(c0) * (1 + i/100))

//     return Fortune(int(f), p, int(c), n-1, i)
// }
