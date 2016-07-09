using UnityEngine;
using System.Collections;

public class Entity {

  private string name;
  public string Name() { return name; }

  private int level;
  public int Level() { return level; }

  private int healthpoints;
  public int Health() { return healthpoints; }
  public void Health(int hp) { healthpoints = hp; }

  private int magicpoints;
  public int MP() { return magicpoints; }

  private int strength;
  private int agility;
  private int vitality;
  private int intelligence;
  private int mind;

  private Attack attack;

  private Attack[] actions = new Attack[0];

  private Status status;

  private Attack.Element weakness;
  public Attack.Element Weakness() { return weakness; }

  public Entity(string nam, int lv, int hp, int mp, int str, int agi, int vit, int ing, int mnd, Attack.Element weak) {
    name = nam;
    level = lv;
    healthpoints = hp;
    magicpoints = mp;
    strength = str;
    agility = agi;
    vitality = vit;
    intelligence = ing;
    mind = mnd;
    weakness = weak;

    attack = new Attack("Attack", attackpower(), Attack.Element.Physical);
  }

  public void newaction(Attack action) {
    Attack[] newactions = new Attack[actions.Length + 1];

    for (int i = 0; i < actions.Length; i++) {
      newactions[i] = actions[i];
    }

    newactions[actions.Length] = action;

    actions = newactions;

  }

  public void LevelUp() {

  }

  public int attackpower() {
    int power = 0;
    power += strength / 4;
    return power;
  }

  public int accuracy() {
    int acc = 0;
    acc += agility / 4;
    acc += level;
    return acc;
  }

  public int defense() {
    int def = 0;
    def += vitality / 2;
    return def;
  }

  public int evasion() {
    int evs = 0;
    evs += agility / 4;
    return evs;
  }

  public int magicpower() {
    int power = 0;
    power += intelligence / 4;
    power += mind / 4;
    return power;
  }

  public int magicaccuracy() {
    int acc = 0;
    acc += intelligence / 4;
    acc += mind / 4;
    return acc;
  }

  public int magicdefense() {
    int def = 0;
    def += intelligence / 4;
    def += mind / 4;
    return def;
  }
}
