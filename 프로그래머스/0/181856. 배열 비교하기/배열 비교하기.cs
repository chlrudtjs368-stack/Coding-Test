using System;

public class Solution
{
    public int solution(int[] arr1, int[] arr2) 
    {
        // arr1과 arr2의 길이비교.
        if (arr1.Length > arr2.Length) return 1;
        if (arr1.Length < arr2.Length) return -1;
        
        // 합 계산을 위한 합계 초기화
        int sum1 = 0;
        int sum2 = 0;
        
        // 배열 0번 부터 마지막 칸까지 전부 하나씩 sum1에 누적 덧셈
        // int i = 0; -> 반복문에서 쓸 인덱스 변수 i를 0으로 초기화
        // i < arr1.Length; i++ -> (앞에서 초기화했으니 0번째 배열부터) 마지막 배열칸까지 전부 하나씩 더함(i++)
        // sum1 += arr1[i]; -> arr1[i]를 한번씩 계속 더해서 누적(+=).
        for (int i = 0; i < arr1.Length; i++)
            sum1 += arr1[i];
        // 배열 0번 부터 마지막 칸까지 전부 하나씩 sum2에 누적 덧셈
        for (int i = 0; i < arr2.Length; i++)
            sum2 += arr2[i];
        
        // sum1의 값이 sum2 값보다 크면 1 반환
        if (sum1 > sum2) return 1;
        // sum1의 값이 sum2 값보다 작으면 -1 반환
        if (sum1 < sum2) return -1;
        // if문에 전부 해당되지않으면 0 반환
        return 0;
        
    }
}