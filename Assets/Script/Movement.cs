using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    float speed = 10.0f;
    public float p_speed = 10.0f;
    int count;
    public TextMeshProUGUI countText;

    void SetCountText()
    {
        countText.text = "Count : " + count.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // Debug.Log(h);

        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }

    // Callbacks function
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹 ����!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� ����!");
        other.gameObject.SetActive(false);
        count = count + 1;
        Debug.Log("count = " + count);
        SetCountText();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ʈ���� �ƿ�");
    }
}
