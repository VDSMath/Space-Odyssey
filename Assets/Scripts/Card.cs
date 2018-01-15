using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
	[SerializeField] private CardData cardData;

	public bool interacted;
	public bool canSee;

	private SpriteRenderer mySR;

	//Canvas
	private GameObject canvas;
	private Text leftNumber;
	private Text rightNumber;

	private void Start(){
		mySR = GetComponent<SpriteRenderer>();

		canvas = transform.GetChild(0).gameObject;
		leftNumber = canvas.transform.GetChild(0).GetComponent<Text>();
		rightNumber = canvas.transform.GetChild(1).GetComponent<Text>();
		
		canvas.SetActive(false);
	}

	public int GetDifficulty(){
		return cardData.difficulty;
	}
	public string GetName(){
		return cardData.title;
	}
	public string GetDescription(){
		return cardData.description;
	}
	public Sprite GetSprite(){
		return cardData.img;
	}
	public GoodEffect GetGoodEffect(){
		return cardData.gEffect;
	}
	public BadEffect GetBadEffect(){
		return cardData.bEffect;
	}

	public void SetOldCard(){
		mySR.color = Color.gray;
	}
	private void AdjustCanvas(){
		leftNumber.text = "0";
		rightNumber.text = GetDifficulty().ToString();
	}
	public void ShowInformation(){
		mySR.sprite = GetSprite();
		AdjustCanvas();
		canvas.SetActive(true);
	}
	private void OnMouseDown(){
		print("show");
		ShowInformation();
	}
}
