using UnityEngine;
using System.Collections;

public class BattleUI {

  private Battle battle;
  private Vector2 statussize;
  private Vector2 statuspos;

  public BattleUI(Battle battle_) {
    battle = battle_;
  }

  public void update() {
    statussize = new Vector2(Screen.width * 0.3f, Screen.height * 0.2f);
    statuspos = new Vector2(Screen.width * 0f, Screen.height * 0f);
    Rect statusbox = new Rect(statuspos, statussize);

    GUI.Box(statusbox, battle.enemyparty()[0].Name() + "\nHP " + battle.enemyparty()[0].Health() + "\tMP " + battle.enemyparty()[0].MP());

    statuspos.x = Screen.width * 0.7f;
    statusbox.position = statuspos;
    GUI.Box(statusbox, battle.playerparty()[0].Name() + "\nHP " + battle.playerparty()[0].Health() + "\tMP " + battle.playerparty()[0].MP());

    GUI.Box(new Rect(Screen.width * 0f, Screen.height * 0.8f, Screen.width * 0.7f, Screen.height * 0.2f), "");

    string battleoptions = "";
    for (int i = 0; i < (int)Battle.Commands.Total; i++) {
      battleoptions += (Battle.Commands)i;

      if (i == (int)battle.Selected()) {
        battleoptions += " <";
      }

      battleoptions += "\n";
    }

    GUI.Box(new Rect(Screen.width * 0.7f, Screen.height * 0.8f, Screen.width * 0.3f, Screen.height * 0.2f), battleoptions);
  }
}
