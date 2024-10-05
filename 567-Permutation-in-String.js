/**
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
var checkInclusion = function(s1, s2) {
    if (s1.length > s2.lengtn)  return false
    const s1Count = getCharCount(s1);
    let windowCount = getCharCount(s2.substring(0, s1.length));
    if (compareObjects(s1Count, windowCount)) return true;
    for (let i = s1.length; i < s2.length; i++) {
        const newChar = s2[i];
        const oldChar = s2[i - s1.length];
        windowCount[newChar] = (windowCount[newChar] || 0) + 1;
        windowCount[oldChar]--;
        if (windowCount[oldChar] === 0) delete windowCount[oldChar]; 

        if (compareObjects(s1Count, windowCount)) return true;
    }
    return false
    function getCharCount(str) {
    const count = {};
    for (let char of str) {
        count[char] = (count[char] || 0) + 1;
    }
    return count;
}
function compareObjects(obj1, obj2) {
    if (Object.keys(obj1).length !== Object.keys(obj2).length) return false;
    for (let key in obj1) {
        if (obj1[key] !== obj2[key]) return false;
    }
    return true;
}

};