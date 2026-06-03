import gleam/int.{max}
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
      Some(Player(..player, health: 100, mana: Some(100)))
    True -> Some(Player(..player, health: 100))
    False -> None
  }
}

pub fn cast_spell(player: Player, cost: Int) -> #(Player, Int) {
  case player.mana {
    Some(m) if m >= cost -> #(Player(..player, mana: Some(m - cost)), cost * 2)
    Some(_) -> #(player, 0)
    None -> {
      #(Player(..player, health: player.health - cost |> max(0)), 0)
    }
  }
}
