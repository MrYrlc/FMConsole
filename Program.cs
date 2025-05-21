using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season;
using FMShell.Models;
using FMShell.League_information.Bundesliga.Bundesliga_Clubs_in_the_22_23_season.FirstTeamPlayers;


namespace FMShell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用简易版FM（足球经理）");
            Console.Write("请输入你的昵称：");
            string UserName = Console.ReadLine();
            Console.WriteLine("好的，你的游戏昵称是" + UserName);
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
                        Console.Write("请输入yes或者no以确认是否选择指教这个球队");
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
                    if(UserHomeInput == 2)
                    {
                        Console.WriteLine("阵型暂时默认为433");
                        Console.WriteLine(UserName + "，以下是一线队球员名单，请你设置首发阵容");
                        for (int i = 0; i < UserClub22_23FirstTeamPlayers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1,2}.{UserClub22_23FirstTeamPlayers[i]}");
                        }
                        Console.Write("                ST                    \r\n\r\nLW             CAM              RW\r\n\r\n          CM             CM\r\n\r\nLB          CB        CB          RB\r\n\r\n                GK");
                        bool ConfirmStartingGK = false;
                        bool ConfirmNoGKPosPlayerBeStartingGK = false;
                        while (!(ConfirmStartingGK || ConfirmNoGKPosPlayerBeStartingGK))
                        {
                            Console.Write("请输入你的首发门将序号：");
                            string InputStartingGKNum = Console.ReadLine();
                            int InputStartingGK;
                            if (int.TryParse(InputStartingGKNum, out InputStartingGK) && InputStartingGK>0 && InputStartingGK<= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingGK].Pos == Position.GK)
                            {
                                Console.WriteLine("你选择添加的球员是：" + UserClub22_23FirstTeamPlayers[InputStartingGK]);
                                while (!ConfirmStartingGK)
                                {
                                    Console.WriteLine("请输入yes以确认 或者no重新选择：");
                                    string UserInputNumConfirmStartingGK = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmStartingGK == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发门将是：" + UserClub22_23FirstTeamPlayers[InputStartingGK]);
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
                            else if (int.TryParse(InputStartingGKNum, out InputStartingGK) && InputStartingGK > 0 && InputStartingGK <= UserClub22_23FirstTeamPlayers.Count && UserClub22_23FirstTeamPlayers[InputStartingGK].Pos != Position.GK)
                            {
                                Console.WriteLine("你输入的球员不是门将，请你重新考虑一下首发门将的人选择");
                                Console.WriteLine("如果你坚持首发这名球员，请输入yes，反之输入no以重新选择");
                                while (!ConfirmNoGKPosPlayerBeStartingGK)
                                {
                                    Console.WriteLine("请输入yes或者no");
                                    string UserInputNumConfirmNoGKPosPlayerBeStartingGK = Console.ReadLine().ToLower();
                                    if (UserInputNumConfirmNoGKPosPlayerBeStartingGK == "yes")
                                    {
                                        Console.WriteLine("添加成功，你的首发门将是：" + UserClub22_23FirstTeamPlayers[InputStartingGK]);
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
                        Console.Write("请输入你的首发左中后卫序号：");

                        Console.Write("请输入你的首发右中后卫序号：");

                        Console.Write("请输入你的首发左边后卫序号：");

                        Console.Write("请输入你的首发右边后卫序号：");

                        Console.Write("请输入你的首发中场（左）序号：");

                        Console.Write("请输入你的首发中场（右）序号：");

                        Console.Write("请输入你的首发进攻型中场序号：");

                        Console.Write("请输入你的首发前锋序号：");

                        Console.Write("请输入你的首发左边锋序号：");

                        Console.Write("请输入你的首发右边锋序号：");
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
