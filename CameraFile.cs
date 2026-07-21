using Unity.Cinemachine;
using UnityEngine;

namespace Bagel
{
    public class PlayCamera : MonoBehaviour
    {
        [SerializeField] PlayManager m_PlayManager;

        [Header("Virtual Cameras")]
        [SerializeField] CinemachineCamera m_MainMenuCamera;
        [SerializeField] CinemachineCamera m_MainMenuSecondaryCamera;
        [SerializeField] CinemachineCamera m_BagelSelectionCamera;
        [SerializeField] CinemachineCamera m_PlayCamera; 

        PlayManagerState m_State;

        public float fieldOfView
        {
            get => m_MainMenuCamera.Lens.FieldOfView;
            set => UpdateFieldOfView(value);
        } 

        void UpdateFieldOfView(float newFOV)
        { 
            m_MainMenuSecondaryCamera.Lens.FieldOfView = newFOV;
            m_PlayCamera.Lens.FieldOfView = newFOV;
        }
 
    }
}