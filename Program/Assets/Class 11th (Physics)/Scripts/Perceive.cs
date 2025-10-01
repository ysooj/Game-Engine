using UnityEngine;

public class Perceive : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌 시작");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 끝");

    }
}
