using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosao : MonoBehaviour
{
    public GameObject bomb;
    public float vida = 1f;
    public float damageWoods = 0.25f;
    public float damageStone = 0.75f;
    public float damageBall = 2f;
    public float damageBomb = 3f;
    public float damageGlass = 0.15f;

    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        explosion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Recomecar.canDamage)
        {
            if (collision.gameObject.tag == "Ball")
            {
                vida = vida - damageBall;
            }

            if (collision.gameObject.tag == "CuboMorte")
            {
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Wood")
            {
                vida = vida - damageWoods;
            }

            if (collision.gameObject.tag == "Bomb")
            {
                vida = vida - damageBomb;
            }

            if (collision.gameObject.tag == "stone")
            {
                vida = vida - damageStone;
            }

            if (collision.gameObject.tag == "Glass")
            {
                vida = vida - damageGlass;
            }

            if (collision.gameObject.tag == "CuboMorte")
            {
                Destroy(gameObject);
            }
        }

        if (vida <= 0f)
        {
            bomb.SetActive(true);
            GetComponent<AudioSource>().Play();

            StartCoroutine(Release());
        }

        
        IEnumerator Release()
        {           
            yield return new WaitForSeconds(0.5f);
            Destroy(gameObject); 
        }
    }
}
