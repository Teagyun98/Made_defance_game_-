using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;// image class�� ����ϱ� ���ؼ� �߰�
using UnityEngine;

public class Upgrade_Button : MonoBehaviour
{
    public GameObject UpgradeUnit;
    public GameObject Button;
    public GameObject  UpgradeWid;
    public GameObject Wid;
    public Sprite img;

    public void ClickEvent()
    {
        GameManager.instance.SoundManager.GetComponent<SoundManager>().Upgrade.Play();
        GameManager.instance.BlueCost -= 10;
        Button.transform.GetChild(0).GetComponent<Image>().sprite = img; //���׷��̵�� �̹����� ��ȯ
        Button.GetComponent<Unit_Spawn_Button>().SpawnUnit = UpgradeUnit; // Ŭ���� �Ʒ� ��ư�� ���� ������Ʈ�� �ٲ��ش�.
        Destroy(gameObject);
    }

    public void UpWid()
	{
        if (Wid.activeSelf)
        {
            GameManager.instance.SoundManager.GetComponent<SoundManager>().Upgrade.Play();
            Button.transform.GetChild(0).GetComponent<Image>().sprite = img;
            GameManager.instance.BlueCost -= 10;
            Wid.SetActive(false); //  ���� �����縦 ���� ���� �����縦 Ȱ��ȭ
            UpgradeWid.SetActive(true);
            Destroy(gameObject);
        }
    }

    //AI���� ����� ����
    public void ClickEventR()
    {
        GameManager.instance.RedCost -= 10;
        Button.GetComponent<Unit_Spawn_Button>().SpawnUnit = UpgradeUnit; // Ŭ���� �Ʒ� ��ư�� ���� ������Ʈ�� �ٲ��ش�.
        Destroy(gameObject);
    }

    public void UpWidR()
    {
        if (Wid.activeSelf)
        {
            GameManager.instance.RedCost -= 10;
            Wid.SetActive(false); //  ���� �����縦 ���� ���� �����縦 Ȱ��ȭ
            UpgradeWid.SetActive(true);
            Destroy(gameObject);
        }
    }
}