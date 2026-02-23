using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyScript : MonoBehaviour
{
   public Animator animator;//düşman zombi için animatör.

   bool isSpeed = false;//hızının verilip verilmediğini kontrol eder.
   float s;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
        transform.rotation = Quaternion.Euler( 0, 180, 0);//sprite sheet orjinal olarak sağa baktığı için sola döndür.
        animator.SetInteger("state", 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!isSpeed)//rastgele bir hız verilir.
        {
             s = Random.Range(1.5f, 3.0f);
             isSpeed = true;
        }

         gameObject.transform.Translate(
         new Vector3(s,0f,0f) * Time.deltaTime) ;//sol.

         if (gameObject.transform.position.x <= -11.9)//düşmanı kamera açısından çıkınca sil. 
         {
            Destroy(gameObject);
         }
    

    
    }

    void OnCollisionEnter2D(Collision2D col)//player ile çarpışılırsa menüye dön.
        {
                if(col.gameObject.tag == ("z1") || col.gameObject.tag == ("z2") || col.gameObject.tag == ("z3") || col.gameObject.tag == ("z4")){
                     SceneManager.LoadScene("Start Menu", LoadSceneMode.Single);//menüyü tek olarak yükler, böylece oyun resetlenir.
                }
                  
        }
}
