pub fn convert(number: Int) -> String {
  let thousands = number / 1000
  let hundreds = { number - { thousands * 1000 } } / 100
  let tens = { number - { thousands * 1000 } - { hundreds * 100 } } / 10
  let ones = number - { thousands * 1000 } - { hundreds * 100 } - { tens * 10 }

  let thousands = get_number_of_letters(thousands, "M")
  let hundreds = get_letters(hundreds, "C", "D", "M")
  let tens = get_letters(tens, "X", "L", "C")
  let ones = get_letters(ones, "I", "V", "X")

  thousands <> hundreds <> tens <> ones
}

fn get_letters(number: Int, one: String, five: String, ten: String) -> String {
  case number {
    9 -> one <> ten
    4 -> one <> five
    5 -> five
    i if i > 5 -> five <> get_number_of_letters(i - 5, one)
    i if i < 4 -> get_number_of_letters(i, one)
    _ -> ""
  }
}

fn get_number_of_letters(number: Int, letter: String) -> String {
  case number {
    0 -> ""
    _ -> letter <> get_number_of_letters(number - 1, letter)
  }
}
