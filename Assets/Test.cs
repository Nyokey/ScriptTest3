
using System.Collections.Generic;
using UnityEngine;





public class Test : MonoBehaviour {

	// use this for initialization
	void start () {
		// 要素数５個の配列を初期化する
		int[] array = { 50, 40, 29, 58, 49 };
		// 配列の要素を順番に表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}
	// 配列の要素を逆順に表示する
		for (int p = 0; p >= 0; p--) {
			Debug.Log (array [p]);
		}
	}




			

			// Update is called once per frame
	void Update () {
		
	}
}
