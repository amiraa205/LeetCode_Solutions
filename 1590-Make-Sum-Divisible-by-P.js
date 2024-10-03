/**
 * @param {number[]} nums
 * @param {number} p
 * @return {number}
 */
var minSubarray = function(nums, p) {
    const total =  nums.reduce((a,b) => a + b, 0)
    const req = total % p
    if (req === 0) return 0
    const preMap = new Map()
    preMap.set(0, -1)
    let preSum =0
    let minLength = nums.length
    for (let i =0; i <nums.length; i++){
        preSum = (preSum + nums[i]) % p
        const target = (preSum - req + p) % p 
        if (preMap.has(target)){
            minLength= Math.min(minLength, i - preMap.get(target))
        }

        preMap.set(preSum, i)
    }
    return minLength === nums.length ? -1 : minLength
     
};