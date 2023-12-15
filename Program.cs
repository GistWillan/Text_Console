using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryptDecrypt
{
    class Program
    {
        //定义一个列表来存储历史记录
        static List<string> history = new List<string>();

        //定义一个方法来实现Base64加密
        static string Base64Encrypt(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text); //将文本转换为字节数组
            string result = Convert.ToBase64String(bytes); //将字节数组转换为Base64字符串
            return result;
        }

        //定义一个方法来实现Base64解密
        static string Base64Decrypt(string text)
        {
            byte[] bytes = Convert.FromBase64String(text); //将Base64字符串转换为字节数组
            string result = Encoding.UTF8.GetString(bytes); //将字节数组转换为文本
            return result;
        }

        //定义一个方法来实现URL(UTF8)加密
        static string URLEncrypt(string text)
        {
            string result = Uri.EscapeDataString(text); //将文本转换为URL编码
            return result;
        }

        //定义一个方法来实现URL(UTF8)解密
        static string URLDecrypt(string text)
        {
            string result = Uri.UnescapeDataString(text); //将URL编码转换为文本
            return result;
        }

        //定义一个方法来显示菜单
        static void ShowMenu()
        {
            Console.WriteLine("欢迎使用文字加密解密程序，请选择以下操作：");
            Console.WriteLine("1. 开始加密");
            Console.WriteLine("2. 开始解密");
            Console.WriteLine("3. 历史记录");
            Console.WriteLine("4. 退出程序");
            Console.Write("请输入您的选择：");
        }

        //定义一个方法来执行加密操作
        static void Encrypt()
        {
            Console.WriteLine("请选择加密算法：");
            Console.WriteLine("1. Base64");
            Console.WriteLine("2. URL(UTF8)");
            Console.Write("请输入您的选择：");
            int choice = int.Parse(Console.ReadLine()); //获取用户的选择
            Console.Write("请输入您要加密的文字：");
            string text = Console.ReadLine(); //获取用户要加密的文字
            string result = ""; //定义一个变量来存储加密结果
            switch (choice) //根据用户的选择执行不同的加密方法
            {
                case 1:
                    result = Base64Encrypt(text); //调用Base64加密方法
                    break;
                case 2:
                    result = URLEncrypt(text); //调用URL(UTF8)加密方法
                    break;
                default:
                    Console.WriteLine("无效的选择，请重新输入。");
                    Encrypt(); //重新执行加密操作
                    return;
            }
            Console.WriteLine("加密结果为：" + result); //输出加密结果
            history.Add("加密：" + text + " -> " + result); //将加密记录添加到历史列表中
            AfterOperation(); //执行后续操作
        }

        //定义一个方法来执行解密操作
        static void Decrypt()
        {
            Console.WriteLine("请选择解密算法：");
            Console.WriteLine("1. Base64");
            Console.WriteLine("2. URL(UTF8)");
            Console.Write("请输入您的选择：");
            int choice = int.Parse(Console.ReadLine()); //获取用户的选择
            Console.Write("请输入您要解密的文字：");
            string text = Console.ReadLine(); //获取用户要解密的文字
            string result = ""; //定义一个变量来存储解密结果
            switch (choice) //根据用户的选择执行不同的解密方法
            {
                case 1:
                    result = Base64Decrypt(text); //调用Base64解密方法
                    break;
                case 2:
                    result = URLDecrypt(text); //调用URL(UTF8)解密方法
                    break;
                default:
                    Console.WriteLine("无效的选择，请重新输入。");
                    Decrypt(); //重新执行解密操作
                    return;
            }
            Console.WriteLine("解密结果为：" + result); //输出解密结果
            history.Add("解密：" + text + " -> " + result); //将解密记录添加到历史列表中
            AfterOperation(); //执行后续操作
        }

        //定义一个方法来显示历史记录
        static void ShowHistory()
        {
            Console.WriteLine("以下是您的历史记录：");
            if (history.Count == 0) //如果历史列表为空
            {
                Console.WriteLine("暂无历史记录。"); //输出提示信息
            }
            else //如果历史列表不为空
            {
                foreach (string record in history) //遍历历史列表
                {
                    Console.WriteLine(record); //输出每条历史记录
                }
            }
            AfterOperation(); //执行后续操作
        }

        //定义一个方法来执行后续操作
        static void AfterOperation()
        {
            Console.WriteLine("请选择以下操作：");
            Console.WriteLine("1. 继续");
            Console.WriteLine("2. 返回菜单");
            Console.WriteLine("3. 退出程序");
            Console.Write("请输入您的选择：");
            int choice = int.Parse(Console.ReadLine()); //获取用户的选择
            switch (choice) //根据用户的选择执行不同的操作
            {
                case 1:
                    Console.Clear(); //清空控制台
                    Encrypt(); //执行加密操作
                    break;
                case 2:
                    Console.Clear(); //清空控制台
                    ShowMenu(); //显示菜单
                    break;
                case 3:
                    Environment.Exit(0); //退出程序
                    break;
                default:
                    Console.WriteLine("无效的选择，请重新输入。");
                    AfterOperation(); //重新执行后续操作
                    return;
            }
        }

        static void Main(string[] args)
        {
            ShowMenu(); //显示菜单
            int choice = int.Parse(Console.ReadLine()); //获取用户的选择
            switch (choice) //根据用户的选择执行不同的操作
            {
                case 1:
                    Console.Clear(); //清空控制台
                    Encrypt(); //执行加密操作
                    break;
                case 2:
                    Console.Clear(); //清空控制台
                    Decrypt(); //执行解密操作
                    break;
                case 3:
                    Console.Clear(); //清空控制台
                    ShowHistory(); //显示历史记录
                    break;
                case 4:
                    Environment.Exit(0); //退出程序
                    break;
                default:
                    Console.WriteLine("无效的选择，请重新输入。");
                    Main(args); //重新执行主方法
                    return;
            }
        }
    }
}
