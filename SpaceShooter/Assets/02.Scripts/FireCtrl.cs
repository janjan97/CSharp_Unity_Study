using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class FireCtrl : MonoBehaviour
{
    //�Ѿ� ������
    public GameObject bullet;

    //�Ѿ� �߻� ��ǥ
    public Transform firePos;

    public AudioClip fireSfx;
    private new AudioSource audio;

    private MeshRenderer muzzleFlash;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        muzzleFlash = firePos.GetComponent<MeshRenderer>();
        muzzleFlash.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� ��ư�� Ŭ������ �� Fire �Լ� ȣ��
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        // Bullet �������� �������� ����( ������ ��ü, ��ġ, ȸ��)
        Instantiate(bullet, firePos.position, firePos.rotation);
        audio.PlayOneShot(fireSfx, 1.0f);
        
        //�ѱ� ȭ��ȿ�� �ڷ�ƾ �Լ� ȣ��
        StartCoroutine(ShowMuzzleFlash());
    }

    IEnumerator ShowMuzzleFlash()
    {
        Vector2 offset = new Vector2(Random.Range(0,2 ), Random.Range(0,2)) * 0.5f;
        muzzleFlash.material.mainTextureOffset = offset;

        // ȸ�� ����
        float angle = Random.Range(0, 360);
        muzzleFlash.transform.localRotation = Quaternion.Euler(0, 0, angle);

        float scale = Random.Range(1.0f, 2.0f);
        muzzleFlash.transform.localScale = Vector3.one * scale;

        muzzleFlash.enabled = true;

        yield return new WaitForSeconds(0.2f);

        muzzleFlash.enabled = false;
    }
}
