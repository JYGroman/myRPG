using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

  private Battle battle;
  private BattleUI battleui;

	void Start () {
    battle = new Battle();

    battleui = new BattleUI(battle);
	}
	
	// Update is called once per frame
	void Update () {
    battle.update();
	}

  void OnGUI() {
    battleui.update();
  }
}
