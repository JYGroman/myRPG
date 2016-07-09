using UnityEngine;
using System.Collections;

public class DamageHandler {

  public void DamageTarget(Entity attacker, Entity target, Attack attack) {
    int power = attack.power();

    if (attack.element() == target.Weakness()) {
      power *= 2;
    }

    if (attack.element() == Attack.Element.Physical) {
      power += attacker.attackpower();

      power -= target.defense();
    } else {
      power += attacker.magicpower();

      power -= target.magicdefense();
    }

    if (power < 0) {
      power = 0;
    }

    target.Health(target.Health() - power);
  }
}
