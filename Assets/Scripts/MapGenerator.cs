using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public const int mapSize = 10;
	private int[,] map = new int[mapSize,mapSize];

	[SerializeField] private List<GameObject> cardPrefabs;

	public Card[,] cardMap = new Card[mapSize,mapSize];

	private float cardSize = 1f;
	[SerializeField] private float cardOffset = 0.1f;

	private void Start(){
		cardSize = cardPrefabs[0].GetComponent<SpriteRenderer>().size.x;
		InstantiateMapFromMatrix(map);
	}
	private void InstantiateMapFromMatrix(int[,] map){
		Vector2 initPos = transform.position;
		for(int i = 0; i < mapSize; i++){
			for(int j = 0; j < mapSize; j++){
				var go = Instantiate(cardPrefabs[0],
									initPos+(Vector2.up*j+Vector2.right*i)*(cardSize+cardOffset),
									Quaternion.identity,
									this.gameObject.transform);
				go.name = "card "+i+","+j;
				cardMap[i,j] = go.GetComponent<Card>();
				go.SetActive(false);
			}
		}
	}
}
