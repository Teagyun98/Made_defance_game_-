using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cost_Bar : MonoBehaviour
{
	private void Update() // ��������� �ڽ�Ʈ ��
	{
		transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2((float)GameManager.instance.BlueCost/10*150, 10f);
		transform.GetChild(1).GetComponent<Text>().text = GameManager.instance.BlueCost.ToString();
		transform.GetChild(2).GetComponent<Text>().text = GameManager.instance.BlueCost.ToString();
	}
}
