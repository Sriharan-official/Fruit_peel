using UnityEngine;


public class Melon : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    
    void Update()
    {
        transform.Rotate(0f,360f * Time.deltaTime,0f);
        
        
    }

    public void Hit(int KeyIndex,float damage)
    {
        if ( KeyIndex < 3 || KeyIndex > 11 )
        {
         
            skinnedMeshRenderer.SetBlendShapeWeight(KeyIndex,100f);
        }
        
        float ColliderHeight = 2.5f;
        float newWeight = skinnedMeshRenderer.GetBlendShapeWeight(KeyIndex) + damage*(100f / ColliderHeight);
        skinnedMeshRenderer.SetBlendShapeWeight(KeyIndex, newWeight);
        

    }
    public void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
