using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToHealthyRecipes()
    {
        SceneManager.LoadScene("HealthyRecipes");
    }
    public void GoToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void GoToScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void GoToMoreInformation()
    {
        SceneManager.LoadScene("MoreInformation");
    }
    public void GoToBreakfastPudding()
    {
        SceneManager.LoadScene("SimpleBreakfastPudding");
    }
    public void GoToCalorieCounter()
    {
        SceneManager.LoadScene("CalorieCounter");
    }
    public void GoToMixedBerrieSmoothie()
    {
        SceneManager.LoadScene("MixedBerrieSmoothie");

    }

    public void GoToTofuStirFry()
    {
        SceneManager.LoadScene("TofuStirFry");
    }

    public void GoToGrilledVegetableWrap()
    {
        SceneManager.LoadScene("GrilledVegetableWrap");
    } 

    public void GoToTurkeyTacoLettuceWraps()
    {
        SceneManager.LoadScene("TurkeyTacoLettuceWraps");
    }

    public void GoToVegetableNoodleSoup()
    {
        SceneManager.LoadScene("VegetableNoodleSoup");
    }

}
