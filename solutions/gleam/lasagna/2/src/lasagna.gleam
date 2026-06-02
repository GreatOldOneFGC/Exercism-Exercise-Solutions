const expected_minutes = 40

const minutes_per_layer = 2

const alarm_message = "Ding!"

pub fn expected_minutes_in_oven() -> Int {
  expected_minutes
}

pub fn remaining_minutes_in_oven(actual_minutes: Int) -> Int {
  expected_minutes_in_oven() - actual_minutes
}

pub fn preparation_time_in_minutes(number_of_layers: Int) -> Int {
  number_of_layers * minutes_per_layer
}

pub fn total_time_in_minutes(
  number_of_layers: Int,
  actual_minutes: Int,
) -> Int {
  preparation_time_in_minutes(number_of_layers) + actual_minutes
}

pub fn alarm() -> String {
  alarm_message
}
