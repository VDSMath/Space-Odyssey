using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "cardData",order = 0, menuName = "Custom/CardData")]
public class CardData : ScriptableObject {
	public string title;
	public int difficulty;
	public string description;
	public Sprite img;

	public GoodEffect gEffect = GoodEffect.GAIN_CREW;
	public BadEffect bEffect = BadEffect.LOSE_CREW;
}
public enum GoodEffect{
	NONE,GAIN_CREW, GAIN_OXIGEN
}
public enum BadEffect{
	NONE,LOSE_CREW, LOSE_OXIGEN
}
