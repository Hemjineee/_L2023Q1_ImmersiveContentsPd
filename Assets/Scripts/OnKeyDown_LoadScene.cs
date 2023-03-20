using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnKeyDown_LoadScene : MonoBehaviour
{
    [Tooltip("���� �ٲ� Ű�� ����")]
    public string Key;

    [Tooltip("�� ������ �Ҵ�")]
    public Object SceneFile;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(vKey))
                {
                    //your code here
                    print(vKey);
                    if (vKey.ToString().ToLower() == Key.ToString().ToLower())
                    {
                        print("got the key");
                        SceneManager.LoadScene(SceneFile.name);
                    }
                }
            }
        }
    }
}
