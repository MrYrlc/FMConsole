using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season;
using FMShell.Models;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.FirstTeamPlayers;
using FMShell.Function.Show;
using FMShell.Mapper;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.ClubInformation;

namespace FMShell
{
    internal class Program
    {
        public static string UserName = "";
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用简易版FM（足球经理）");
            Console.Write("请输入你的昵称：");
            UserName = Console.ReadLine();
            Console.WriteLine("好的，你的游戏昵称是：" + UserName);
            Console.WriteLine("以下是22-23赛季德甲球队名单：");
            List<Club> BundesLiga22_23Club = BL22_23ClubList.Bundesliga22_23;
            foreach (var club in BundesLiga22_23Club)
            {
                Console.WriteLine(club.Name);
            }
            bool ConfirmClub = false;
            string UserInputEnglishClubName = "";
            string UserInputChineseClubName = "";
            while (!ConfirmClub)
            {
                Console.Write("请输入你想指教的球队：");
                UserInputChineseClubName = Console.ReadLine();
                if (ClubNameMapper.ChineseToEnglishClubName.TryGetValue(UserInputChineseClubName, out UserInputEnglishClubName))
                {
                    while (true)
                    {
                        Console.WriteLine("你想指教的球队是：" + UserInputChineseClubName);
                        Console.Write("请输入yes或者no以确认是否选择指教这个球队：");
                        string UserInputNumConfirmClub = Console.ReadLine().ToLower();
                        if (UserInputNumConfirmClub == "yes")
                        {
                            Console.WriteLine("确认成功");
                            ConfirmClub = true;
                            break;
                        }
                        else if (UserInputNumConfirmClub == "no")
                        {
                            Console.WriteLine("好的，请重新选择你想执教的球队");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("请你输入yes或者no");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("没找到你输入的球队，请输入正确且完整的球队名字");
                }
            }
            
               
            Console.WriteLine(UserName + "，你现在正式成为了" + UserInputChineseClubName + "的主教练");
            Console.WriteLine("=========== FMShell 主菜单 ===========");
            Console.WriteLine(" 1. 查看一线队球员名单");
            Console.WriteLine(" 2. 设置首发阵容");
            Console.WriteLine(" 3. 查看俱乐部信息");
            Console.WriteLine(" 4. 查看联赛积分榜");
            Console.WriteLine(" 5. 进行下一轮比赛");
            Console.WriteLine(" 6. 查看本赛季赛程与战绩");
            Console.WriteLine(" 7. 查看球队数据统计（进球/助攻等）");
            Console.WriteLine(" 8. 查看球员数据（体能、伤病、状态）");
            Console.WriteLine(" 9. 查看转会市场与引援");
            Console.WriteLine("10. 保存并退出游戏");
            Console.WriteLine("======================================");
            Console.Write("请输入选项编号进行操作：");
            while (true)
            {
                string userhomeinput = Console.ReadLine();
                int UserHomeInput;

                if (int.TryParse(userhomeinput, out UserHomeInput) && UserHomeInput > 0 && UserHomeInput < 11)
                {
                    List<Player> UserClub22_23FirstTeamPlayers = FirstTeamPlayerMapper.ClubToPlayers[UserInputEnglishClubName];
                    if (UserHomeInput == 1)
                    {
                        foreach(var player in UserClub22_23FirstTeamPlayers)
                        {
                            Console.WriteLine(player);
                        }
                    }
                    else if(UserHomeInput == 2)
                    {
                        Console.WriteLine("阵型暂时默认为433");
                        Console.WriteLine(UserName + "，以下是一线队球员名单，请你设置首发阵容");
                        for (int i = 0; i < UserClub22_23FirstTeamPlayers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1,2}.{UserClub22_23FirstTeamPlayers[i]}");
                        }
                        Console.WriteLine("                ST                    \r\n\r\nLW             CAM              RW\r\n\r\n         LCM            RCM\r\n\r\nLB         LCB       RCB          RB\r\n\r\n                GK");
                        bool ConfirmStartingGK = false;
                        bool ConfirmNoGKPosPlayerBeStartingGK = false;
                        int InputStartingGK = 0;
                        while (!(ConfirmStartingGK || ConfirmNoGKPosPlayerBeStartingGK))
                        {
                            Console.Write("请输入你的首发门将序号：");
                            string InputStartingGKNum = Console.ReadLine();
                            if (int.TryParse(InputStartingGKNum, out InputStartingGK) && InputStartingGK>0 && InputStartingGK<= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingGK - 1].Pos == Position.GK)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingGK - 1]);
                                while (!ConfirmStartingGK)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingGK = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingGK == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发门将是：" + UserClub22_23FirstTeamPlayers[InputStartingGK - 1]);
                                        ConfirmStartingGK = true;
                                    }
                                    else if (UserInputNumConfirmStartingGK == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发门将");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingGKNum, out InputStartingGK) && InputStartingGK > 0 && InputStartingGK <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingGK - 1].Pos != Position.GK)
                            {
                                Console.WriteLine("你输入的球员不是门将，请你重新考虑一下首发门将的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoGKPosPlayerBeStartingGK)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoGKPosPlayerBeStartingGK = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoGKPosPlayerBeStartingGK == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发门将是：" + UserClub22_23FirstTeamPlayers[InputStartingGK - 1]);
                                        ConfirmNoGKPosPlayerBeStartingGK = true;
                                    }
                                    else if (UserInputNumConfirmNoGKPosPlayerBeStartingGK == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发门将");
                                        break;
                                    }
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingLCB = false;
                        bool ConfirmNoLCBPosPlayerBeStartingLCB = false;
                        int InputStartingLCB = 0;
                        while (!(ConfirmStartingLCB || ConfirmNoLCBPosPlayerBeStartingLCB))
                        {
                            Console.Write("请输入你的首发左中后卫序号：");
                            string InputStartingLCBNum = Console.ReadLine();
                            if (int.TryParse(InputStartingLCBNum, out InputStartingLCB) && InputStartingLCB > 0 && InputStartingLCB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLCB - 1].Pos == Position.LCB)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingLCB - 1]);
                                while (!ConfirmStartingLCB)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingLCB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingLCB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左中后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLCB - 1]);
                                        ConfirmStartingLCB = true;
                                    }
                                    else if (UserInputNumConfirmStartingLCB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左中后卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingLCBNum, out InputStartingLCB) && InputStartingLCB > 0 && InputStartingLCB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLCB - 1].Pos != Position.LCB)
                            {
                                Console.WriteLine("你输入的球员不是左中后卫，请你重新考虑一下首发左中后卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoLCBPosPlayerBeStartingLCB)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoLCBPosPlayerBeStartingLCB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoLCBPosPlayerBeStartingLCB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左中后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLCB - 1]);
                                        ConfirmNoLCBPosPlayerBeStartingLCB = true;
                                    }
                                    else if (UserInputNumConfirmNoLCBPosPlayerBeStartingLCB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左中后卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingRCB = false;
                        bool ConfirmNoRCBPosPlayerBeStartingRCB = false;
                        int InputStartingRCB = 0;
                        while (!(ConfirmStartingRCB || ConfirmNoRCBPosPlayerBeStartingRCB))
                        {
                            Console.Write("请输入你的首发右中后卫序号：");
                            string InputStartingRCBNum = Console.ReadLine();
                            if (int.TryParse(InputStartingRCBNum, out InputStartingRCB) && InputStartingRCB > 0 && InputStartingRCB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRCB - 1].Pos == Position.RCB)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingRCB - 1]);
                                while (!ConfirmStartingRCB)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingRCB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingRCB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右中后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRCB - 1]);
                                        ConfirmStartingRCB = true;
                                    }
                                    else if (UserInputNumConfirmStartingRCB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右中后卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingRCBNum, out InputStartingRCB) && InputStartingRCB > 0 && InputStartingRCB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRCB - 1].Pos != Position.RCB)
                            {
                                Console.WriteLine("你输入的球员不是右中后卫，请你重新考虑一下首发右中后卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoRCBPosPlayerBeStartingRCB)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoRCBPosPlayerBeStartingRCB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoRCBPosPlayerBeStartingRCB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右中后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRCB - 1]);
                                        ConfirmNoRCBPosPlayerBeStartingRCB = true;
                                    }
                                    else if (UserInputNumConfirmNoRCBPosPlayerBeStartingRCB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右中后卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingLB = false;
                        bool ConfirmNoLBPosPlayerBeStartingLB = false;
                        int InputStartingLB = 0;
                        while (!(ConfirmStartingLB || ConfirmNoLBPosPlayerBeStartingLB))
                        {
                            Console.Write("请输入你的首发左边后卫序号：");
                            string InputStartingLBNum = Console.ReadLine();
                            if (int.TryParse(InputStartingLBNum, out InputStartingLB) && InputStartingLB > 0 && InputStartingLB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLB - 1].Pos == Position.LB)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingLB - 1]);
                                while (!ConfirmStartingLB)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingLB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingLB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左边后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLB - 1]);
                                        ConfirmStartingLB = true;
                                    }
                                    else if (UserInputNumConfirmStartingLB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左边后卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingLBNum, out InputStartingLB) && InputStartingLB > 0 && InputStartingLB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLB - 1].Pos != Position.LB)
                            {
                                Console.WriteLine("你输入的球员不是左边后卫，请你重新考虑一下首发左边后卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoLBPosPlayerBeStartingLB)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoLBPosPlayerBeStartingLB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoLBPosPlayerBeStartingLB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左边后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLB - 1]);
                                        ConfirmNoLBPosPlayerBeStartingLB = true;
                                    }
                                    else if (UserInputNumConfirmNoLBPosPlayerBeStartingLB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左边后卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingRB = false;
                        bool ConfirmNoRBPosPlayerBeStartingRB = false;
                        int InputStartingRB = 0;
                        while (!(ConfirmStartingRB || ConfirmNoRBPosPlayerBeStartingRB))
                        {
                            Console.Write("请输入你的首发右边后卫序号：");
                            string InputStartingRBNum = Console.ReadLine();
                            if (int.TryParse(InputStartingRBNum, out InputStartingRB) && InputStartingRB > 0 && InputStartingRB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRB - 1].Pos == Position.RB)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingRB - 1]);
                                while (!ConfirmStartingRB)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingRB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingRB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右边后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRB - 1]);
                                        ConfirmStartingRB = true;
                                    }
                                    else if (UserInputNumConfirmStartingRB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右边后卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingRBNum, out InputStartingRB) && InputStartingRB > 0 && InputStartingRB <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRB - 1].Pos != Position.RB)
                            {
                                Console.WriteLine("你输入的球员不是右边后卫，请你重新考虑一下首发右边后卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoRBPosPlayerBeStartingRB)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoRBPosPlayerBeStartingRB = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoRBPosPlayerBeStartingRB == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右边后卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRB - 1]);
                                        ConfirmNoRBPosPlayerBeStartingRB = true;
                                    }
                                    else if (UserInputNumConfirmNoRBPosPlayerBeStartingRB == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右边后卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingLCM = false;
                        bool ConfirmNoLCMPosPlayerBeStartingLCM = false;
                        int InputStartingLCM = 0;
                        while (!(ConfirmStartingLCM || ConfirmNoLCMPosPlayerBeStartingLCM))
                        {
                            Console.Write("请输入你的首发左中前卫序号：");
                            string InputStartingLCMNum = Console.ReadLine();
                            if (int.TryParse(InputStartingLCMNum, out InputStartingLCM) && InputStartingLCM > 0 && InputStartingLCM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLCM - 1].Pos == Position.LCM)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingLCM - 1]);
                                while (!ConfirmStartingLCM)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingLCM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingLCM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左中前卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLCM - 1]);
                                        ConfirmStartingLCM = true;
                                    }
                                    else if (UserInputNumConfirmStartingLCM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左中前卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingLCMNum, out InputStartingLCM) && InputStartingLCM > 0 && InputStartingLCM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLCM - 1].Pos != Position.LCM)
                            {
                                Console.WriteLine("你输入的球员不是左中前卫，请你重新考虑一下首发左中前卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoLCMPosPlayerBeStartingLCM)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoLCMPosPlayerBeStartingLCM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoLCMPosPlayerBeStartingLCM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左中前卫是：" + UserClub22_23FirstTeamPlayers[InputStartingLCM - 1]);
                                        ConfirmNoLCMPosPlayerBeStartingLCM = true;
                                    }
                                    else if (UserInputNumConfirmNoLCMPosPlayerBeStartingLCM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左中前卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingRCM = false;
                        bool ConfirmNoRCMPosPlayerBeStartingRCM = false;
                        int InputStartingRCM = 0;
                        while (!(ConfirmStartingRCM || ConfirmNoRCMPosPlayerBeStartingRCM))
                        {
                            Console.Write("请输入你的首发右中前卫序号：");
                            string InputStartingRCMNum = Console.ReadLine();
                            if (int.TryParse(InputStartingRCMNum, out InputStartingRCM) && InputStartingRCM > 0 && InputStartingRCM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRCM - 1].Pos == Position.RCM)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingRCM - 1]);
                                while (!ConfirmStartingRCM)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingRCM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingRCM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右中前卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRCM - 1]);
                                        ConfirmStartingRCM = true;
                                    }
                                    else if (UserInputNumConfirmStartingRCM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右中前卫");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingRCMNum, out InputStartingRCM) && InputStartingRCM > 0 && InputStartingRCM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRCM - 1].Pos != Position.RCM)
                            {
                                Console.WriteLine("你输入的球员不是右中前卫，请你重新考虑一下首发右中前卫的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoRCMPosPlayerBeStartingRCM)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoRCMPosPlayerBeStartingRCM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoRCMPosPlayerBeStartingRCM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右中前卫是：" + UserClub22_23FirstTeamPlayers[InputStartingRCM - 1]);
                                        ConfirmNoRCMPosPlayerBeStartingRCM = true;
                                    }
                                    else if (UserInputNumConfirmNoRCMPosPlayerBeStartingRCM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右中前卫");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingCAM = false;
                        bool ConfirmNoCAMPosPlayerBeStartingCAM = false;
                        int InputStartingCAM = 0;
                        while (!(ConfirmStartingCAM || ConfirmNoCAMPosPlayerBeStartingCAM))
                        {
                            Console.Write("请输入你的首发进攻型中场序号：");
                            string InputStartingCAMNum = Console.ReadLine();
                            if (int.TryParse(InputStartingCAMNum, out InputStartingCAM) && InputStartingCAM > 0 && InputStartingCAM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingCAM - 1].Pos == Position.CAM)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingCAM - 1]);
                                while (!ConfirmStartingCAM)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingCAM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingCAM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发进攻型中场是：" + UserClub22_23FirstTeamPlayers[InputStartingCAM - 1]);
                                        ConfirmStartingCAM = true;
                                    }
                                    else if (UserInputNumConfirmStartingCAM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发进攻型中场");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingCAMNum, out InputStartingCAM) && InputStartingCAM > 0 && InputStartingCAM <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingCAM - 1].Pos != Position.CAM)
                            {
                                Console.WriteLine("你输入的球员不是进攻型中场，请你重新考虑一下首发进攻型中场的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoCAMPosPlayerBeStartingCAM)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoCAMPosPlayerBeStartingCAM = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoCAMPosPlayerBeStartingCAM == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发进攻型中场是：" + UserClub22_23FirstTeamPlayers[InputStartingCAM - 1]);
                                        ConfirmNoCAMPosPlayerBeStartingCAM = true;
                                    }
                                    else if (UserInputNumConfirmNoCAMPosPlayerBeStartingCAM == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发进攻型中场");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingST = false;
                        bool ConfirmNoSTPosPlayerBeStartingST = false;
                        int InputStartingST = 0;
                        while (!(ConfirmStartingST || ConfirmNoSTPosPlayerBeStartingST))
                        {
                            Console.Write("请输入你的首发前锋序号：");
                            string InputStartingSTNum = Console.ReadLine();
                            if (int.TryParse(InputStartingSTNum, out InputStartingST) && InputStartingST > 0 && InputStartingST <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingST - 1].Pos == Position.ST)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingST - 1]);
                                while (!ConfirmStartingST)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingST = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingST == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发前锋是：" + UserClub22_23FirstTeamPlayers[InputStartingST - 1]);
                                        ConfirmStartingST = true;
                                    }
                                    else if (UserInputNumConfirmStartingST == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发前锋");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingSTNum, out InputStartingST) && InputStartingST > 0 && InputStartingST <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingST - 1].Pos != Position.ST)
                            {
                                Console.WriteLine("你输入的球员不是前锋，请你重新考虑一下首发前锋的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoSTPosPlayerBeStartingST)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoSTPosPlayerBeStartingST = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoSTPosPlayerBeStartingST == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发前锋是：" + UserClub22_23FirstTeamPlayers[InputStartingST - 1]);
                                        ConfirmNoSTPosPlayerBeStartingST = true;
                                    }
                                    else if (UserInputNumConfirmNoSTPosPlayerBeStartingST == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发前锋");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingLW = false;
                        bool ConfirmNoLWPosPlayerBeStartingLW = false;
                        int InputStartingLW = 0;
                        while (!(ConfirmStartingLW || ConfirmNoLWPosPlayerBeStartingLW))
                        {
                            Console.Write("请输入你的首发左边锋序号：");
                            string InputStartingLWNum = Console.ReadLine();
                            if (int.TryParse(InputStartingLWNum, out InputStartingLW) && InputStartingLW > 0 && InputStartingLW <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLW - 1].Pos == Position.LW)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingLW - 1]);
                                while (!ConfirmStartingLW)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingLW = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingLW == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左边锋是：" + UserClub22_23FirstTeamPlayers[InputStartingLW - 1]);
                                        ConfirmStartingLW = true;
                                    }
                                    else if (UserInputNumConfirmStartingLW == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左边锋");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingLWNum, out InputStartingLW) && InputStartingLW > 0 && InputStartingLW <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingLW - 1].Pos != Position.LW)
                            {
                                Console.WriteLine("你输入的球员不是左边锋，请你重新考虑一下首发左边锋的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoLWPosPlayerBeStartingLW)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoLWPosPlayerBeStartingLW = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoLWPosPlayerBeStartingLW == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发左边锋是：" + UserClub22_23FirstTeamPlayers[InputStartingLW - 1]);
                                        ConfirmNoLWPosPlayerBeStartingLW = true;
                                    }
                                    else if (UserInputNumConfirmNoLWPosPlayerBeStartingLW == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发左边锋");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }
                        bool ConfirmStartingRW = false;
                        bool ConfirmNoRWPosPlayerBeStartingRW = false;
                        int InputStartingRW = 0;
                        while (!(ConfirmStartingRW || ConfirmNoRWPosPlayerBeStartingRW))
                        {
                            Console.Write("请输入你的首发右边锋序号：");
                            string InputStartingRWNum = Console.ReadLine();
                            if (int.TryParse(InputStartingRWNum, out InputStartingRW) && InputStartingRW > 0 && InputStartingRW <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRW - 1].Pos == Position.RW)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingRW - 1]);
                                while (!ConfirmStartingRW)
                                {
                                    Console.Write("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingRW = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingRW == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右边锋是：" + UserClub22_23FirstTeamPlayers[InputStartingRW - 1]);
                                        ConfirmStartingRW = true;
                                    }
                                    else if (UserInputNumConfirmStartingRW == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右边锋");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("无效输入");
                                    }
                                }
                            }
                            else if (int.TryParse(InputStartingRWNum, out InputStartingRW) && InputStartingRW > 0 && InputStartingRW <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingRW - 1].Pos != Position.RW)
                            {
                                Console.WriteLine("你输入的球员不是右边锋，请你重新考虑一下首发右边锋的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoRWPosPlayerBeStartingRW)
                                {
                                    Console.Write("请输入yes或者no：");
                                    string UserInputNumConfirmNoRWPosPlayerBeStartingRW = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoRWPosPlayerBeStartingRW == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发右边锋是：" + UserClub22_23FirstTeamPlayers[InputStartingRW - 1]);
                                        ConfirmNoRWPosPlayerBeStartingRW = true;
                                    }
                                    else if (UserInputNumConfirmNoRWPosPlayerBeStartingRW == "no")
                                    {
                                        Console.WriteLine("好的，请你重新选择首发右边锋");
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("请输入有效的球员序号");
                            }
                        }

                        Console.WriteLine("你的首发名单为：");
                        Console.WriteLine("前锋："+ UserClub22_23FirstTeamPlayers[InputStartingST - 1]);
                        Console.WriteLine("左边锋：" + UserClub22_23FirstTeamPlayers[InputStartingLW - 1]);
                        Console.WriteLine("右边锋：" + UserClub22_23FirstTeamPlayers[InputStartingRW - 1]);
                        Console.WriteLine("进攻型中场：" + UserClub22_23FirstTeamPlayers[InputStartingCAM - 1]);
                        Console.WriteLine("左中前卫：" + UserClub22_23FirstTeamPlayers[InputStartingLCM - 1]);
                        Console.WriteLine("右中前卫：" + UserClub22_23FirstTeamPlayers[InputStartingRCM - 1]);
                        Console.WriteLine("左边后卫：" + UserClub22_23FirstTeamPlayers[InputStartingLB - 1]);
                        Console.WriteLine("右边后卫：" + UserClub22_23FirstTeamPlayers[InputStartingRB - 1]);
                        Console.WriteLine("左中后卫：" + UserClub22_23FirstTeamPlayers[InputStartingLCB - 1]);
                        Console.WriteLine("右中后卫：" + UserClub22_23FirstTeamPlayers[InputStartingRCB - 1]);
                        Console.WriteLine("门将：" + UserClub22_23FirstTeamPlayers[InputStartingGK - 1]);
                    }
                    else if(UserHomeInput == 3)
                    {
                        ShowClubInformation.ShowClubInf(ClubInformationMapper.ClubToClubInformation[ClubNameMapper.ChineseToEnglishClubName[UserInputChineseClubName]]);
                    }
                }
                else
                {
                    Console.WriteLine("请输入有效选项");
                }
            }
           
            Console.ReadKey();

        } 
    }
}
