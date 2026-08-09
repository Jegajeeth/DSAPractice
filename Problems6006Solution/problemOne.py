# problem solution for the problem set 0;

a = (1,3,4,2,7,5,6,9,8);
i = 0;
longestSumArrays = {};
maxcount = 0;
    
while(i < len(a)):
    currentTupEle = a[i];
    longestSumArray = [currentTupEle];
    while((i != len(a) - 1) and (a[i + 1] - currentTupEle >= 0)):
        longestSumArray.append(a[i+1]);
        currentTupEle = a[i + 1];
        i += 1;
    count = len(longestSumArray);
    if(count not in longestSumArrays.keys()):
        longestSumArrays[count] = [];
    longestSumArrays[count].append(longestSumArray);
    if(count > maxcount): 
        maxcount = count;
    longestSumArray = [];
    i += 1;

print(f"longestSumArrays = {longestSumArrays}");
print(f"maxcount = {maxcount}");
print(f"count of largest sumsubarray = {len(longestSumArrays[maxcount])}")