using UnityEngine;
using System.Collections;

public class Combination {
	
	PawnColor[] colors;

	public Combination (PawnColor[] colors) {
		this.colors = colors;
	}
	
	public bool matchAtIndex (int index, PawnColor color) {
		bool match = false;

		if (colors[index] == color) {
			match = true;
		} else if (colors[index] == null) {
			Debug.Log("Requesting NULL : " + color.name + " at " + index);
		}
		
		return match;
	}
	
	public PawnColor[] Colors {
		get {
			return colors;
		}
	}
}
