/*
 * Used to control clicks on the churn button
 * The bar fills as you click the button, then resets back to 0
 * The targeted bar and number of taps can be set
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChurnButtonController : MonoBehaviour {
	// The number of taps it takes to entirely fill the butter bar
	public float NumberOfTapsToFill = 500;

	// The fill bar
	public Image ChurnBar;

	// The number of times the player has tapped the button
	private float numberOfTaps = 0;

	// The action that is called each time the button is pressed
	// Increases the bar fill
	// The length of the bar fill wraps back to 0 at numberOfTapsToFill
	public void Churn () {
		numberOfTaps++;

		// Sets the amount the bar is filled
		ChurnBar.fillAmount = (numberOfTaps%(NumberOfTapsToFill+1))/NumberOfTapsToFill;
	}
}
