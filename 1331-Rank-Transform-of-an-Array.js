var arrayRankTransform = function(arr) {
    if (arr.length === 0) return [];
    
    // Step 1: Create an array of pairs [value, original index]
    const indexedArr = arr.map((value, index) => [value, index]);
    
    // Step 2: Sort the array based on the values
    indexedArr.sort((a, b) => a[0] - b[0]);
    
    // Step 3: Create the result array and rank assignment
    const result = new Array(arr.length);
    let rank = 1;
    
    // Step 4: Assign ranks
    result[indexedArr[0][1]] = rank; // Assign rank 1 to the smallest value
    for (let i = 1; i < indexedArr.length; i++) {
        if (indexedArr[i][0] !== indexedArr[i - 1][0]) {
            rank++;
        }
        result[indexedArr[i][1]] = rank;
    }
    
    return result;
};

