using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class comprarparts : MonoBehaviour {

	/*public class level{
		public int unlocked;
		public bool isinsteractable;*/
	public int money;
	//public Image Image;
	public Button bigcupgroc1;
	public Button smallcupgroc1;
	public Button bottomgroc1;
	public Button spikegroc1;
	public Button bodygroc1;

	public Button bigcuptronja1;
	public Button smallcuptronja1;
	public Button bottomtronja1;
	public Button spiketronja1;
	public Button bodytronja1;

	public Button bigcuplila1;
	public Button smallcuplila1;
	public Button bottomlila1;
	public Button spikelila1;
	public Button bodylila1;

	void Start () {
		
		money = PlayerPrefs.GetInt ("money");

		Button btn = bigcupgroc1.GetComponent<Button>();
		btn.onClick.AddListener(bigcupgroc);
		Button btnn = smallcupgroc1.GetComponent<Button>();
		btnn.onClick.AddListener(smallcupgroc);
		Button btnnn = bottomgroc1.GetComponent<Button>();
		btnnn.onClick.AddListener(bottomgroc);
		Button btnnnn = spikegroc1.GetComponent<Button>();
		btnnnn.onClick.AddListener(spikegroc);
		Button btnnnnn = bodygroc1.GetComponent<Button>();
		btnnnnn.onClick.AddListener(bodygroc);

		Button bttn = bigcuptronja1.GetComponent<Button>();
		bttn.onClick.AddListener(bigcuptronja);
		Button btttn = smallcuptronja1.GetComponent<Button>();
		btttn.onClick.AddListener(smallcuptronja);
		Button bttttn = bottomtronja1.GetComponent<Button>();
		bttttn.onClick.AddListener(bottomtronja);
		Button btttttn = spiketronja1.GetComponent<Button>();
		btttttn.onClick.AddListener(spiketronja);
		Button bttttttn = bodytronja1.GetComponent<Button>();
		bttttttn.onClick.AddListener(bodytronja);

		Button bbtn = bigcuplila1.GetComponent<Button>();
		bbtn.onClick.AddListener(bigcuplila);
		Button bbbtn = smallcuplila1.GetComponent<Button>();
		bbbtn.onClick.AddListener(smallcuplila);
		Button bbbbtn = bottomlila1.GetComponent<Button>();
		bbbbtn.onClick.AddListener(bottomlila);
		Button bbbbbtn = spikelila1.GetComponent<Button>();
		bbbbbtn.onClick.AddListener(spikelila);
		Button bbbbbbtn = bodylila1.GetComponent<Button>();
		bbbbbbtn.onClick.AddListener(bodylila);

	}
	// Update is called once per frame
	void Update () {

	}
	//preu parts grogues
	void bigcupgroc(){

		if (money>=20) {
			Levelunlocked ();
		} else {
			Levellocked ();
		}
	}
	void smallcupgroc(){

		if (money>=30) {
			Levelunlocked1 ();
		} else {
			Levellocked1 ();
		}
	}
	void bottomgroc(){

		if (money>=40) {
			Levelunlocked2 ();
		} else {
			Levellocked2 ();
		}
	}
	void spikegroc(){

		if (money>=50) {
			Levelunlocked3 ();
		} else {
			Levellocked3 ();
		}
	}
	void bodygroc(){

		if (money>=60) {
			Levelunlocked4 ();
		} else {
			Levellocked4 ();
		}
	}




	//preu parts tronjes

	void bigcuptronja(){

		if (money>=80) {
			Levelunlocked5();
		} else {
			Levellocked5 ();
		}
	}
	void smallcuptronja(){

		if (money>=90) {
			Levelunlocked6();
		} else {
			Levellocked6 ();
		}
	}
	void bottomtronja(){

		if (money>=100) {
			Levelunlocked7();
		} else {
			Levellocked7 ();
		}
	}
	void spiketronja(){

		if (money>=110) {
			Levelunlocked8();
		} else {
			Levellocked8 ();
		}
	}
	void bodytronja(){

		if (money>=120) {
			Levelunlocked9();
		} else {
			Levellocked9 ();
		}
	}

	//preu parts liles
	void bigcuplila(){

		if (money>=140) {
			Levelunlocked10 ();
		} else {
			Levellocked10 ();
		}
	}
	void smallcuplila(){

		if (money>=160) {
			Levelunlocked11 ();
		} else {
			Levellocked11 ();
		}
	}
	void bottomlila(){

		if (money>=180) {
			Levelunlocked12 ();
		} else {
			Levellocked12 ();
		}
	}
	void spikelila(){

		if (money>=190) {
			Levelunlocked13 ();
		} else {
			Levellocked13 ();
		}
	}
	void bodylila(){

		if (money>=200) {
			Levelunlocked14 ();
		} else {
			Levellocked14 ();
		}
	}

	//grocs
void Levellocked()
{
		bigcupgroc1.GetComponent<Button> ().interactable = false;
	//Image.enabled = true;
}
void Levelunlocked ()
{
		bigcupgroc1.GetComponent<Button> ().interactable = true;
	//Image.enabled = false;
}
	void Levellocked1()
	{
		smallcupgroc1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked1 ()
	{
		smallcupgroc1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked2()
	{
		bottomgroc1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked2 ()
	{
		bottomgroc1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked3()
	{
		spikegroc1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked3 ()
	{
		spikegroc1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked4()
	{
		bodygroc1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked4 ()
	{
		bodygroc1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}

	//tronjes

	void Levellocked5()
	{
		bigcuptronja1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked5 ()
	{
		bigcuptronja1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked6()
	{
		smallcuptronja1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked6 ()
	{
		smallcuptronja1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}void Levellocked7()
	{
		bottomtronja1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked7 ()
	{
		bottomtronja1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}void Levellocked8()
	{
		spiketronja1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked8 ()
	{
		spiketronja1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}void Levellocked9()
	{
		bodytronja1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked9 ()
	{
		bodytronja1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}

	//liles
	void Levellocked10()
	{
		bigcuplila1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked10 ()
	{
		bigcuplila1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked11()
	{
		smallcuplila1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked11 ()
	{
		smallcuplila1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked12()
	{
		bottomlila1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked12 ()
	{
		bottomlila1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked13()
	{
		spikelila1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked13 ()
	{
		spikelila1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}
	void Levellocked14()
	{
		bodylila1.GetComponent<Button> ().interactable = false;
		//Image.enabled = true;
	}
	void Levelunlocked14 ()
	{
		bodylila1.GetComponent<Button> ().interactable = true;
		//Image.enabled = false;
	}

}