using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundScript : MonoBehaviour
{
        public GameObject exitButton;

        public GameObject zombie1;//playerı 4 zombiden biri olarak spawnlamak için gerekli objeler.
        public GameObject zombie2;
        public GameObject zombie3;
        public GameObject zombie4;
        private GameObject z;

        Vector3 startPos;//arka planın başlangıç noktası.
        float repeatWidth;//arka planın tekrarlanacağı uzunluk.

    // Start is called before the first frame update
    void Start()
    {
        exitButton.SetActive(false);//exit butonu ana menüde gözükmesin diye görünmez başlar.
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x /3;//tekrarlama uzunluğu arka planın colliderının 3'e bölümüne eşittir (3 tane background sprite'i var. Yani 3'e bölmek bize tam merkezi verir.)
    }

    // Update is called once per frame
    void Update()
    {
         if ( Input.GetAxisRaw( "Horizontal" ) == -1 ) {
     gameObject.transform.Translate(
         new Vector3(3.0f,0f,0f) * Time.deltaTime //sağ.
         );
         
    }
    else if ( Input.GetAxisRaw( "Horizontal" ) == 1 ) {
     gameObject.transform.Translate(
         new Vector3(-3.0f,0f,0f) * Time.deltaTime //sol.
         );
       
    }

    if(transform.position.x < startPos.x - repeatWidth || transform.position.x > startPos.x + repeatWidth )//Eğer arka plan tekrarlama uzunluğunu sağa veya sola doğru geçmişse arka planı başlangıç pozisyonuna al.
    {
       transform.position = startPos;
    }

    
    }

    public void spawn(int x)//menüden gelen parametrelere göre playerı seçilen zombi olarak spawnlar.
    {
        exitButton.SetActive(true);

        if(x == 1)
        {
            z = Instantiate(zombie1,  new Vector2(-0.25f, -2.81f), Quaternion.identity);
        }
        else if(x == 2)
        {
            z = Instantiate(zombie2,  new Vector2(-0.25f, -2.81f), Quaternion.identity);
        }
        else if(x == 3)
        {
            z = Instantiate(zombie3,  new Vector2(-0.25f, -2.81f), Quaternion.identity);
        }
        else if(x == 4)
        {
            z = Instantiate(zombie4,  new Vector2(-0.25f, -2.81f), Quaternion.identity);
        }
         
    }

    public void ExitButton()//exit butonu için click eventi.
    {
         SceneManager.LoadScene("Start Menu", LoadSceneMode.Single);//menüyü tek olarak yükler, böylece oyun resetlenir.
    }
}
