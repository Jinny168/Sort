
using jin;
using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApplication2
{
    public enum Mydate
    { 
    
        Fri=5,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 9, 27, 6, 18, 12, 19, 21, 15, 21, 90, 71, 75, 3, 9 };
            Console.Write("排序前：");
            printArr(arr);
            bool flag = true;
            while (flag)
            { 
                Console.WriteLine("请输入0（冒泡排序）、1（直接插入排序）、2（选择排序）、3（二分法）、4（Array提供的方法）、其他任意按键（退出）\n请选择你所使用的排序方法");
                string? str = Console.ReadLine();
                int selectMethod = int.Parse(str.ToString());
                /*冒泡*/
                switch (selectMethod)
                {
                    case 0:
                        Sort01(arr);
                        break;
                    case 1:
                        Sort02(arr);
                        break;
                    case 2:
                        Sort03(arr);
                        break;
                    case 3:
                        Sort04(arr);
                        break;
                    case 4:
                        Sort05(arr);
                        break;
                    default:
                        Console.WriteLine("exit");
                        flag = false;
                        break;
                }
            }
            





            // string str1 = "去爱";
            // string str2;
            // str2 = str1.Insert(0, "用一生");
            // int len = str2.Length;
            // str2 = str2.Insert(len, "你");
            // Console.WriteLine(str2);
            // str2=str2.Remove(3, 1);
            // Console.WriteLine(str2);

            // string str3 = "*^_^*";
            // string str4;
            // str4 = str3.PadLeft(6, '(');
            // str4 = str4.PadRight(7, ')');

            // Console.WriteLine(str4);


            // Console.WriteLine((int)DateTime.Now.DayOfWeek);
            // int k = (int)DateTime.Now.DayOfWeek;
            // switch (k)
            // {
            //     case (int)Mydate.Fri:
            //         Console.WriteLine("bingo");
            //         break;
            //     default:
            //         break;
            // }
            // jin.A Aclass = new jin.A();
            // Aclass.SaySomethimg();

            // int x = 88;
            // x=x<<8;

            // Console.WriteLine(x);

            // string str = new string("Dream ^ abou t#y ou");
            // char[] sep = { ' ' ,'^','#'};
            // string[] strArray = new string[100];
            // strArray=str.Split(sep);
            // foreach (var item in strArray)
            // {
            //     Console.Write(item);
            // }
            // string a = "--------";
            // Console.WriteLine(a);
            // string sampleStr=str.Substring(0, 5);
            // string newStr = string.Format("{0,-10:D},{1,10},{2,-10}",DateTime.Now,str,sampleStr);
            // Console.WriteLine(newStr);

            //string str01 = new string("D:\\Projects\\文档\\Test.txt");
            // char sepAA = '.';
            // string[] str02 = str01.Split(sepAA);
            // string str03 = str02[0];
            // string extension = str02[1];
            // Console.WriteLine(extension);

            // char sepBB = '\\';
            // string[] str04 = str03.Split(sepBB);

            // string  fileName= str04[str04.Length-1];

            // StringBuilder stringBuilder = new StringBuilder(fileName);

            // string mydot = ".";
            // stringBuilder.Append(mydot);
            // stringBuilder.Append(extension);
            // string fullName = stringBuilder.ToString();


            // string filePath=str01.Replace(fullName,"");


            // Console.WriteLine("文件路径为{0}，文件全名为{1}，文件名为{2}，文件后缀名为{3}", filePath, fullName, fileName, extension);






            // char[] sep01 = { '\\', '.' };
            // string[] strs = str01.Split(sep01);
            // int strLen = strs.Length;
            // for (int i = 0; i < strLen - 2; i++)
            // {
            //     Console.Write(strs[i]);
            //     Console.Write('\\');
            // }
            // Console.WriteLine();
            // Console.WriteLine(strs[strLen - 2]);
            // Console.WriteLine(strs[strLen - 1]);


            // Console.ReadLine();


            //Console.WriteLine("Hello world");
            //Console.ReadLine();
            //// Create the MATLAB instance 
            //MLApp.MLApp matlab = new MLApp.MLApp();

            //// Change to the directory where the function is located 
            //matlab.Execute(@"cd d:\work\example");

            //// Define the output 
            //object result = null;

            //// Call the MATLAB function myfunc
            //matlab.Feval("myfunc", 2, out result, 3.14, 42.0, "world");

            //// Display result 
            //object[] res = result as object[];

            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);
            //// Get user input to terminate program
            //Console.ReadLine();
        }

        private static void Sort04(int[] arr)
        {
            Console.Write("二分排序后：");
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int low = 0;
                int high = i - 1;
                int mid = -1;
                while (high >= low) 
                {
                    mid = (high + low) / 2;
                    if (arr[mid] > temp)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                for (int j = i ; j > low; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[low] = temp;
            }
            printArr(arr);
        }

        private static void Sort05(int[] arr)
        {
            Console.Write("Array.Sort排序后：");
            Array.Sort(arr);

            printArr(arr);
        }

        private static void Sort03(int[] arr)
        {
            Console.Write("选择排序后：");
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min=i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;   
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            printArr(arr);
        }

        private static void Sort02(int[] arr)
        {
            Console.Write("直接插入排序后：");
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i ;

                while ((j > 0) && (arr[j - 1] > temp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            printArr(arr);
        }

        private static void Sort01(int[] arr)
        {
            Console.Write("冒泡排序后：");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            printArr(arr);
        }

        private static void printArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}

namespace jin
{
    class A
    {

        public void SaySomethimg()
        {
            Console.WriteLine("I Love You");

        
        }
    }
}

