using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public GameObject[] imgs;
    void Start()
    {
        if (LoadCheck.load)
            StartCoroutine(CloseLoadScreen());
        else
            StartCoroutine(CloseLoadScreenOnNewGame());
    }
    IEnumerator CloseLoadScreen()
    {
        SaveSystem.LoadGame();
        imgs[0].SetActive(true);
        yield return new WaitForSeconds(1f);
        imgs[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        imgs[2].SetActive(true);
        yield return new WaitForSeconds(1f);
        imgs[3].SetActive(true);
        yield return new WaitForSeconds(1f);
        imgs[4].SetActive(true);
        yield return new WaitForSeconds(1f);
        GameController.onLoad = false;
        Destroy(gameObject);
    }
    IEnumerator CloseLoadScreenOnNewGame()
    {
        imgs[0].SetActive(true);
        yield return new WaitForSeconds(.4f);
        imgs[1].SetActive(true);
        yield return new WaitForSeconds(.4f);
        imgs[2].SetActive(true);
        yield return new WaitForSeconds(.4f);
        imgs[3].SetActive(true);
        yield return new WaitForSeconds(.4f);
        imgs[4].SetActive(true);
        yield return new WaitForSeconds(.4f);
        GameController.onLoad = false;
        Destroy(gameObject);
    }
}
