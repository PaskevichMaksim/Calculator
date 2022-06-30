using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcButton : MonoBehaviour {

	public Text label;

	public RectTransform rectTransform
	{
		get
		{
			if (_rectTransform == null)
				_rectTransform = GetComponent<RectTransform>();
			return _rectTransform;
		}
	}
	RectTransform _rectTransform;

	public Manager calcManager
	{
		get
		{
			if (_calcManager == null)
				_calcManager = GetComponentInParent<Manager>();
			return _calcManager;
		}
	}
	static Manager _calcManager;



	public void onTapped()
	{
		Debug.Log("Tapped: " + label.text);
		calcManager.ButtonTapped(label.text[0]);
	}
}
