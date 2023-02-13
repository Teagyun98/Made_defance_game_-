using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Condition : MonoBehaviour
{
	BoxCollider2D col;

	public List<GameObject> UnitList;
	public ParticleSystem destroyPar;
	public string baseType;
	public Sprite HitImg;
	public Sprite norImg;
	public Sprite GameOverImg;

	private void Awake()
	{
		col = GetComponent<BoxCollider2D>();
	}

	public void TakeDamage(float Attack) //�� ������ ������ �Լ�
	{
		if (baseType == "Blue")
		{
			col.enabled = false;
			GameManager.instance.BlueHealth -= (int)Attack;
			StartCoroutine(ChangeHitImage());
			if(GameManager.instance.BlueHealth <= 0)
			{
				StopAllCoroutines();
				transform.GetComponent<SpriteRenderer>().sprite = GameOverImg;
				GameManager.instance.GameOver = "BlueDie";
				GameManager.instance.End();
			}
			col.enabled = true;
		}
		else if (baseType == "Red")
		{
			col.enabled = false;
			GameManager.instance.RedHealth -= (int)Attack;
			StartCoroutine(ChangeHitImage());
			if (GameManager.instance.RedHealth <= 0)
			{
				StopAllCoroutines();
				transform.GetComponent<SpriteRenderer>().sprite = GameOverImg;
				GameManager.instance.GameOver = "RedDie";
				GameManager.instance.End();
			}
			col.enabled = true;
		}
	}

	IEnumerator ChangeHitImage()
	{
		transform.GetComponent<SpriteRenderer>().sprite = HitImg;
		Instantiate(destroyPar, transform.position, Quaternion.identity);
		yield return new WaitForSeconds(0.1f);
		transform.GetComponent<SpriteRenderer>().sprite = norImg;
	}
}