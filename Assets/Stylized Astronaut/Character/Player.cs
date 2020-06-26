using UnityEngine;

public class Player : MonoBehaviour {

    private Animator anim;
    private Rigidbody rb;
    public float force = 200f;

    void Start () {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponentInChildren<Rigidbody>();
        anim.SetInteger("AnimationPar", 1);
    }

    private void FixedUpdate() {
        if (!IsInGame.isInGame)
            return;

        if(Input.GetMouseButtonDown(0) && transform.localPosition.y <= 0.4f) {
            Jump();
        }

        if(Input.GetTouch(0).phase == TouchPhase.Began && transform.localPosition.y <= 0.4f) {
            Jump();
        }
    }

    void Jump() {
        if (transform.localPosition.y <= 0.4f)
            rb.AddForce(Vector3.up * force);
    }

}
