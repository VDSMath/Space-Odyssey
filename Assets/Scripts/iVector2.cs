using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iVector2 {
	public int x,y;
	public iVector2(int a, int b){
		x = a;
		y = b;
	}
	public iVector2 Add(iVector2 a){
		this.x += a.x;
		this.y += a.y;
		return this;
	}
	public iVector2 Sub(iVector2 a){
		this.x -= a.x;
		this.y -= a.y;
		return this;
	}
}
