using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geek_Plus_Json_Http
{
    public class Geek_RobotInfoMsg_Response_body
    {

        public int robot;//机器人id
        public string robotProduct;//机器人产品型号：
        public string robotConnectStatus;// 人错误码，多个以逗号分割
        public string robotStopStatus;// 人错误码，多个以逗号分割
        public string robotError;// 人错误码，多个以逗号分割
        public int powerPercent;//机器人电池电量
        public string angle;//机器人角度
        public string speed;//机器人实时速度
        public DPoint location;//位置
        public IPoint locationIndex;//位置索引
        public string locationCode;//位置对应的单元格的编码
        public string hostLocationCode;//位置对应的单元格的外部编码

        public string robotPathMode;//机器人路径模型
        public string robotTaskId;//机器人任务号
        public List<DPoint> path = new List<DPoint>();//路径
        public string voltage;//电池电压
        public string current;//电池电流
        public string temperature;//电池温度
        public string ip;//机器人ip
        public string instanceId;//流程实例id
        public Geek_RobotInfoMsg_Response_body()
        {

        }
    }
}
