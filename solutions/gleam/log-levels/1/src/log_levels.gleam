import gleam/string

pub fn message(log_line: String) -> String {
  let lines = string.split_once(log_line, ":")
  case lines {
    Ok(line) -> string.trim(line.1)
    _ -> ""
  }
}

pub fn log_level(log_line: String) -> String {
  let lines = string.split_once(log_line, "]")
  case lines {
    Ok(line) -> string.lowercase(string.drop_start(line.0, 1))
    _ -> ""
  }
}

pub fn reformat(log_line: String) -> String {
  let start = message(log_line)
  let end = log_level(log_line)
  start <> " (" <> end <> ")"
}
