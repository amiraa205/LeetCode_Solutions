func minSwaps(nums []int) int {
    num := len(nums)
    total :=0
    for _, n := range nums {
        total += n
    }
    if total ==0 || total == num {
    return 0 }
     curr := 0
    for  i := 0; i< total; i++ {
        curr += nums[i]
    }
      max :=curr
    for i :=0;i<num; i++  {
        curr -= nums[i]
        curr += nums[(i + total) % num]
        if curr> max{
            max = curr
        }
       
    }
    return total - max


}