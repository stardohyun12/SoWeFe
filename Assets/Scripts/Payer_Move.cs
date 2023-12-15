using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Payer_Move : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D rigid;
    public Animator animator;
    private float Castingtime=0.5f;
    private float countTime;
    
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        
        if(rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if
        (rigid.velocity.x < maxSpeed * (-1)) 
            rigid.velocity = new Vector2(maxSpeed * (-1),rigid.velocity.y);
    
        if(Input.GetButtonUp("Horizontal")){
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        if(h >0 || h<0)
        {
            animator.SetBool("isRuning", true);
        }
        else
            animator.SetBool("isRuning", false);


        if(Input.GetKeyDown(KeyCode.K))
        {
            
            Castingtime = 1f;
            countTime =0;
            countTime +=Time.deltaTime;
            if(Castingtime >0)
            {
                Castingtime -=Time.deltaTime;
                
                
                
            }
            animator.SetTrigger("Atk1");
            
            
            
        }

    }

    void FixedUpdate()
    {
        
        
        

    }
}
