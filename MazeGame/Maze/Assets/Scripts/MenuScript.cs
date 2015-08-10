﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button playText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		playText = playText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	
	public void exitPressed() {
		quitMenu.enabled = true;
		playText.enabled = false;
		exitText.enabled = false;
	}

	public void noPressed() {
		quitMenu.enabled = false;
		playText.enabled = true;
		exitText.enabled = true;
	}

	public void startlevel() {
		Application.LoadLevel (1);
	}

	public void exitGame() {
		Application.Quit ();
	}
}