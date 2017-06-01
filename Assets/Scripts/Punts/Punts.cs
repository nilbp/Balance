using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Punts : MonoBehaviour { 

    

    
    public Text PreScore;
	int ArroundTheWorld;
	int ArroundThePerfecture;
	int Moshikame;
	int ArroundJapan;

	int FirstSteps;
	int TwoColors;
	int Asskick;
	int PinxoMoruno;
	int Bigpoppa;

	int Kay;
	int Lightning;
	int Ellipse;




	public Text Combo;
	public Text multiplier;
	public Text TotScore;

	public int TotalScore = 0;
	public int punts = 0;
	public int multiplicador = 1;


    bool spike = false;
    bool bigCup = false;
    bool smallCup = false;
    bool bottom = false;

	bool print;

	void Start() {




	}

	void Update(){

		EndCombo ();
		BasicCombos ();
		YellowCombos ();
		OrangeCombos ();

		multi ();

		/*Debug.Log (PlayerPrefs.GetInt ("Bigcup"));
		Debug.Log (PlayerPrefs.GetInt ("Smallcup"));
		Debug.Log (PlayerPrefs.GetInt ("Spike"));
		Debug.Log (PlayerPrefs.GetInt ("Bottom"));
		Debug.Log (PlayerPrefs.GetInt ("Body"));*/

	}


		
	void YellowCombos(){


		if(PlayerPrefs.GetInt("Bigcup")== 1 && FirstSteps == 2) {

			punts = punts + 5 *multiplicador;
			StartCoroutine(combo("First Steps " + 5*multiplicador + " points",2));
			FirstSteps = 0;
			PreScore.text = " " + punts;
		}

		if (PlayerPrefs.GetInt ("Smallcup") == 1 && PlayerPrefs.GetInt ("Bigcup") == 1 && TwoColors == 4) 
		{
			//Bottom, Smallcup, BigCup, Bottom
			punts = punts + 20 *multiplicador;
			StartCoroutine(combo("Two Colors " + 20*multiplicador +" points", 2));
			TwoColors = 0;
			PreScore.text = " " + punts;
		
		}
		if (PlayerPrefs.GetInt("Bottom") ==1 && Asskick == 3){

			//Bottom, Bigcup, Spike
			punts = punts + 22 *multiplicador;
			StartCoroutine(combo("Asskick " +18 *multiplicador +" points", 2));
			Asskick = 0;
			PreScore.text = " " + punts;
		}
		if (PlayerPrefs.GetInt ("Spike") == 1 && PlayerPrefs.GetInt("Bottom")==1 && PinxoMoruno == 3) {

			//Spike, Bigcup, Spike
			punts = punts + 40 *multiplicador;
			StartCoroutine(combo("Pinxo Moruno! " + 40*multiplicador + " points", 2));
			PinxoMoruno = 0;
			PreScore.text = " " + punts;		
		}
		if (PlayerPrefs.GetInt ("Body") == 1 && PlayerPrefs.GetInt ("Spike") == 1 && PlayerPrefs.GetInt ("Bottom") == 1 
			&& PlayerPrefs.GetInt ("Smallcup") == 1 && PlayerPrefs.GetInt ("Bigcup")==1 && Bigpoppa == 6) {
		
			//Bigcup, Smallcup, Bottom, Spike, Bigcup, Bottom
			punts = punts + 40 *multiplicador;
			StartCoroutine(combo("BIG POPPA! " +75*multiplicador +" points, +1 multiplicador", 2));
			multiplicador++; 
			Bigpoppa = 0;
			PreScore.text = " " + punts;	
		}
	}

	void OrangeCombos(){
	
		if (PlayerPrefs.GetInt ("Bigcup") == 2 && Kay == 3) {

			//Bigcup, Bottom, Spike
			punts = punts + 22 *multiplicador;
			StartCoroutine(combo("Kay " + 22*multiplicador + " points", 2));
			Kay = 0;
			PreScore.text = " " + punts;	
		}
		if (PlayerPrefs.GetInt ("Smallcup") == 2 && Lightning == 4) {

			//Spike, Smallcup, Bigcup, Bottom
			punts = punts + 10 *multiplicador;
			StartCoroutine(combo("lightning " + 10 *multiplicador + " points, +1 multiplicador", 2));
			multiplicador++;
			Lightning = 0;
			PreScore.text = " " + punts;	
		}
		if (PlayerPrefs.GetInt ("Bottom") == 2 && Ellipse == 6) {

			punts = punts + 50 *multiplicador;
			StartCoroutine(combo("Ellipse " + 50 *multiplicador + " points", 2));
			Ellipse = 0;
			PreScore.text = " " + punts;	

		}
	
	
	}
			

	void multi (){
	
		if (punts > 20 && punts < 100) {
			multiplicador = 2;
		}
		if (punts > 100 && punts < 400) {
			multiplicador = 3;
		}
		if (punts > 400 && punts < 1000) {
			multiplicador = 4;
		}
		if (punts > 1000 && punts < 4000) {
			multiplicador = 5;
		}
		multiplier.text = multiplicador + "x";
	
	}

	void EndCombo(){
	
		if (Input.GetKey (KeyCode.W)) {
		
			TotalScore += punts;
			punts = 0;
			multiplicador = 1;
		}
	
	}

	void BasicCombos()
	{
		if (ArroundTheWorld == 4) {

			//BigCup, SmallCup, Bottom, Spike
			punts = punts + 30*multiplicador;
			StartCoroutine(combo("Arround the world " +25*multiplicador+" points",2));
			ArroundTheWorld = 0;
			PreScore.text = " " + punts;
		}
		if (Moshikame == 4) {

			//BigCup, Bottom, BigCup, BigCup
			punts += 15*multiplicador;
			StartCoroutine(combo("Moshikame "+12*multiplicador+ " points", 2));
			Moshikame = 0;
			PreScore.text = " " + punts;			
		}
		if (ArroundJapan == 3) {
		
			punts += 18*multiplicador;
			StartCoroutine(combo("Arround Japan " +20*multiplicador+" points", 2));
			ArroundJapan = 0;
			PreScore.text = " " + punts;	
		
		}
		if (ArroundThePerfecture == 2) {

			punts += 18*multiplicador;
			StartCoroutine(combo("Arround the perfecture " + 20*multiplicador +" points", 2));
			ArroundThePerfecture = 0;
			PreScore.text = " " + punts;	

		}
	
	}

	IEnumerator combo (string combo,float delay) {
		Combo.text = combo;
		Combo.enabled = true;
		yield return new WaitForSeconds(delay);
		Combo.enabled = false;
	
	}






    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BigCup" && bigCup==false)
        {
			
			FirstSteps++;
			punts+=1*multiplicador;
            spike = false; 
            bigCup = true;
            smallCup = false;
            bottom = false;
			ArroundThePerfecture = 0;
		
			if (ArroundTheWorld == 0) {
				ArroundTheWorld = 1;
			} else {
				ArroundTheWorld = 0;
			}

			if (ArroundJapan == 1) {
			
				ArroundJapan++;	
			} else {
				ArroundJapan = 0;
			}

			if (Moshikame == 2 || Moshikame == 0) {
				Moshikame++;			
			} else {
				Moshikame = 0;
			}
			if (TwoColors == 2) {
				TwoColors = 3;
			} else {
				TwoColors = 0;
			}
			if (Asskick == 1) {
				Asskick = 2;
			} else {
				Asskick = 0;
			}
			if (PinxoMoruno == 1) {
				PinxoMoruno = 2;
			} else {
				PinxoMoruno = 0;
			}
			if (Bigpoppa == 0) {
				Bigpoppa = 1;
			} else if (Bigpoppa == 4) {
				Bigpoppa = 5;
			} else {
				Bigpoppa = 0;
			}
			if (Kay == 0) {
				Kay = 1;
			} else {
				Kay = 0;
			}
			if (Lightning == 2) {
				Lightning = 3;
			} else {
				Lightning = 0;
			}
			if (Ellipse == 2 || Ellipse == 5) {
				Ellipse++;
			} else {
				Ellipse = 0;
			}

        }

        if (other.tag == "Bottom" && bottom==false)
        {
			if (ArroundTheWorld == 2) {
				ArroundTheWorld++;
			} else {
				ArroundTheWorld = 0;
			}
			if (Moshikame == 1 || Moshikame == 3) {
				Moshikame++;
			} else {
				Moshikame = 0;
			}

			if (ArroundThePerfecture == 0 && ArroundTheWorld != 3) {
				ArroundThePerfecture++;
			}
			if (TwoColors == 0 || TwoColors == 3) {
				TwoColors ++;
			} else {
				TwoColors = 0;
			}

			if (Asskick == 0) {
				Asskick = 1;
			} else {
				Asskick = 0;
			}
			if (Bigpoppa == 2) {
				Bigpoppa = 3;
			} 
			else if (Bigpoppa == 5) {
				Bigpoppa = 6;
			} else {
				Bigpoppa = 0;
			}
			if (Kay == 1) {
				Kay = 2;
			} else {
				Kay = 0;
			}
			if (Lightning == 3) {
				Lightning = 4;
			} else {
				Lightning = 0;
			}
			if (Ellipse == 0 || Ellipse == 3) {
				Ellipse++;
			} else {
				Ellipse = 0;
			}


			ArroundJapan = 0;
			FirstSteps = 0;
			PinxoMoruno = 0;
			punts=punts+3*multiplicador;
            spike = false;
            bigCup = false;
            smallCup = false;
            bottom = true;

            

        }

        if (other.tag == "SmallCup" && smallCup ==false)
        {
			if (ArroundTheWorld == 1) {
				ArroundTheWorld++;
			} else {
				ArroundTheWorld = 0;
			}
			if (ArroundJapan == 0) {
				ArroundJapan++;
			} else {
				ArroundJapan = 0;
			}
			if (FirstSteps == 1) {
				FirstSteps++;
			} else {
				FirstSteps = 0;
			}
			if (TwoColors == 1) {
				TwoColors = 2;
			}
			 else {
				TwoColors = 0;
			}if (Bigpoppa == 1) {
				Bigpoppa = 2;
			} else {
				Bigpoppa = 0;
			}
			if (Lightning == 1) {
				Lightning = 2;
			} else {
				Lightning = 0;
			}
			if (Ellipse == 1 || Ellipse == 4) {
				Ellipse++;
			} else {
				Ellipse = 0;
			}


			punts=punts+2*multiplicador;
            spike = false;
            bigCup = false;
            smallCup = true;
            bottom = false;
			Moshikame = 0;
			ArroundThePerfecture = 0;
			PinxoMoruno = 0;

        }

        if (other.tag == "Spike" && spike==false)
        {
			if (ArroundTheWorld == 3) {
				ArroundTheWorld++;
			} else {
				ArroundTheWorld = 0;
			}

			if (ArroundJapan == 2) {
				ArroundJapan = 3;
			} else {
				ArroundJapan = 0;
			}
			if (ArroundThePerfecture == 1) {
				ArroundThePerfecture++;
			} else {
				ArroundThePerfecture = 0;
			}
			if (Asskick == 2) {
				Asskick = 3;
			} else {
				Asskick = 0;
			}
			if (PinxoMoruno == 0) {
				PinxoMoruno = 1;
			} else if (PinxoMoruno == 2) {
				PinxoMoruno = 3;
			} else {
				PinxoMoruno = 0;
			}if (Bigpoppa == 3) {
				Bigpoppa = 4;
			} else {
				Bigpoppa = 0;
			}
			if (Kay == 2) {
				Kay = 3;
			} else {
				Kay = 0;
			}
			if (Lightning == 0) {
				Lightning = 1;
			} else {
				Lightning = 0;
			}

			punts=punts+5*multiplicador;
            spike = true;
            bigCup = false;
            smallCup = false;
            bottom = false;
			Moshikame = 0;
			FirstSteps = 0;
			TwoColors = 0;



        }
        if (other.tag == "floor") {

            punts = 0;
			ArroundTheWorld = 0;
			ArroundJapan = 0;
			ArroundThePerfecture = 0;
			Moshikame = 0;
			FirstSteps = 0;
			Asskick = 0;
			PinxoMoruno = 0;
			multiplicador = 1;

            
        }
        

		PreScore.text = " " + punts;
		TotScore.text = " " + TotalScore;
    }
}

