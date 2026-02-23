using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
        public Animator animator;//player için animatör.

        public GameObject enemy1;//düşmanı 4 zombiden biri olarak spawnlamak için gerekli objeler.
        public GameObject enemy2;
        public GameObject enemy3;
        public GameObject enemy4;
        private GameObject e;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 2.5f);
    }

    void SpawnEnemy()
        {
            
            int x = 0;

            if (gameObject.tag == "z1")//eğer player 1. zombi ise 2., 3., 4. zombileri rastgele spawnla.
            {
                x = Random.Range(1, 4);
                switch(x)
                {
                    case 1:
                    e = Instantiate(enemy2, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    case 2:
                    e = Instantiate(enemy3, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    default:
                    e = Instantiate(enemy4, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;
                }
            }
            else if (gameObject.tag == "z2")//eğer player 2. zombi ise 1., 3., 4. zombileri rastgele spawnla.
            {
                x = Random.Range(1, 4);
                switch(x)
                {
                    case 1:
                    e = Instantiate(enemy1, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    case 2:
                    e = Instantiate(enemy3, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    default:
                    e = Instantiate(enemy4, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;
                }
            }
            else if (gameObject.tag == "z3")//eğer player 3. zombi ise 2., 1., 4. zombileri rastgele spawnla.
            {
                x = Random.Range(1, 4);
                switch(x)
                {
                    case 1:
                    e = Instantiate(enemy1, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    case 2:
                    e = Instantiate(enemy2, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    default:
                    e = Instantiate(enemy4, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;
                }
            }
             else if (gameObject.tag == "z4")//eğer player 4. zombi ise 2., 3., 1. zombileri rastgele spawnla.
            {
                x = Random.Range(1, 4);
                switch(x)
                {
                    case 1:
                    e = Instantiate(enemy1, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    case 2:
                    e = Instantiate(enemy2, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;

                    default:
                    e = Instantiate(enemy3, new Vector3(13.42f, -2.81f), Quaternion.identity);
                    break;
                }
            }
           
            Invoke("Start", 2.5f);
        }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))//zıplama
            {
               Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(0f, 10f);
                
            }

         if ( Input.GetAxisRaw( "Horizontal" ) == 1 ) {
         transform.rotation = Quaternion.Euler( 0, 0, 0);
         animator.SetInteger("state", 1);//sağ
    }
    else if ( Input.GetAxisRaw( "Horizontal" ) == -1 ) {
          transform.rotation = Quaternion.Euler( 0, 180, 0);
          animator.SetInteger("state", 1);//sol
    }

    if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)) 
        {
           animator.SetInteger("state", 0);//duruş
        }
    }

    
}
