using algo_ds_dotnet.Algorithms.Excercises;
using algo_ds_dotnet.Algorithms.Lesson1_BigONot;
using algo_ds_dotnet.Algorithms.Lesson10_DynamicProgramming;
using algo_ds_dotnet.Algorithms.Lesson2_Problems;
using algo_ds_dotnet.Algorithms.Lesson3_FreqCounter;
using algo_ds_dotnet.Algorithms.Lesson4_MultiplePointers;
using algo_ds_dotnet.Algorithms.Lesson5_SlidingWindow;
using algo_ds_dotnet.Algorithms.Lesson6_Recursion;
using algo_ds_dotnet.Algorithms.Lesson6_Recursion.Excercises2;
using algo_ds_dotnet.Algorithms.Lesson7_Search;
using algo_ds_dotnet.Algorithms.Lesson8_BasicSorting;
using algo_ds_dotnet.Algorithms.Lesson9_IntermediateSorting;
using algo_ds_dotnet.DataStructures.L1_SinglyLinkedList;
using algo_ds_dotnet.DataStructures.L2_DoublyLinkedList;
using algo_ds_dotnet.DataStructures.L3_StacksQueues;
using algo_ds_dotnet.DataStructures.L3_StacksQueues.Queues;
using algo_ds_dotnet.DataStructures.L3_StacksQueues.Stacks;
using algo_ds_dotnet.DataStructures.L4_Trees.BinarySearchTrees;
using algo_ds_dotnet.DataStructures.L4_Trees.BreadthFirstSearch_BFS;
using algo_ds_dotnet.DataStructures.L4_Trees.DepthFirstSearch_DFS;
using algo_ds_dotnet.DataStructures.L5_Heaps;
using algo_ds_dotnet.DataStructures.L6_HashTables;
using algo_ds_dotnet.DataStructures.L7_Graphs;
using System;

namespace algo_ds_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lessons 1 - 5

            //AddNNumbers.Run();
            //NestedLoop.Run(2);

            //StringEachCharsCount.Run(Console.ReadLine());

            //FrequencyCounterPattern.Run();
            //StringAnagram.Run();

            //MultiplePointers_ArraySumZero.Run();
            //ArrayCountUniqueValues.Run();

            //SlidingWindow_MaxSubarraySum.Run();

            #endregion

            #region excercises

            //SameFrequency_Excercise.Run();
            //AreThereDuplicates_Excercise.Run();
            //AveragePair_Excercise.Run();
            //IsSubsequence_Excercise.Run();
            //MaxSubarraySum_Excercise.Run();

            #endregion

            #region recusrion

            //RecursionSimpleExample.Run();
            //FactorialExample.Run();
            //GetOddNumbers_Example.Run();
            //NumPower_Excercise.Run();
            //ProductOfArray_Excercise.Run();
            //Fibonacci_Excercise.Run();
            //ReverseString_Excercise.Run();
            //IsPalindrome_Excercise.Run();
            //ArrayAndCallback_Excercise.Run();
            //NestedEvenSum_Excercise.Run();

            #endregion

            #region searching

            //L1_LinearSearch.Run();
            //L2_BinarySearch.Run();
            //L2_BinarySearch_Recursively.Run();
            //L3_StringSearch_Naive.Run();

            #endregion

            #region basic sorting: bubble, selection, insertion

            //L1_BubbleSort.Run();
            //L2_SelectionSort.Run();
            //L3_InsertionSort.Run();

            #endregion

            #region sort

            //L1_MergingArrays.Run();
            //L2_MergeSort.Run();

            //L3_PivotHelper.Run();
            //L4_QuickSort.Run();

            //L5_RadixHelper.Run();
            //L6_RasixSort.Run();

            #endregion


            #region linked list

            //TestSinglyLinkedList.Run();
            //TestDoublyLinkedList.Run();

            #endregion

            #region stack - queues

            //TestStacks.Run();
            //TestQueues.Run();

            #endregion

            #region trees

            //BST_Test.Run(); //binary search tree
            //BFS_Test.Run(); //breadth-first search
            //DFS_Test.Run(); //depth-first search - pre-order

            #endregion

            #region heap

            //Heaps_Test.Run();

            #endregion

            #region hash tables

            //HashTables_Test.Run();

            #endregion

            #region graph

            //GraphTest.Run();
            //WeightedGraphTest.Run();

            #endregion


            #region dynamic programming

            Fibonacci_Dynamic.Run();

            #endregion

            Console.ReadLine();
        }
    }
}