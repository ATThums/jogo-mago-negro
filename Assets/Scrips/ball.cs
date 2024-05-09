using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float releaseTime = .15f;
    public Vector3 position;
    public Rigidbody2D Hook;
    public float maxDragDistance = 3f;
    public Animator animator;
    public Physics2D explosao;

    public GameObject nextBall;

    private bool isPressed = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mousePos, Hook.position) > maxDragDistance)
                rb.position = Hook.position + (mousePos - Hook.position).normalized * maxDragDistance;
            else
                rb.position = mousePos;
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
        animator.Play("Antes de atirar");
    }

    void OnMouseUp()
    {
        animator.Play("Atirou");
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
        Recomecar.numberOfBall--;

    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(2f);

        nextBall.SetActive(true);

        yield return new WaitForSeconds(20f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CuboMorte")
        {
            Destroy(gameObject);
        }               
    } 
}
