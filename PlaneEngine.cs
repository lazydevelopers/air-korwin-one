using UnityEngine;
using System.Collections.Generic;

public class PlaneEngine : MonoBehaviour {
	private IAgility thruster;

	// Use this for initialization
	void Start () {
		thruster = new PlaneAgility ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}


class PlaneAgility : IAgility {
	public IList<Vector2> calculate(PowerChangePhase phase, Vector2 change) {
		return new List<Vector2>();
	}
}
