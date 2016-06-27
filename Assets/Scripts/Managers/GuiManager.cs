using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiManager : MonoBehaviour {

	public GameManager gm;
	public Image[] selectionButtons = new Image[4];
	
	private int currentIndex = 0;
	private PawnColor[] currentColors = new PawnColor[4];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void OnColorButtonPressed (PawnColor color) {
		selectionButtons[currentIndex].color = color.colorRgb;
		currentColors[currentIndex] = color;
		if (currentIndex < selectionButtons.Length-1) {
			currentIndex++;
		} else {
			currentIndex = 0;
		}
	}
	
	public void OnSubmitButtonPressed () {
		gm.ResolveCombination(currentColors);
	}
}
