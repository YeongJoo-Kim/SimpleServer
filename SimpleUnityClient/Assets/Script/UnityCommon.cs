using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// ����Ƽ�� ����/Ŭ�� ������ �����Դϴ�
namespace UnityCommon
{
    /// <summary>
    /// ���� �α����� ���� �ּ�
    /// </summary>
    public class Join
    {
        public static readonly string ipaddr = "127.0.0.1";
        public static readonly UInt16 portnum = 20000;
        public static readonly UInt32 protocol_ver = 0;
    }


    /// <summary>
    /// ���� ����
    /// </summary>
    public enum Server : int
    {
        None = 0,
        Login,
        Lobby,
        Room
    }
}
