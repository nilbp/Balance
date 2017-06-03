using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addmoney : MonoBehaviour {
	int totalscore;
	public bool end;
	public GameObject Money;

	void Start () {
		
	}
		
	void Update () {
		totalscore = PlayerPrefs.GetInt ("totalscore");
		if (end){
			Money.GetComponent<Money> ().addMoney (totalscore);
			end = false;

	}
}

}
