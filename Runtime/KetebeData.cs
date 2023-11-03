using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Kidstellar.Tools
{
    public static class MessageToKetebe
    {
        [DllImport("__Internal")]
        private static extern void _SendMessage(string param);

        public static void SendMessage(KetebeData data)
        {
            _SendMessage(JsonUtility.ToJson(data));
        }
    }

    public enum KetebeDataType
    {
        Empty,
        GameData,
        BookData,
    }

    public enum KetebeActionType
    {
        Empty,
        Back,
    }

    [Serializable]
    public class KetebeData
    {
        public KetebeDataType dataType;
        public KetebeActionType actionType;
        public object value;
    }

    public class GameData
    {
        public string id;
        public bool isFinished;
    }

    public class BookData
    {
        public string id;
        public bool lastPageNumber;
    }
}
