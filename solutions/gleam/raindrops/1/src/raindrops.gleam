import gleam/int

pub fn convert(number: Int) -> String {
  case is_divisible(number) {
    False -> int.to_string(number)
    True -> {
      pling(number) <> plang(number) <> plong(number)
    }
  }
}

fn pling(number: Int) -> String {
  case number % 3 == 0 {
    True -> "Pling"
    False -> ""
  }
}

fn plang(number: Int) -> String {
  case number % 5 == 0 {
    True -> "Plang"
    False -> ""
  }
}

fn plong(number: Int) -> String {
  case number % 7 == 0 {
    True -> "Plong"
    False -> ""
  }
}

fn is_divisible(number: Int) -> Bool {
  number % 3 == 0 || number % 5 == 0 || number % 7 == 0
}
