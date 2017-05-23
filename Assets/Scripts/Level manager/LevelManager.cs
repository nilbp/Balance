using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour {

	[System.Serializable]
	public class Level
	{
		public string LevelText;
		public int UnLocked;
		public bool IsInteractable;

		public Button.ButtonClickedEvent OnClickEvent;
	}

	public GameObject levelButton;
	public Transform Spacer;
	public List<Level> LevelList;


	void Start () 
	{
		DeleteAll ();
		FillList ();

	}

	void FillList()
	{
		foreach (var level in LevelList) {
			GameObject newbutton = Instantiate (levelButton) as GameObject;
			LevelButton button = newbutton.GetComponent<LevelButton> ();
			button.LevelText.text = level.LevelText;

			if (PlayerPrefs.GetInt ("Level" + button.LevelText.text) == 1) {
				level.UnLocked = 1;
				level.IsInteractable = true;
			}

			button.unlocked = level.UnLocked;
			button.GetComponent<Button> ().interactable = level.IsInteractable;
		
			newbutton.transform.SetParent (Spacer);

		}
		SaveAll ();
	}

	void SaveAll()
	{

/*		if (PlayerPrefs.HasKey ("Level 1")) 
		{
			return;
		}

		else*/
			GameObject[] allButtons = GameObject.FindGameObjectsWithTag ("LevelButton");
			foreach (GameObject buttons in allButtons)
			{
				LevelButton button = buttons.GetComponent<LevelButton> ();
				PlayerPrefs.SetInt ("Level" + button.LevelText.text, button.unlocked);
			
			}
	}

	void DeleteAll()
	{
		PlayerPrefs.DeleteAll ();
	}

}
