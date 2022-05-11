// one-dimensional
int[] array1 = new int[8];

// multidimensional
int[,] array2 = new int[4,5];

// jagged array
int[][] array3 = new int[5][];

var arr1 = Array.CreateInstance(typeof(int), 5);

var arr2 = Array.CreateInstance(typeof(string), 5,2,3);

long[,] arr3 = (long[,])Array.CreateInstance(typeof(long), 
          new int[] {3,3}, new int[] {15,4});
arr3[16,3] = 2;


copy
copyto
indexof
lastindexof
exists
find
findall
reverse
sort
clear
foreach
