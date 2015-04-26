using UnityEngine;
using System.Collections.Generic;

public interface IAgility {
	
	IList<Vector2> calculate (PowerChangePhase phase, Vector2 change);



}

public enum PowerChangePhase {
	INC=1, CST=2, DEC=3
}
