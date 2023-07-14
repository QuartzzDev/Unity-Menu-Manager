// QuartzzDev

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public GameObject AnaEkran;
public GameObject AyarlarMenusu;
public GameObject HakkindaMenusu;

public void main2set()
{
    AnaEkran.SetActive(false);
    AyarlarMenusu.SetActive(true);
}

public void set2main()
{
    AnaEkran.SetActive(true);
    AyarlarMenusu.SetActive(false);
}

public void main2cre()
{
    AnaEkran.SetActive(false);
    HakkindaMenusu.SetActive(true);
}

public void cre2main()
{
    AnaEkran.SetActive(true);
    HakkindaMenusu.SetActive(false);
}

public void startGame()
{
    SceneManagement.LoadScene(1); // Buraya Build'de oyununuz hangi rakamdaysa veya isimdeyse onu yazmanız gerek
    //SceneManagement.LoadScene("Oyun"); İsim Olarak Bu Şekilde
}

public void exit()
{
    Application.Quit();
}
