using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    

        // 충돌이 시작할 때 발생하는 이벤트
        void OnCollisionEnter(Collision coll)
        {
            // 충돌한 게임오브젝트의 태그값 비교
            //if (coll.collider.tag == "BULLET")
            if (coll.collider.CompareTag("BUULET"))
            {
            ContactPoint cp = coll.GetContact(0);

            Quaternion rot = Quaternion.LookRotation(-cp.normal);

            GameObject spark =Instantiate(sparkEffect, coll.transform.position, Quaternion.identity);
            Destroy(spark, 0.5f);    

                // 충돌한 게임오브젝트 삭제
                Destroy(coll.gameObject);
            }
        }     
} 

