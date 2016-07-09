using UnityEngine;
using System.Collections;

public class Attack {

  private string _name;
  private int _power;
  private Element _element;

  public enum Element {
    Physical,
    Heal,
    Fire,
  }

  public Attack(string nam, int pow, Element ele) {
    _name = nam;
    _power = pow;
    _element = ele;
  }

  public string name() { return _name; }
  public int power() { return _power; }
  public Element element() { return _element; }

}
