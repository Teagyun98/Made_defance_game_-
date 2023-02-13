using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
	public float MoveSpeed;

	private int moveCheck = 0;

	public void MoveRight()
	{
		moveCheck = 1; //오른쪽 이동 버튼 누를 시 1
	}
	public void MoveLeft()
	{
		moveCheck = 2; //왼쪽 이동 버튼 누를 시 2
	}
	public void MoveStop()
	{
		moveCheck = 0; //버튼에서 손을 때면 0
	}

	private void FixedUpdate()
	{
		Vector3 vec = GameManager.instance.Camera.transform.position;
		if (vec.x < 2 && moveCheck==1) //이동 조건과 카메라 이동 범위 만족시 실행
		{
			GameManager.instance.Camera.transform.position = new Vector3(vec.x + MoveSpeed, vec.y, vec.z);
		}
		if (vec.x > -2 && moveCheck == 2)
		{
			GameManager.instance.Camera.transform.position = new Vector3(vec.x - MoveSpeed, vec.y, vec.z);
		}
	}
}