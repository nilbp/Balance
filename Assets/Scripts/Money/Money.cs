using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public int money;
	public Text moneytext;

	void Start () {
		//moneytext.text = money;
	}

	public void addMoney (int moneytoadd){
		money += moneytoadd;
		PlayerPrefs.SetInt ("money", money);
	}
}
