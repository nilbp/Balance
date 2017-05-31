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

	void Start() {




	}

	void Update(){


		BasicCombos ();
		multi ();
		EndCombo ();
		SpecialCombos ();

		/*Debug.Log (PlayerPrefs.GetInt ("Bigcup"));
		Debug.Log (PlayerPrefs.GetInt ("Smallcup"));
		Debug.Log (PlayerPrefs.GetInt ("Spike"));
		Debug.Log (PlayerPrefs.GetInt ("Bottom"));
		Debug.Log (PlayerPrefs.GetInt ("Body"));*/

	}


		
	void SpecialCombos(){


		if(PlayerPrefs.GetInt("Bigcup")== 1 && FirstSteps == 2) {

			punts = punts + 10 *multiplicador;
			StartCoroutine(combo("First Steps +10 points",2));
			FirstSteps = 0;
			PreScore.text = " " + punts;
		}

		if (PlayerPrefs.GetInt ("Smallcup") == 1 && PlayerPrefs.GetInt ("Bigcup") == 1 && TwoColors == 4) 
		{
			punts = punts + 20 *multiplicador;
			StartCoroutine(combo("Two Colors +20 points", 2));
			TwoColors = 0;
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
		//multiplier.text = multiplicador + "x";
	
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

			punts = punts + 25*multiplicador;
			StartCoroutine(combo("Arround the world +25 points",2));
			ArroundTheWorld = 0;
			PreScore.text = " " + punts;
		}
		if (Moshikame == 4) {

			punts += 12*multiplicador;
			StartCoroutine(combo("Moshikame +12 points", 2));
			Moshikame = 0;
			PreScore.text = " " + punts;			
		}
		if (ArroundJapan == 3) {
		
			punts += 18*multiplicador;
			StartCoroutine(combo("Arround Japan +20 points", 2));
			ArroundJapan = 0;
			PreScore.text = " " + punts;	
		
		}
		if (ArroundThePerfecture == 2) {

			punts += 18*multiplicador;
			StartCoroutine(combo("Arround the perfecture +20 points", 2));
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
			ArroundTheWorld++;
			FirstSteps++;
			punts+=1*multiplicador;
            spike = false; 
            bigCup = true;
            smallCup = false;
            bottom = false;
			ArroundThePerfecture = 0;
		
          	
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
			TwoColors++;
			ArroundJapan = 0;
			FirstSteps = 0;
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
			} else if (TwoColors == 3) {
				TwoColors = 4;
			} else {
				TwoColors = 0;
			}

			punts=punts+2*multiplicador;
            spike = false;
            bigCup = false;
            smallCup = true;
            bottom = false;
			Moshikame = 0;
			ArroundThePerfecture = 0;
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
			multiplicador = 1;
            
        }
        

		PreScore.text = " " + punts;
		TotScore.text = " " + TotalScore;
    }
}
