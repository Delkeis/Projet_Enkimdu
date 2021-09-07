using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAi : MonoBehaviour
{
    private float Distance;
    //private Animation animations;
    private Animator Anim;

    public Transform Target;
    public UnityEngine.AI.NavMeshAgent agent;

    public float chaseRange = 10;
    public float attackRange = 2.2f;
    public float attackRepeat = 1;
    public float attackTime;
    public float attackDammage;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        Anim = gameObject.GetComponent<Animator>();
        //animations = gameObject.GetComponent<Animation>();
        attackTime = Time.time;

    }

    void Update()
    {
        Target = GameObject.Find("Player").transform;
        Distance = Vector3.Distance(Target.position, transform.position);
        if (Distance > chaseRange){
            Idle();
        }
        if (Distance < chaseRange && Distance > attackRange){
            Chase();
        }
        if (Distance < chaseRange && Distance < attackRange){
            Attack();
        }
    }

    void Chase()
    {
        //animations.Play("Z_Walk");
        Anim.SetBool("Run", true);
        Anim.SetBool("Idle", false);
        agent.destination = Target.position;
    }
    void Idle()
    {
        Anim.SetBool("Run", false);
        Anim.SetBool("Idle", true);
        //animations.Play("Z_Idle");
    }
    void Attack()
    {
        agent.destination = transform.position;

        if (Time.time > attackTime){
            Anim.SetTrigger("Attack");
            //animations.Play("Z_Attack");
            Target.GetComponent<Health>().ApplyDammage(attackDammage);
            Debug.Log("L'ennemi a envoyé "+ attackDammage + "points de dégâts");
            attackTime = Time.time + attackRepeat;
        }
    }

}
