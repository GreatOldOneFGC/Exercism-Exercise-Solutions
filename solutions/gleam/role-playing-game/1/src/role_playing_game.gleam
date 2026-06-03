import gleam/option.{type Option, None, Some}

pub type Player {
  Player(name: Option(String), level: Int, health: Int, mana: Option(Int))
}

pub fn introduce(player: Player) -> String {
  case player.name {
    Some(n) -> n
    None -> "Mighty Magician"
  }
}

pub fn revive(player: Player) -> Option(Player) {
  case player.health <= 0 {
    True if player.level >= 10 ->
      Some(Player(player.name, player.level, 100, Some(100)))
    True -> Some(Player(player.name, player.level, 100, player.mana))
    False -> None
  }
}

pub fn cast_spell(player: Player, cost: Int) -> #(Player, Int) {
  case player.mana {
    Some(m) if m >= cost -> #(
      Player(player.name, player.level, player.health, Some(m - cost)),
      cost * 2,
    )
    Some(_) -> #(player, 0)
    None -> {
      let health_cost = player.health - cost
      #(
        Player(
          player.name,
          player.level,
          case health_cost < 0 {
            True -> 0
            False -> health_cost
          },
          player.mana,
        ),
        0,
      )
    }
  }
}
