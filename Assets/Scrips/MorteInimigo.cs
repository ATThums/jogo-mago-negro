using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteInimigo : MonoBehaviour
{
    public float vida = 5f;
    public float damageWoods = 0.45f;
    public float damageStone = 1f;
    public float damageBall = 1.5f;
    public float damageBomb = 3f;
    public float damageGlass = 0.25f;
    public float damageBarril = 1f;

    private bool isDead = false;

    public AudioClip deathSound;
    AudioSource audioSource;

    public GameObject particle;
    public SpriteRenderer meshRederer;
    

    public float time = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        meshRederer.enabled = true;
        audioSource = GetComponent<AudioSource>();
        isDead = false;
        particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Ball")
        {
            vida = vida - damageBall;
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

        if (collision.gameObject.tag == "CuboMorte")
        {
            Recomecar.numberOfEnemies--;
            Destroy(gameObject);            
        }

        if (vida < 0f && isDead == false) 
        {
            
            particle.SetActive(true);
            audioSource.PlayOneShot(deathSound);
            isDead = true;
            StartCoroutine(Release());            
        }      
        
    }

    IEnumerator Release()
    {
        
        Debug.Log("emitiu som");
        meshRederer.enabled = false;
        yield return new WaitForSeconds(time);
        
        Destroy(gameObject);
        Recomecar.numberOfEnemies--;
        Debug.Log(Recomecar.numberOfEnemies);
    }
}
