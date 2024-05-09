using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woods : MonoBehaviour
{

    public float vida = 3;
    public float damageWoods = 0.45f;
    public float damageStone = 1f;
    public float damageBall = 1.5f;
    public float damageBomb = 3f;
    public float damageGlass = 0.25f;
    public float damageBarril = 1f;

    public GameObject particles;
    public SpriteRenderer meshRederer;
    

    // Start is called before the first frame update
    void Start()
    {
        particles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {            
            StartCoroutine(Release());
        }
    }

    IEnumerator Release()
    {


        if (vida <= 0)
        {
            particles.SetActive(true);
            meshRederer.enabled = false;
            yield return new WaitForSeconds(0.4f);

            Destroy(gameObject);
        }
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

            if (collision.gameObject.tag == "Barril")
            {
                vida = vida - damageBarril;
            }
        }        
    }
    
}