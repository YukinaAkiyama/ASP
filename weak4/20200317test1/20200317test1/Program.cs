
using System;
namespace doubleBall
{
    class Program
    {
        static void Main()   //主函数
        {
            int spend = 0;      //花了多少钱
            long gain = 0;      //获得多少奖金
            while (true)      //写一个while循环, 连续运行
            {
                int[] goalBall = MakeBall();   //调用MakeBall方法,生成每期开奖号码
                int[] myBuy = BuyBall();       //买一注彩票
                Console.Write("开奖号码为:");   //打印机选号码
                ShowArr(goalBall);             //因为要打印很多数组,所以直接写了个打印数组的方法 ShowArr()
                Console.Write("您的号码为:");   //打印我的号码
                ShowArr(myBuy);                 //
                long temp = Reward(goalBall, myBuy);
                //把 开奖号码  我的号码 传给Reward()函数 看看 中没中奖 ,该函数会把中奖金额返回来,为了防止自己中很多一等奖,把temp数据类型定为了long :)
                spend += 2;                       //花钱累加
                gain += temp;                   //中奖累加
                Console.WriteLine("您花了{0}元~", spend);   //显示累积花了多少
                Console.WriteLine("您中了{0}元!", gain);    //显示累积中了多少
                temp = 0;
            }
        }
        static Random random = new Random();   //随机数声明
        private static int[] MakeBall()    //此函数生成随机号码,可用于开奖号码 和 机选
        {
            int[] arr = new int[7];        //号码是 7位的 数组
            for (int i = 0; i < 6; i++)     //生成前六个红球
            {
                while (true)
                {
                    int temp = random.Next(1, 34);
                    if (!(IsRepeat(arr, temp)))
                    //判断有没有和数组中其他球重复,重复了就继续while生成随机球.这里调用了自己写的 IsRepeat()函数,该函数重复返回true 否则false,所以前面来个!反一下.
                    {
                        arr[i] = temp;   //不重复就加入数组中
                        break;
                    }
                }
            }
            arr[6] = random.Next(1, 17);
            arr = RedBallSort(arr);           //调用RedBallSort()方法给红球排序
            return arr;                       //返回生产的随机彩票
        }
        private static int[] BuyBall()     //购买彩票的函数
        {
            while (true)
            {
                Console.WriteLine("机选请输入1\t手选请输入2");
                string strselect = Console.ReadLine();
                if (strselect == "1")     //如果输入1就机选
                {
                    return MakeBall();    //机选就调用MakeBall生成一注就可以了.
                }
                else if (strselect == "2") //如果输入2就手选
                {
                    int[] arr = new int[7];  //手选和机选其实思路一样,只不过加入了writeline和readline来进行控制台交互
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"请输入第{i + 1}个红球号码(1-33):");
                            int temp = int.Parse(Console.ReadLine());
                            if (temp > 0 && temp < 34)
                            {
                                if (!(IsRepeat(arr, temp)))      //也要判断是否重复
                                {
                                    arr[i] = temp;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("此号码已经选过了!请重新输入!");//重复就while回去重写!!
                                }
                            }
                            else
                            {
                                Console.WriteLine("号码有误!请重新输入!");//输入有误就while回去重写!!
                            }
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("请输入蓝球号码(1-16)");
                        int tempBlue = int.Parse(Console.ReadLine());
                        if (tempBlue > 0 && tempBlue < 17)
                        {
                            arr[6] = tempBlue;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("号码有误!请重新输入!"); //输入有误就while回去重写!!
                        }
                    }
                    return arr;
                }
                else
                {
                    Console.WriteLine("输入有误");  //输入有误就while回去重写!!
                }
            }
        }
        private static bool IsRepeat(int[] arr, int num)//判断球是否重复
        {
            return Array.IndexOf(arr, num) >= 0;    //indexof返回-1就不重复,大于等于都有重复
        }
        private static void ShowArr(Array arr)     //在控制台打印数组的函数
        {
            foreach (int each in arr)
            {
                Console.Write(each + ",");
            }
            Console.WriteLine("");
        }
        private static int[] RedBallSort(int[] arr)   //给红球从小到大的排序函数
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)   //Length - 1排除蓝球
            {
                for (int j = i + 1; j < arr.Length - 1; j++)  //冒泡排序
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        private static long Reward(int[] arrGoal, int[] arrBuy)//此函数判断中了几个红球,中了蓝球没有
        {
            bool blueRight = arrGoal[6] == arrBuy[6];   //判断中了蓝球没有
            int redBallCount = 0;                      //判断中了几个红球
            for (int i = 0; i < arrBuy.Length - 1; i++) //Length - 1排除蓝球
            {
                for (int j = 0; j < arrGoal.Length - 1; j++)   //每个红球和所有开奖红球比较
                {
                    if (arrBuy[i] == arrGoal[j])
                    {
                        redBallCount++;                  //中了就加一
                    }
                }
            }
            return AnyReward(redBallCount, blueRight);    //调用AnyReward()方法,传给他中的红蓝球信息,返回奖金金额,直接return;
        }
        private static long AnyReward(int redBallCount, bool blueRight)
        {
            if (redBallCount == 6 && blueRight)                     //简单的判断中奖信息
            {
                Console.WriteLine("恭喜你获得一等奖,奖金500万");
                return 5000000;
            }
            else if (redBallCount == 6)
            {
                Console.WriteLine("恭喜你获得二等奖,奖金125万");
                return 1250000;
            }
            else if (redBallCount == 5 && blueRight)
            {
                Console.WriteLine("恭喜你获得三等奖,奖金3000元");
                return 3000;
            }
            else if (redBallCount == 5 || (redBallCount == 4 && blueRight))
            {
                Console.WriteLine("恭喜你获得四等奖,奖金200元");
                return 200;
            }
            else if (redBallCount == 4 || (redBallCount == 3 && blueRight))
            {
                Console.WriteLine("恭喜你获得五等奖,奖金10元");
                return 10;
            }
            else if (redBallCount == 2 && blueRight)
            {
                Console.WriteLine("恭喜你获得五等奖,奖金5元");
                return 5;
            }
            else
            {
                Console.WriteLine("很抱歉您没有中奖~");
                return 0;
            }
        }
    }
}

