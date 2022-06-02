using UnityEngine;

public class Test1 : MonoBehaviour
{
    private void Start()
    {
        //CleaningHouse();
        //StartCoroutine("CleaningHouse");
        Invoke("Test", 3f);
    }

    private void Update()
    {
        Debug.Log((int)Time.time);
        //if (Time.time >= 5f) StopCoroutine("CleaningHouse");
    }

    public void Test()
    {
        Debug.Log("나는 바보다!");
    }
}
