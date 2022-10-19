using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    Vector3 offset; //distance

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() //모든 업데이트가 실행된 다음 실행
    {
        transform.position = Player.transform.position + offset;
    }
}
