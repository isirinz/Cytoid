using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrapper : MonoBehaviour
{
    public Splash splash;
    
    private async void Awake()
    {
        if (Context.Distribution == Distribution.TapTap)
        {
            await splash.Display();
        }
        SceneManager.LoadScene("Navigation");
    }
    
}    