using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GuiManager guiM;
	
	private Combination secret;

	// Use this for initialization
	void Start () {
		GenerateRandomCombination();
	}
	
	void GenerateRandomCombination () {
		PawnColor[] allColors = Resources.LoadAll<PawnColor>("Data/");
		PawnColor[] selectedColors = new PawnColor[4];
		for (int i = 0; i < 4; i++) {
			int rgn = Random.Range(0, allColors.Length);
			if (rgn < allColors.Length) {
				selectedColors[i] = allColors[rgn];
				Debug.Log(selectedColors[i].name);
			}
		}
		
		secret = new Combination(selectedColors);
	}
	
	public void ResolveCombination (PawnColor[] colors) {
		Result result = new Result();
		PawnColor[] secretCopy = new PawnColor[4];
		PawnColor[] colorsCopy = new PawnColor[4];
		
		// Init copies
		for (int i = 0; i < secret.Colors.Length; i++) {
			secretCopy[i] = secret.Colors[i];
			colorsCopy[i] = colors[i];
			
		}
		
		// Well placed
		for (int i = 0; i < colorsCopy.Length; i++) {
			if (colorsCopy[i] != null && secret.matchAtIndex(i, colorsCopy[i])) {
				result.WellPlaced++;
				secretCopy[i] = null;
				colorsCopy[i] = null;
			}
		}
		
		// Bad placed
		for (int i = 0; i < colorsCopy.Length; i++) {
			for (int j = 0; j < secretCopy.Length; j++) {
				if (colorsCopy[i] != null && secretCopy[j] != null && secret.matchAtIndex(j, colorsCopy[i])) {
					result.BadPlaced++;
					secretCopy[j] = null;
					colorsCopy[i] = null;
				}
			}
		}
		
		guiM.DisplayResult(result);
		
		if (result.WellPlaced == 4) {
			OnWin();
		}
	}
	
	private void OnWin () {
		Debug.Log("VICTOOOOOOOOOOOOOORYYYYYYYYYYYYYY");
	}
}
