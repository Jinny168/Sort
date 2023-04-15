namespace ConsoleApplication
{
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
                }//switch
            }//while
        }//Main

        //冒泡排序
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

        //直接插入法排序
        private static void Sort02(int[] arr)
        {
            Console.Write("直接插入排序后：");
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;

                while ((j > 0) && (arr[j - 1] > temp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            printArr(arr);
        }

        //选择排序
        private static void Sort03(int[] arr)
        {
            Console.Write("选择排序后：");


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
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

        //二分法排序
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
                for (int j = i; j > low; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[low] = temp;
            }
            printArr(arr);
        }

        //Array类提供的排序方法
        private static void Sort05(int[] arr)
        {
            Console.Write("Array.Sort排序后：");
            Array.Sort(arr);
            printArr(arr);
        }
        
        //打印数组
        private static void printArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


    }//Class
}//NameSpace

