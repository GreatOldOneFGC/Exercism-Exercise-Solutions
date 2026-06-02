pub fn square_of_sum(n: Int) -> Int {
  square(sum(n))
}

pub fn sum_of_squares(n: Int) -> Int {
  case n {
    _ if n <= 1 -> n
    _ -> n * n + sum_of_squares(n - 1)
  }
}

pub fn difference(n: Int) -> Int {
  square_of_sum(n) - sum_of_squares(n)
}

fn sum(n: Int) -> Int {
  case n {
    _ if n <= 0 -> n
    _ -> n + sum(n - 1)
  }
}

fn square(n: Int) -> Int {
  n * n
}
