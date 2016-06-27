using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GenerateRandomCombination();
	}
	
	// Update is called once per frame
	void Update () {
	
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
	}
	
	public void ResolveCombination (PawnColor[] colors) {
		for (int i = 0; i < colors.Length; i++) {
			Debug.Log(colors[i].name);
		}
	}
}
