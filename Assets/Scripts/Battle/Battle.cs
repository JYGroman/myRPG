using UnityEngine;
using System.Collections;

public class Battle {

  private DamageHandler damagehandler;

  private Entity knight;
  private Entity slime;

  private Entity[] _playerparty;
  private Entity[] _enemyparty;

  public Entity[] playerparty() { return _playerparty; }
  public Entity[] enemyparty() { return _enemyparty; }

  private UpdateMenu[] updatemenu;

  private Commands selected;
  public Commands Selected() { return selected; }

  private Menu menu;

  public enum Commands {
    Attack,
    Skill,
    Defend,
    Total
  }

  public enum Menu {
    Select,
    Action,
    Target,
    Total
  }

  delegate void BattleVoids();
  delegate void UpdateMenu();

  public Battle () {
    damagehandler = new DamageHandler();

    BattleVoids[] voids = new BattleVoids[(int)Commands.Total];
    updatemenu = new UpdateMenu[(int)Menu.Total];
    updatemenu[0] = commandselect;

    ///////////// Test Entity Creator //////////////////
    Attack attack = new Attack("Slash", 10, Attack.Element.Physical);

    knight = new Entity("Knight", 1, 32, 8, 11, 11, 11, 11, 11, Attack.Element.Fire);
    slime = new Entity("Cthulu", 99, 666, 666, 666, 666, 666, 666, 666, Attack.Element.Fire);

    knight.newaction(attack);

    _playerparty = new Entity[] { knight };
    _enemyparty = new Entity[] { slime };
    ///////////// Test Entity Creator //////////////////
  }

  public void update() {
    updatemenu[(int)menu]();
  }

  private void commandselect() {
    int next = (int)selected;

    if (Input.GetKeyUp(KeyCode.W)) {
      next  = (int)selected - 1;
    } else if (Input.GetKeyUp(KeyCode.S)) {
      next = (int)selected + 1;
    }

    if (next < 0) {
      next = (int)Commands.Total - 1;
    } else if (next == (int)Commands.Total) {
      next = 0;
    }

    selected = (Commands)next;
  }
	
}
