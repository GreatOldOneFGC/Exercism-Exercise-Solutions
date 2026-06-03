pub type Approval {
  Yes
  No
  Maybe
}

pub type Cuisine {
  Turkish
  Korean
}

pub type Genre {
  Crime
  Horror
  Romance
  Thriller
}

pub type Activity {
  BoardGame
  Chill
  Movie(Genre)
  Restaurant(Cuisine)
  Walk(Int)
}

pub fn rate_activity(activity: Activity) -> Approval {
  case activity {
    Movie(genre) -> rate_movie(genre)
    Restaurant(cuisine) -> rate_restaurant(cuisine)
    Walk(distance) -> rate_walk(distance)
    _ -> No
  }
}

fn rate_movie(genre: Genre) -> Approval {
  case genre {
    Romance -> Yes
    _ -> No
  }
}

fn rate_restaurant(cuisine: Cuisine) -> Approval {
  case cuisine {
    Korean -> Yes
    Turkish -> Maybe
  }
}

fn rate_walk(distance: Int) -> Approval {
  case distance {
    i if i > 11 -> Yes
    i if i > 6 -> Maybe
    _ -> No
  }
}
