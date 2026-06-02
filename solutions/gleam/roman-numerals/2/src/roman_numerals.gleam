import gleam/string

pub fn convert(number: Int) -> String {
  string.repeat("M", number / 1000)
  <> numeral_split(number % 1000 / 100, "C", "D", "M")
  <> numeral_split(number % 100 / 10, "X", "L", "C")
  <> numeral_split(number % 10, "I", "V", "X")
}

fn numeral_split(number: Int, one: String, five: String, ten: String) {
  case number {
    9 -> one <> ten
    i if i > 4 && i < 9 -> five <> string.repeat(one, number % 5)
    4 -> one <> five
    _ -> string.repeat(one, number)
  }
}
