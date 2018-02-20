using UnityEngine.Experimental.Rendering;

namespace UnityEditor.Experimental.Rendering.HDPipeline
{
    public class HDAdditionalShadowData
    {
        public static void InitDefaultHDAdditionalShadowData(AdditionalShadowData shadowData)
        {
            // Update bias control for HD

            // bias control default value based on empirical experiment
            shadowData.viewBiasMin          = 0.2f;
            shadowData.viewBiasMax          = 10.0f;
            shadowData.viewBiasScale        = 1.0f;
            shadowData.nrmlBiasMin          = 0.5f;
            shadowData.nrmlBiasMax          = 0.5f;
            shadowData.nrmlBiasScale        = 1.0f;
            shadowData.sampleBiasScale      = false;
            shadowData.edgeLeakFixup        = true;
            shadowData.edgeToleranceNrml    = true;
            shadowData.edgeTolerance        = 1.0f;
        }
    }
}
