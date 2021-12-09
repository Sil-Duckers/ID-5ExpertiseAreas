using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneralCodeLV1 : MonoBehaviour
{


    public Transform P1;
    public Transform P2;
    public Transform P3;
    public Transform P4;
    public Transform P5;
    public Transform P6;

    public GameObject Marco;
    public GameObject Lily;
    public GameObject Jeff;
    public GameObject Gunter;
    public GameObject Amanda;
    public GameObject Alice;

    public GameObject Marco2;
    public GameObject Lily2;
    public GameObject Jeff2;
    public GameObject Gunter2;
    public GameObject Amanda2;
    public GameObject Alice2;

    private LineRenderer lineRend; 
    private Vector2 mousePos;
    private Vector2 startMousePos;

    public TextMeshProUGUI GeneralText;

    // Start is called before the first frame update
    void Start()
    {
        GeneralText.text = "Welcome to level 1: User & Society";

        GameObject Marco1 = Instantiate(Marco, P1);
        GameObject Lily1 = Instantiate(Lily, P2);
        GameObject Jeff1 = Instantiate(Jeff, P3);
        GameObject Gunter1 = Instantiate(Gunter, P4);
        GameObject Amanda1 = Instantiate(Amanda, P5);
        GameObject Alice1 = Instantiate(Alice, P6);

        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;

        StartCoroutine(StartGame());

    }


    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(3f);
        GeneralText.text = "Please Match the prompts with the persons";

    }
    
    public void Choice1()
    {
        lineRend.SetPosition(0, new Vector3(-14, 6, 10f));
    }

    public void Choice2()
    {
        lineRend.SetPosition(0, new Vector3(-5, 6, 10f));
    }

    public void Choice3()
    {
        lineRend.SetPosition(0, new Vector3(5, 6, 10f));
    }

    public void Choice4()
    {
        lineRend.SetPosition(0, new Vector3(14, 6, 10f));
    }

    public void MarcoClick()
    {
        lineRend.SetPosition(1, new Vector3(-15, -3, 9f));
        StartCoroutine(MarcoClick2());
        //startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }
    public void LilyClick()
    {
        lineRend.SetPosition(1, new Vector3(-9, -3, 9f));
        StartCoroutine(LilyClick2());
    }
    public void JeffClick()
    {
        lineRend.SetPosition(1, new Vector3(-3, -3, 9f));
        StartCoroutine(JeffClick2());
    }
    public void GunterClick()
    {
        lineRend.SetPosition(1, new Vector3(3, -3, 9f));
        StartCoroutine(GunterClick2());
    }
    public void AmandaClick()
    {
        lineRend.SetPosition(1, new Vector3(9, -3, 9f));
        StartCoroutine(AmandaClick2());
    }
    public void AliceClick()
    {
        lineRend.SetPosition(1, new Vector3(15, -3, 9f));
        StartCoroutine(AliceClick2());
    }

    IEnumerator MarcoClick2()
    {
        Marco2.SetActive(true);
        yield return new WaitForSeconds(3f);
        Marco2.SetActive(false);
        /*mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRend.SetPosition(0, new Vector3(startMousePos.x, startMousePos.y, 0f));
        lineRend.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0f));*/
        
    }

    IEnumerator LilyClick2()
    {
        Lily2.SetActive(true);
        yield return new WaitForSeconds(3f);
        Lily2.SetActive(false);
    }

    IEnumerator JeffClick2()
    {
        Jeff2.SetActive(true);
        yield return new WaitForSeconds(10f);
        Jeff2.SetActive(false);
    }

    IEnumerator GunterClick2()
    {
        Gunter2.SetActive(true);
        yield return new WaitForSeconds(10f);
        Gunter2.SetActive(false);
    }

    IEnumerator AmandaClick2()
    {
        Amanda2.SetActive(true);
        yield return new WaitForSeconds(10f);
        Amanda2.SetActive(false);
    }

    IEnumerator AliceClick2()
    {
        Alice2.SetActive(true);
        yield return new WaitForSeconds(10f);
        Alice2.SetActive(false);
    }

}
