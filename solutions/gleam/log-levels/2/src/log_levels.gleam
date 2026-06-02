import gleam/list
import gleam/string

pub fn message(log_line: String) -> String {
  log_line |> string.crop(" ") |> string.trim
}

pub fn log_level(log_line: String) -> String {
  let list = string.split(log_line, ":")
  let first = list.first(list)
  let log = case first {
    Ok(level) -> level
    _ -> ""
  }
  string.lowercase(log)
  |> string.drop_start(1)
  |> string.drop_end(1)
}

pub fn reformat(log_line: String) -> String {
  let start = message(log_line)
  let end = log_level(log_line)
  start <> " (" <> end <> ")"
}
