using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Punts : MonoBehaviour { 

    

    public int punts = 0;
    public Text PreScore;
	public int ArroundTheWorld;
	public int ArroundThePerfecture;
	public int Moshikame;
	public int ArroundJapan;
	public Text Combo;
	public int multiplicador;
	public Text multiplier;
	public Text TotScore;
	public int TotalScore = 0;

    bool spike = false;
    bool bigCup = false;
    bool smallCup = false;
    bool bottom = false;


  	
	void Start() {

		multiplicador = 1;

	}

	void Update(){



		combos ();
		multi ();
		EndCombo ();
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
		multiplier.text = " "+multiplicador+ "x";
	
	}

	void EndCombo(){
	
		if (Input.GetKey (KeyCode.W)) {
		
			TotalScore += punts;
			punts = 0;
			multiplicador = 1;
		}
	
	}

	void combos()
	{
		if (ArroundTheWorld == 4) {

			punts = punts + 25*multiplicador;
			StartCoroutine(combo("Arround the world +25 punts",2));
			ArroundTheWorld = 0;
			PreScore.text = " " + punts;
		}
		if (Moshikame == 4) {

			punts += 12*multiplicador;
			StartCoroutine(combo("Moshikame +12 puntos", 2));
			Moshikame = 0;
			PreScore.text = " " + punts;			
		}
		if (ArroundJapan == 3) {
		
			punts += 18*multiplicador;
			StartCoroutine(combo("Arround Japan +20 puntos", 2));
			ArroundJapan = 0;
			PreScore.text = " " + punts;	
		
		}
		if (ArroundThePerfecture == 2) {

			punts += 18*multiplicador;
			StartCoroutine(combo("Arround the perfecture +20 puntos", 2));
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
			ArroundJapan = 0;
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



        }
        if (other.tag == "floor") {

            punts = 0;
			ArroundTheWorld = 0;
			ArroundJapan = 0;
			ArroundThePerfecture = 0;
			multiplicador = 1;
            
        }
        

		PreScore.text = " " + punts;
		TotScore.text = " " + TotalScore;
    }
}
