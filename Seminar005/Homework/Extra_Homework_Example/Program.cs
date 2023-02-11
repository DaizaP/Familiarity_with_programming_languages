// Задан массив a[1..n] из n неотрицательных целых чисел. Необходимо реализовать следующие операции над ним:

// get(i) – извлечение элемента с номером i;
// update(l,r,x) – присвоение значения x всем элементам подмассива a[l..r];
// add(l,r,x) – увеличение всех элементов a[l..r] на x;
// rsq(l,r) – вычисление суммы всех элементов a[l..r], т.е. значения a[l]+a[l+1]+…+a[r];
// rmq(l,r) – вычисление минимального элемента среди всех значений a[l..r].

Console.Clear();

void get(int[] array, int i)
{
    i = i - 1;
    Console.WriteLine(array[i]);
}
int[] update(int[] array, int l, int r, int x)
{
    for (int count = l - 1; count < r; count++)
    {
        array[count] = x;
    }
    return array;
}
int[] add(int[] array, int l, int r, int x)
{
    for (int count = l - 1; count < r; count++)
    {
        array[count] += x;
    }
    return array;
}
int rsq(int[] array, int l, int r)
{
    int sum = 0;
    for (int count = l - 1; count < r; count++)
    {
        sum += array[count];
    }
    return sum;
}
int rmq(int[] array, int l, int r)
{
    int minNum = array[l];
    for (int count = l - 1; count < r; count++)
    {
        if (minNum > array[count])
        {
            minNum = array[count];
        }
    }
    return minNum;
}

void output(int[] array,int m)
{
    for (int count = 1; count <= m; count++)
    {
        switch (count)
        {
            case 1:
                Console.WriteLine(rsq(array, 1, 10));
                break;
            case 2:
                update(array, 5, 6, 2);
                //Console.WriteLine($"[{String.Join(", ", array)}]");
                break;
            case 3:
                Console.WriteLine(rmq(array, 3, 9));
                break;
            case 4:
                add(array, 2, 8, 3);
                //Console.WriteLine($"[{String.Join(", ", array)}]");
                break;
            case 5:
                get(array, 7);
                break;
            default:
                break;
        }
    }
}

int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
output(array, 5);