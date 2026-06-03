import gleam/float
import gleam/list
import gleam/result
import gleam/set

pub fn equilateral(a: Float, b: Float, c: Float) -> Bool {
  let #(triangle, triangle_set) = get_list_and_set(a, b, c)
  is_a_triangle(triangle) && set.size(triangle_set) == 1
}

pub fn isosceles(a: Float, b: Float, c: Float) -> Bool {
  let #(triangle, triangle_set) = get_list_and_set(a, b, c)
  is_a_triangle(triangle) && set.size(triangle_set) < 3
}

pub fn scalene(a: Float, b: Float, c: Float) -> Bool {
  let #(triangle, triangle_set) = get_list_and_set(a, b, c)
  is_a_triangle(triangle) && set.size(triangle_set) == 3
}

fn is_a_triangle(triangle: List(Float)) -> Bool {
  float.sum(triangle)
  >. 2.0 *. result.unwrap(list.max(triangle, float.compare), 0.0)
}

fn get_list_and_set(
  a: Float,
  b: Float,
  c: Float,
) -> #(List(Float), set.Set(Float)) {
  let triangle = [a, b, c]
  let triangle_set = set.from_list(triangle)
  #(triangle, triangle_set)
}
