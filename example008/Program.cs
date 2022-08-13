// найти масимальное число. Стихийный метод.
int a1 = 100;
int a2 = 3;
int a3 = 33;
int b1 = 200;
int b2 = 77;
int b3 = 87;

int max = a1;

if (max < a2) max = a2;
if (max < a3) max = a3;

if (max < b1) max = b1;
if (max < b2) max = b2;
if (max < b3) max = b3;

Console.WriteLine(max);
