import gleam/string

pub fn hey(remark: String) -> String {
  let is_question = string.ends_with(string.trim(remark), "?")
  let is_shouting =
    remark == string.uppercase(remark) && remark != string.lowercase(remark)
  let is_empty = string.is_empty(string.trim(remark))

  case is_question, is_shouting, is_empty {
    True, True, _ -> "Calm down, I know what I'm doing!"
    True, False, _ -> "Sure."
    False, True, _ -> "Whoa, chill out!"
    _, _, True -> "Fine. Be that way!"
    False, False, False -> "Whatever."
  }
}
