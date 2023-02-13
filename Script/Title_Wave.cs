using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Wave : MonoBehaviour
{

	Rigidbody2D rigid;

    public int waveScale = 10;
	float x = 0f;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		
		Vector2 nextVec = new Vector2(rigid.position.x, rigid.position.y+Mathf.Sin(x) * waveScale*Time.fixedDeltaTime);
		rigid.MovePosition(nextVec);
		
		x+=0.1f;
	}

}
