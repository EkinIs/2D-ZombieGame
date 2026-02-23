using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
  public Animator animator_z1;// menü animasyonları için animatörler.
  public Animator animator_z2;
  public Animator animator_z3;
  public Animator animator_z4;

  public GameObject MainMenu;

  // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Additive);// menü açılınca arkada oyunda açılır böylece menü BG objesini bulabilir.
    }

public void animStart1()//1. zombi için animasyon başlangıç-bitişleri.
{
    animator_z1.SetBool("pointer_enter", true);
}
    
public void animEnd1()
{
    animator_z1.SetBool("pointer_enter", false);
}

public void animStart2()//2. zombi için animasyon başlangıç-bitişleri.
{
    animator_z2.SetBool("pointer_enter", true);
}

public void animEnd2()
{
    animator_z2.SetBool("pointer_enter", false);
}

public void animStart3()//3. zombi için animasyon başlangıç-bitişleri.
{
    animator_z3.SetBool("pointer_enter", true);
}

public void animEnd3()
{
    animator_z3.SetBool("pointer_enter", false);
}

public void animStart4()//4. zombi için animasyon başlangıç-bitişleri.
{
    animator_z4.SetBool("pointer_enter", true);
}

public void animEnd4()
{
    animator_z4.SetBool("pointer_enter", false);
}

public void z1button()//1. buton için click eventi.
{
     MainMenu.SetActive(false);
     GameObject.Find("BG").GetComponent<backgroundScript>().spawn(1);//BG objesinin, backgroundScriptinin spawn methoduna 1 sayısını göndererek 1. zombiyi spawnlar. 
}

public void z2button()//2. buton için click eventi.
{
     MainMenu.SetActive(false);
     GameObject.Find("BG").GetComponent<backgroundScript>().spawn(2);//BG objesinin, backgroundScriptinin spawn methoduna 2 sayısını göndererek 2. zombiyi spawnlar.
}

public void z3button()//3. buton için click eventi.
{
     MainMenu.SetActive(false);
     GameObject.Find("BG").GetComponent<backgroundScript>().spawn(3);//BG objesinin, backgroundScriptinin spawn methoduna 3 sayısını göndererek 3. zombiyi spawnlar.
}

public void z4button()//4. buton için click eventi.
{
     MainMenu.SetActive(false);
     GameObject.Find("BG").GetComponent<backgroundScript>().spawn(4);//BG objesinin, backgroundScriptinin spawn methoduna 4 sayısını göndererek 4. zombiyi spawnlar.
}


}
