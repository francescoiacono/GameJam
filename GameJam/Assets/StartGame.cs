using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	// Shows the main buttons after the user is ready to start
	public Button startBtn;
	public GameObject workPanel;
	public GameObject statsPanel;
	[HideInInspector]public bool gameStarted;

	// Use this for initialization
	void Start () {
		gameStarted = false;
		workPanel.gameObject.SetActive (false);
		statsPanel.gameObject.SetActive (false);
		startBtn.onClick.AddListener (ShowUI);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowUI() {
		gameStarted = true;
		startBtn.gameObject.SetActive (false);
		workPanel.gameObject.SetActive (true);
		statsPanel.gameObject.SetActive (true);
	}
}
