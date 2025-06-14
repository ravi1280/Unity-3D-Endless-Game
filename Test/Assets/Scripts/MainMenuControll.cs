using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControll : MonoBehaviour
{
    [SerializeField] GameObject fadeOut;
    [SerializeField] GameObject bounceText;
    [SerializeField] GameObject bigButton;
    [SerializeField] GameObject animCam;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject menuControls;
    public static bool hasClicked;
    [SerializeField] GameObject staticCam;


    void Start()
    {
        if (hasClicked == true)
        {

            staticCam.SetActive(true);
            animCam.SetActive(false);
            menuControls.SetActive(true);
            bounceText.SetActive(false);
            bigButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuBigenButton()
    {
        StartCoroutine(AnimCam());
    }

    public void StartGame()
    {

        StartCoroutine(StartButton());
    }

    IEnumerator StartButton()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);

    }

    IEnumerator AnimCam()
    {
        animCam.GetComponent<Animator>().Play("AnimMenuCam");
        bounceText.SetActive(false);
        bigButton.SetActive(false);

        yield return new WaitForSeconds(1.5f);
        mainCam.SetActive(true);
        animCam.SetActive(false);
        menuControls.SetActive(true);

        hasClicked = true;


    }
}
