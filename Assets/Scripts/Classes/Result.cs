using UnityEngine;
using System.Collections;

public class Result {

	int wellPlaced;
	int badPlaced;
	
	public Result () {
		wellPlaced = 0;
		badPlaced = 0;
	}
	
	public int WellPlaced {
		get {
			return wellPlaced;
		}
		set {
			wellPlaced = value;
		}
	}
	
	public int BadPlaced {
		get {
			return badPlaced;
		}
		set {
			badPlaced = value;
		}
	}
}
