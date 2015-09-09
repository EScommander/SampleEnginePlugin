using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class SimpleTimer : MonoBehaviour {

	public Text _timerText;
	public Text _startStopButtonLabel;

	private float _timer = 0.0f;
	private bool _isRunning = false;

	private void Start () {
		this._timer = 0.0f;
		this._isRunning = false;
		this._timerText.text = "0";
	}

	private void Update () {
		if (this._isRunning) {
			this._timer += Time.deltaTime;
			this._timerText.text = this._timer.ToString();
		}
	}

	public void ToggleStartStop(){
		this._isRunning = !this._isRunning;

		if (this._isRunning) {
			this._startStopButtonLabel.text = "Stop";
		} else {
			this._startStopButtonLabel.text = "Start";
		}
	}

	public void Reset(){
		this._timer = 0;
		this._timerText.text = "0";
	}
}
