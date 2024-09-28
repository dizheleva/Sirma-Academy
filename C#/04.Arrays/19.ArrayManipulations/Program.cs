internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[] inputData = Console.ReadLine().Split(", ");        

        for (int i = 0; i < inputData.Length; i++)
        {
            string[] attributes = inputData[i].Split(' ');
            string command = attributes[0];
            int firstNum = int.Parse(attributes[1]);
            int secondNum = attributes.Length == 3 ? int.Parse(attributes[2]) : 0;
            switch (command)
            {
                case "Add":
                    int[] tempArr = new int[arr.Length + 1];
                    for (int j = 0; j < tempArr.Length - 1; j++)
                    {
                        tempArr[j] = arr[j];
                    }
                    tempArr[tempArr.Length - 1] = firstNum;
                    arr = tempArr;
                    break;
                case "Remove":
                    int removedIndex = Array.IndexOf(arr, firstNum);
                    int[] tempArr1 = new int[arr.Length - 1];
                    int addIndex1 = 0;
                    for (int j = 0; j < tempArr1.Length; j++)
                    {
                        if (j < removedIndex)
                        {
                            addIndex1 = j;
                        }
                        else 
                        {
                            addIndex1 = j + 1;
                        }

                        tempArr1[j] = arr[addIndex1];
                    }
                    arr = tempArr1;
                    break;
                case "RemoveAt":
                    int[] tempArr2 = new int[arr.Length - 1];
                    int addIndex2 = 0;
                    for (int j = 0; j < tempArr2.Length; j++)
                    {
                        if (j < firstNum)
                        {
                            addIndex2 = j;
                        }
                        else 
                        {
                            addIndex2 = j + 1;
                        }

                        tempArr2[j] = arr[addIndex2];
                    }
                    arr = tempArr2;
                    break;
                case "Insert":
                    int[] tempArr3 = new int[arr.Length + 1];
                    int addIndex3 = 0;
                    for (int j = 0; j < tempArr3.Length; j++)
                    {
                        if (j == secondNum)
                        {
                            tempArr3[j] = firstNum;
                        }
                        else
                        {
                            if (j < secondNum)
                            {
                                addIndex3 = j;
                            }
                            else if (j > secondNum)
                            {
                                addIndex3 = j - 1;
                            }
                            tempArr3[j] = arr[addIndex3];
                        }                        
                    }
                    arr = tempArr3;
                    break;
            }
        }

        Console.WriteLine(String.Join(' ', arr));
    }
}