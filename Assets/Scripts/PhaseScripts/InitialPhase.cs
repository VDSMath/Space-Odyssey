using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPhase : MonoBehaviour {
	GameObject player;
	MapGenerator mapGenerator;

	private iVector2 playerPosition;
	private List<iVector2> nearCards;

	private void GetNearCards(){
		nearCards.Add( playerPosition.Add( new iVector2(0,1) ) );
		nearCards.Add( playerPosition.Add( new iVector2(1,0) ) );
		nearCards.Add( playerPosition.Sub( new iVector2(0,1) ) );
		nearCards.Add( playerPosition.Sub( new iVector2(1,0) ) );
	}
	
}
