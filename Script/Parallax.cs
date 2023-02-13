using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
	//카메라의 움직임에 따라 원근감을 느낄 수 있도록 배경 오브젝트들이 따라올 수 있게 하기 위한 스크립트
	public float parallaxSpeed; //가까울 수록 0, 멀수록 1에 가깝게 설정한다.
	private void LateUpdate()
	{
		if(GameManager.instance!=null)
		transform.position = new Vector3(GameManager.instance.Camera.transform.position.x*parallaxSpeed, transform.position.y, transform.position.z);
	}
}
