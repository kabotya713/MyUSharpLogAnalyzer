
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace KabotyaWorks
{
    public class SampleClass : UdonSharpBehaviour
    {
        // メンバ変数 ------------------------------------------------------------
        // ToDo:

        // ログ抑制 ------------------------------------------------------------
        private const bool DEF_OUTLEVEL_DEBUG = true;         // デバッグレベルのログ出力
        private const bool DEF_OUTLEVEL_TRACE = true;         // トレースレベルのログ出力

        // 基本処理 ------------------------------------------------------------
        // 開始処理
        void Start()
        {
        }

        // 内部処理 ------------------------------------------------------------
        // デバッグ表示
        private void DebugLog(string level, string format)
        {
            if(level == "INFO")
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=white>Info</color>]: {0}", format ));
            }
            else if(level == "WARNING")
            {
                Debug.LogWarning(string.Format("[<color=cyan>U#</color>]: {0}", format ));
            }
            else if(level == "ERROR")
            {
                Debug.LogError(string.Format("[<color=cyan>U#</color>]: {0}", format ));
            }
            else if(level == "CRITICAL")
            {
                Debug.LogError(string.Format("[<color=cyan>U#</color>][<color=red><b>Critical</b></color>]: {0}", format ));
            }
            else if((level == "DEBUG") && DEF_OUTLEVEL_DEBUG == true)
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=yellow>Debug</color>]: {0}", format ));
            }
            else if(level == "NOTICE")
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=magenta>Notice</color>]: {0}", format ));
            }
            else if((level == "TRACE") && DEF_OUTLEVEL_TRACE == true)
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=blue>Trace</color>]: {0}", format ));
            }
            else if(level == "SUCCESS")
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=#00ff00ff>Success</color>]: {0}", format ));
            }
            else
            {
                Debug.Log(string.Format("[<color=cyan>U#</color>][<color=magenta>NoTag</color>]: {0}", format ));
            }
        }
    }
}