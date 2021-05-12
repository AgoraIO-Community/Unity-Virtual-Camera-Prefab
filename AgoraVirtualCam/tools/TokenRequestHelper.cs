using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


namespace agora_utilities
{
    [Serializable]
    public class TokenObject
    {
        public string rtcToken;
    }

    public static class TokenRequestHelper
    {
        public static IEnumerator FetchToken(
            string url, string channel, uint userId, Action<string> callback = null
        )
        {
            UnityWebRequest request = UnityWebRequest.Get(string.Format(
              "{0}/rtc/{1}/publisher/uid/{2}/", url, channel, userId
            ));
            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
                callback(null);
                yield break;
            }

            TokenObject tokenInfo = JsonUtility.FromJson<TokenObject>(
              request.downloadHandler.text
            );

            callback(tokenInfo.rtcToken);
        }
    }
}
